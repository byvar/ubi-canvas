﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Conversion.Json;

namespace UbiCanvas.Conversion {
	public class SimpleObjectBuilder : ProjectBuilder {

		public SimpleObjectBuilder(string projectPath) : base(projectPath) {
		}

		public override string ID => "simpleobject";

		protected override async Task BuildInternal() {
			var inPath = System.IO.Path.Combine(ProjectPath, "json", "simpleobject");


			// Use alphabetical order. To prioritize a file being added, prefix the mod name with _
			foreach (var dir in System.IO.Directory.EnumerateDirectories(inPath).OrderBy(p => p)) {
				//string dirPath = dir.Substring(inputPath.Length).Replace('\\', '/').Trim('/');
				string dirPath = dir.Replace('\\', '/').Trim('/');
				foreach (string file in System.IO.Directory.GetFiles(dir, "*.json", System.IO.SearchOption.AllDirectories)) {
					string relativePath = file.Substring(dirPath.Length).Replace('\\', '/').TrimStart('/');

					string uncookedPath = relativePath;
					uncookedPath = uncookedPath.Substring(0, uncookedPath.LastIndexOf('.'));
					var cookedPath = new Path(uncookedPath).CookedPath(TargetContext);

					if (true || !FileIsAlreadyBuilt(cookedPath)) {
						var json = System.IO.File.ReadAllText(file);

						if (uncookedPath.ToLowerInvariant().EndsWith(".isc")) {
							var simpleISC = JsonConvert.DeserializeObject<JSON_SimpleScene>(json);
							var isc = new Scene();

							isc.ACTORS = new CArrayO<Generic<Actor>>();
							isc.FRISE = new CListO<Frise>();
							if (simpleISC.Actor != null) {
								foreach (var simpleACT in simpleISC.Actor) {
									var act = await CreateActor(simpleACT);
									isc.AddActor(act);
								}
							}
							if (simpleISC.Frise != null) {
								foreach (var simpleF in simpleISC.Frise) {
									var f = await CreateFrise(simpleF);
									isc.FRISE.Add(f);
								}
							}

							var iscFile = new ContainerFile<Scene>() {
								read = true,
								obj = isc
							};
							Bundle.AddFile(cookedPath, iscFile);
						} else if (uncookedPath.ToLowerInvariant().EndsWith(".fcg")) {
							var simpleFCG = JsonConvert.DeserializeObject<JSON_SimpleFriseConfig>(json);
							var fcg = await CreateFriseConfig(simpleFCG);

							var fcgFile = new GenericFile<FriseConfig>(fcg);
							Bundle.AddFile(cookedPath, fcgFile);
						}
					}
				}
			}
		}

		protected void FillPickable(Pickable pickable, JSON_SimplePickable simple) {
			pickable.POS2D = simple.Position ?? Vec2d.Zero;
			pickable.SCALE = simple.Scale ?? Vec2d.One;
			pickable.RELATIVEZ = simple.Z;
			pickable.ANGLE = new Angle(simple.Angle);
			pickable.USERFRIENDLY = simple.Name;
			pickable.xFLIPPED = simple.XFlip;
		}

		protected async Task<Actor> CreateActor(JSON_SimplePickable simple) {
			Actor act;
			if (simple.TemplatePath.ToLowerInvariant().EndsWith(".tpl")) {
				var pTPL = new Path(simple.TemplatePath);
				var tpl = await LoadFileFromPatchData<GenericFile<Actor_Template>>(TargetContext, simple.TemplatePath);
				act = tpl.obj.Instantiate(pTPL);
			} else {
				var actContainer = await LoadFileFromPatchData<ContainerFile<Actor>>(TargetContext, simple.TemplatePath);
				act = (Actor)(await TargetContext.Loader.Clone(actContainer.obj, "act"));
			}

			FillPickable(act, simple);
			var trig = act.GetComponent<TriggerComponent>();
			if (trig != null) {
				if (trig.mode == 0) {
					trig.mode = TriggerComponent.Mode.Multiple;
				}
			}
			switch (simple.TemplatePath) {
				case "world/common/enemy/lividstone/lividstone_drag.act":
				case "world/common/enemy/darktoon/darktoon_basic/components/darktoon_basic.tpl":
					act.GetComponent<RO2_EnemyBTAIComponent>().useRoaming = true;
					break;
				case "world/common/enemy/hunter/components/hunter.tpl":
					act.GetComponent<RO2_EnemyBTAIComponent>().useRangedAttack_RL = 1;
					break;
				case "world/common/enemy/blowingbird/components/blowingbird_horizontal_auto.tpl":
					act.GetComponent<RO2_EnemyBTAIComponent>().useNightVision = true;
					break;
			}
			if (simple.ExtraOptions != null) {
				foreach (var opt in simple.ExtraOptions) {
					var values = opt.Value.Split(';');
					switch (opt.Key) {
						case "CameraModifierComponent.localAABB": {
								var cm = act?.GetComponent<CameraModifierComponent>();
								//cm.ignoreAABB = true;
								if (cm != null) {
									cm.localAABB = new AABB() {
										MIN = new Vec2d(float.Parse(values[0]), float.Parse(values[1])),
										MAX = new Vec2d(float.Parse(values[2]), float.Parse(values[3])),
									};
								}
								if(cm.CM == null) cm.CM = new CamModifier();

								//cm.CM.lookAtOffset = new Vec3d(0,0,13);
								//cm.CM.lookAtOffsetMax = new Vec3d(0,0,13);
								/*void TreatConstraint(ConstraintExtended constraint) {
									constraint.timeToWaitBeforeDecrease = 0f;
									constraint.timeToDecrease = 0f;
									constraint.timeToIncrease = 0f;
								}
								TreatConstraint(cm.CM.constraintExtendedTop);
								TreatConstraint(cm.CM.constraintExtendedBottom);
								TreatConstraint(cm.CM.constraintExtendedLeft);
								TreatConstraint(cm.CM.constraintExtendedRight);*/
							}
							break;
						case "LinkComponent.links":
							var lc = act?.GetComponent<LinkComponent>();
							if (lc != null) {
								foreach (var val in values) {
									var tagPattern = @"Tag\((.*),(.*)\)";
									var matches = Regex.Matches(val, tagPattern);
									if (matches.Count > 0) {
										// It's a tag for the previous child
										var child = lc.Children.Last();
										child.AddTag(matches.First().Groups[1].Value, matches.First().Groups[2].Value);
									} else {
										lc.Children.Add(new ChildEntry() {
											Path = new ObjectPath(val)
										});
									}
								}
							}
							break;
						case "RO2_RopeComponent.length":
							var rc = act?.GetComponent<RO2_RopeComponent>();
							if (rc != null) {
								rc.initLenth = float.Parse(opt.Value);
								//rc.rigidConstraintFactor = 0f; 
								//rc.force = 0f;
								rc.PrimitiveParameters.colorFactor = new Color(1,1,1,0);
							}
							break;
						case "RO2_MinotaurShieldAIComponent.standOnce":
							var mcai = act?.GetComponent<RO2_MinotaurShieldAIComponent>();
							if (mcai != null) {
								mcai.standOnce = bool.Parse(opt.Value);
							}
							break;
					}
				}
			}

			return act;
		}
		protected async Task<Frise> CreateFrise(JSON_SimpleFrise simple) {
			await Task.CompletedTask;
			Frise fr = new Frise();
			fr.UseTemplatePrimitiveParams = false; // ?
			FillPickable(fr, simple);

			Vec2d LocalToGlobal(Vec2d point) => (point * fr.SCALE).Rotate(fr.ANGLE) + fr.POS2D;
			Vec3d LocalToGlobal3D(Vec3d point) {
				var v2d = LocalToGlobal(new Vec2d(point.x, point.y));
				return new Vec3d(v2d.x, v2d.y, point.z + fr.RELATIVEZ);
			}

			fr.ConfigName = new Path(simple.TemplatePath);

			fr.PointsList = CreatePolyPointList(simple.Points);

			fr.PreComputedForCook = simple.Precomputed;

			// Collision
			if (simple.HasCollision) {
				var collisions = simple.CollisionPoints ?? new List<JSON_SimpleFrise.JSON_PolyPointList>() { simple.Points };
				fr.collisionData = new UbiArt.Nullable<Frise.CollisionData>(
					new Frise.CollisionData() {
						LocalCollisionList = new CListO<PolyPointList>(collisions.Select(c => CreatePolyPointList(c)).ToList()),
						WorldCollisionList = new CListO<PolyLine>(collisions.Select(c => new PolyLine() {
							PolyPointList = CreatePolyPointList(c),
							connection = new PolyLine.Connection() {
							},
						}).ToList())
					}
				);
				// "Globalize" global polypointlist
				foreach (var globalList in fr.collisionData.value.WorldCollisionList) {
					foreach (var p in globalList.PolyPointList.LocalPoints) {
						p.POS = LocalToGlobal(p.POS);
					}
					globalList.PolyPointList.RecomputeData();
					globalList.AABB = new AABB() {
						MIN = new Vec2d(globalList.PolyPointList.LocalPoints.Min(p => p.POS.x), globalList.PolyPointList.LocalPoints.Min(p => p.POS.y)),
						MAX = new Vec2d(globalList.PolyPointList.LocalPoints.Max(p => p.POS.x), globalList.PolyPointList.LocalPoints.Max(p => p.POS.y)),
					};
				}
			}

			// Fill in visual data
			fr.meshBuildData = new UbiArt.Nullable<Frise.MeshBuildData>(new Frise.MeshBuildData() {
				StaticIndexList = new CListO<Frise.IndexList>(),
				StaticVertexList = new CListO<VertexPCT>()
			});
			if (simple.Geometry != null) {
				fr.meshBuildData.value.StaticIndexList = new CListO<Frise.IndexList>(
					simple.Geometry.Elements.Select(el => new Frise.IndexList() {
						IdTexConfig = (uint)el.Material, 
						List = new CListP<ushort>(el.Indices.Select(i => (ushort)i).ToList())
					}).ToList()
				);
				fr.meshBuildData.value.StaticVertexList = new CListO<VertexPCT>(
					simple.Geometry.Vertices.Select(v => new VertexPCT() {
						pos = v.Position,
						uv = v.UV,
						color = v.Color.ColorInteger
					}).ToList()
				);
			}

			// Fill in meshStaticAABB based on visual data
			if (fr.meshBuildData.value?.StaticVertexList?.Any() ?? false) {
				var globalV = fr.meshBuildData.value.StaticVertexList.Select(v => LocalToGlobal3D(v.pos));
				fr.meshStaticData = new UbiArt.Nullable<Frise.MeshStaticData>(new Frise.MeshStaticData() {
					WorldAABB = new AABB() {
						MIN = new Vec2d(fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.x), fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.y)),
						MAX = new Vec2d(fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.x), fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.y))
					},
					LocalAABB = new AABB() {
						MIN = new Vec2d(globalV.Min(v => v.x), globalV.Min(v => v.y)),
						MAX = new Vec2d(globalV.Max(v => v.x), globalV.Max(v => v.y))
					},
				});
				fr.AABB_MinZ = fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.z);
				fr.AABB_MaxZ = fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.z);
			}

			return fr;
		}

		protected async Task<FriseConfig> CreateFriseConfig(JSON_SimpleFriseConfig simple) {
			await Task.CompletedTask;
			var fcg = new FriseConfig() {
				TAGS = new CListP<string>(new List<string>() {
					"frieze"
				}),
				textureConfigs = new CListO<FriseTextureConfig>(simple.Textures.Select(t => new FriseTextureConfig() {
					material = new GFXMaterialSerializable() {
						textureSet = new GFXMaterialTexturePathSet() {
							diffuse = new Path(t.Diffuse),
							back_light = new Path(t.Backlight)
						},
						shaderPath = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
					},
				}).ToList()),
				gameMaterial = new Path(simple.GameMaterial)
			};
			return fcg;
		}
		protected PolyPointList CreatePolyPointList(JSON_SimpleFrise.JSON_PolyPointList simple) {
			var points = new PolyPointList() {
				LocalPoints = new CListO<PolyLineEdge>(simple.Points.Select(p => new PolyLineEdge() {
					POS = p.Position,
					GameMaterial = string.IsNullOrWhiteSpace(p.GameMaterial) ? new StringID() : new StringID(p.GameMaterial),
					Scale = p.Scale,
				}).ToList()),
				Loop = simple.Loop,
			};
			if (simple.Loop) {
				points.LocalPoints.Add(new PolyLineEdge() {
					POS = simple.Points[0].Position,
					GameMaterial = simple.Points[0].GameMaterial,
					Scale = simple.Points[0].Scale,
				});
			}
			points.RecomputeData();
			return points;
		}
	}
}
