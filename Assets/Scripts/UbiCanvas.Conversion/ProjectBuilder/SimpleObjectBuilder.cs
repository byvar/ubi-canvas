using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

					if (!FileIsAlreadyBuilt(cookedPath)) {
						var json = System.IO.File.ReadAllText(file);

						if (uncookedPath.ToLowerInvariant().EndsWith(".isc")) {
							var simpleISC = JsonConvert.DeserializeObject<JSON_SimpleScene>(json);
							var isc = new Scene();

							isc.ACTORS = new CArrayO<Generic<Actor>>();
							isc.FRISE = new CListO<Frise>();
							if (simpleISC.Actor != null) {
								foreach (var simpleACT in simpleISC.Actor) {
									var act = await CreateActor(simpleACT);
									isc.AddActor(act, simpleACT.Name);
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
							var fcg = new FriseConfig();

							// TODO

							var fcgFile = new GenericFile<FriseConfig>(fcg);
							Bundle.AddFile(cookedPath, fcgFile);
						}
					}
				}
			}
		}

		protected void FillPickable(Pickable pickable, JSON_SimplePickable simple) {
			pickable.POS2D = simple.Position;
			pickable.SCALE = simple.Scale;
			pickable.RELATIVEZ = simple.Z;
			pickable.ANGLE = simple.Angle;
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
			return act;
		}
		protected async Task<Frise> CreateFrise(JSON_SimpleFrise simple) {
			await Task.CompletedTask;
			Frise fr = new Frise();
			FillPickable(fr, simple);

			Vec2d LocalToGlobal(Vec2d point) => (point * fr.SCALE).Rotate(fr.ANGLE) + fr.POS2D;
			Vec3d LocalToGlobal3D(Vec3d point) {
				var v2d = LocalToGlobal(new Vec2d(point.x, point.y));
				return new Vec3d(v2d.x, v2d.y, point.z + fr.RELATIVEZ);
			}

			fr.ConfigName = new Path(simple.TemplatePath);

			fr.PointsList = CreatePolyPointList(simple.Points);

			// Collision
			if (simple.HasCollision) {
				fr.collisionData = new UbiArt.Nullable<Frise.CollisionData>(
					new Frise.CollisionData() {
						LocalCollisionList = new CListO<PolyPointList>() {
						CreatePolyPointList(simple.Points),
						},
						WorldCollisionList = new CListO<PolyLine>() {
							new PolyLine() {
								PolyPointList = CreatePolyPointList(simple.Points),
							},
						},
					}
				);
				// "Globalize" global polypointlist
				var globalList = fr.collisionData.value.WorldCollisionList[0].PolyPointList;
				foreach (var p in globalList.LocalPoints) {
					p.POS = LocalToGlobal(p.POS);
				}
				globalList.RecomputeData();

				fr.collisionData.value.WorldCollisionList[0].AABB = new AABB() {
					MIN = new Vec2d(globalList.LocalPoints.Min(p => p.POS.x), globalList.LocalPoints.Min(p => p.POS.y)),
					MAX = new Vec2d(globalList.LocalPoints.Max(p => p.POS.x), globalList.LocalPoints.Max(p => p.POS.y)),
				};
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
				fr.meshStaticData = new UbiArt.Nullable<Frise.MeshStaticData>(new Frise.MeshStaticData() {
					LocalAABB = new AABB() {
						MIN = new Vec2d(fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.x), fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.y)),
						MAX = new Vec2d(fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.x), fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.y))
					},
					WorldAABB = new AABB() {
						MIN = new Vec2d(fr.meshBuildData.value.StaticVertexList.Min(v => LocalToGlobal3D(v.pos).x), fr.meshBuildData.value.StaticVertexList.Min(v => LocalToGlobal3D(v.pos).y)),
						MAX = new Vec2d(fr.meshBuildData.value.StaticVertexList.Max(v => LocalToGlobal3D(v.pos).x), fr.meshBuildData.value.StaticVertexList.Max(v => LocalToGlobal3D(v.pos).y))
					},
				});
				fr.AABB_MinZ = fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.z);
				fr.AABB_MaxZ = fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.z);
			}

			return fr;
		}

		protected PolyPointList CreatePolyPointList(JSON_SimpleFrise.JSON_PolyPointList simple) {
			var points = new PolyPointList() {
				LocalPoints = new CListO<PolyLineEdge>(simple.Points.Select(p => new PolyLineEdge() {
					POS = p.Position,
					GMatOverride = string.IsNullOrWhiteSpace(p.GameMaterialOverride) ? new StringID() : new StringID(p.GameMaterialOverride),
					Scale = p.Scale,
				}).ToList()),
				Loop = simple.Loop,
			};
			if (simple.Loop) {
				points.LocalPoints.Add(new PolyLineEdge() {
					POS = simple.Points[0].Position,
					GMatOverride = simple.Points[0].GameMaterialOverride,
					Scale = simple.Points[0].Scale,
				});
			}
			points.RecomputeData();
			return points;
		}
	}
}
