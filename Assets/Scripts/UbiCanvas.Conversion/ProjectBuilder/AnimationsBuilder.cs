using ImageMagick;
using Newtonsoft.Json;
using Spine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.Animation;
using UbiArt.ITF;
using UbiCanvas.Helpers;

namespace UbiCanvas.Conversion {
	public class AnimationsBuilder : ProjectBuilder {

		public AnimationsBuilder(string path) : base(path) { }

		public override string ID => "animations";

		protected override async Task BuildInternal() {
			await Task.CompletedTask;
			var inPath = System.IO.Path.Combine(ProjectPath, "animations");

			// Use alphabetical order. To prioritize a file being added, prefix the mod name with _
			foreach (var dir in System.IO.Directory.EnumerateDirectories(inPath).OrderBy(p => p)) {
				//string dirPath = dir.Substring(inputPath.Length).Replace('\\', '/').Trim('/');
				string dirPath = dir.Replace('\\', '/').Trim('/');
				foreach (string file in System.IO.Directory.GetFiles(dir, "*.json*", System.IO.SearchOption.AllDirectories)) {
					string relativePath = file.Substring(dirPath.Length).Replace('\\', '/').TrimStart('/');


					string uncookedPath = relativePath;
					uncookedPath = uncookedPath.Substring(0, uncookedPath.LastIndexOf('.'));
					var uncookedFolder = uncookedPath.Substring(0, uncookedPath.LastIndexOf('/'));
					var skeletonPath = new Path($"{uncookedPath}.skl");
					var texturePath = new Path($"{uncookedPath}.tga");
					var pbkPath = new Path($"{uncookedPath}.pbk");
					var actorName = pbkPath.GetFilenameWithoutExtension();
					var bankId = new StringID(actorName);
					var atlasPath = file.Replace(".json", ".atlas");
					var originalTexturePath = file.Replace(".json", ".png");
					var imagesDir = file.Substring(0, file.Replace('\\', '/').LastIndexOf('/'));

					TextureLoader textureLoader = new NoOpTextureLoader();
					using var atlasReader = new System.IO.StreamReader(atlasPath);
					Atlas atlas = new Atlas(atlasReader, imagesDir, textureLoader);
					var json = new SkeletonJson(atlas);
					var skeletonData = json.ReadSkeletonData(file);

					uint currentLink;

					#region Skeleton
					currentLink = 1;

					// Create skeleton
					var skeleton = new AnimSkeleton() {
						version = AnimSkeleton.VersionLegends,
						bones = new CListO<AnimBone>(),
						bonesDyn = new CListO<AnimBoneDyn>(),
						boneIndices = new CListO<StringID>(),
						boneTags = new CListO<StringID>(),
						boneTags2 = new CListO<StringID>(),
						boneIndices2 = new CListO<StringID>(),
						bankId = bankId.stringID
					};
					uint boneIndex = 0;
					foreach (var b in skeletonData.Bones) {
						var bone = new AnimBone() {
							tag = b.Name,
							flags = 7, // or 3 for root?
							key = new Link(currentLink++),
							parentKey = new Link()
						};
						if(b.Parent != null) bone.parentKey = new Link((uint)b.Parent.Index + 1);
						skeleton.bones.Add(bone);
						
						skeleton.boneIndices.Add(new StringID(boneIndex));
						skeleton.boneIndices2.Add(new StringID(boneIndex));
						skeleton.boneTags.Add(b.Name);
						skeleton.boneTags2.Add($"BoneTag2_{b.Name}");

						//var drawIndex = boneDrawOrder.IndexOf(b.Name);

						var boneDyn = new AnimBoneDyn() {
							position = new Vec2d(b.X, -b.Y),
							angle = new Angle(b.Rotation, degrees: true),
							scale = new Vec2d(/*b.Length **/ b.ScaleX, b.ScaleY),
							float6 = 1,
							z = 0 //drawIndex// / (float)skeletonData.Bones.Count
						};
						//UnityEngine.Debug.Log($"{b.Name}: {boneDyn.position} - {boneDyn.angle}");
						skeleton.bonesDyn.Add(boneDyn);
						boneIndex++;
					}
					Bundle.AddFile(skeletonPath.CookedPath(TargetContext), skeleton);
					#endregion

					#region Patch bank
					// Create patch bank
					currentLink = 1;
					var pbk = new AnimPatchBank() {
						version = AnimPatchBank.VersionLegends,
						unk = 1f,
						bankId = new Link(currentLink++),
						templateKeys = new KeyArray<int>() {
							keysLegends = new CArrayO<StringID>(),
							values = new CArray<int>()
						},
						templates = new CListO<AnimTemplate>()
					};
					var drawOrder = new Skeleton(skeletonData).DrawOrder;
					var slotDrawOrder = drawOrder.Select(s => s.Data.Index).ToList();

					var skin = skeletonData.DefaultSkin;
					foreach (var att in skin.Attachments) {
						var slot = skeletonData.Slots.ElementAt(att.SlotIndex);
						if(att.Attachment is not RegionAttachment region) continue;
						var templateName = $"{slot.Name}/{att.Name}";

						var bone = slot.BoneData;
						var templateIndex = pbk.templates.Count;
						pbk.templateKeys.keysLegends.Add(templateName);
						pbk.templateKeys.values.Add(templateIndex);

						var template = new AnimTemplate() {
							boneKeys = new KeyArray<int>() {
								keysLegends = new CArrayO<StringID>() { bone.Name },
								values = new CArray<int>() { 0 }
							},
							bones = new CListO<AnimBone>() {
								new AnimBone() {
									tag = bone.Name,
									flags = 3, // or 3 for root?
									key = new Link(currentLink++),
									pointLinks = new CListO<Link>()
								}
							},
							bonesDyn = new CListO<AnimBoneDyn>() {
								new AnimBoneDyn() {
									position = new Vec2d(0f, 0f),
									angle = 0f,
									scale = new Vec2d(1f, 1f), // Should this change?
									float6 = 1,
									z = slotDrawOrder.IndexOf(slot.Index) //) / (float)slotDrawOrder.Count
								}
							},
							patches = new CListO<AnimPatch>() {
								new AnimPatch() {
									numPoints = 4,
									bankId = pbk.bankId,
									templateIndex = (uint)templateIndex,
									points = new Link[4]
								}
							},
							patchPoints = new CListO<AnimPatchPoint>(),
						};
						for (int pointIndex = 0; pointIndex < 4; pointIndex++) {
							const int BL = 0, UL = 1, UR = 2, BR = 3;
							var pi = pointIndex switch {
								/*0 => BR,
								1 => BL,
								2 => UR,
								3 => UL,*/
								0 => UL,
								1 => BL,
								2 => UR,
								3 => BR,
								_ => 0
							};
							var ui = pi;
							var uv = new Vec2d(region.UVs[pi * 2], region.UVs[pi * 2 + 1]);
							var pos = new Vec2d(region.Offset[pi * 2], region.Offset[pi * 2 + 1]);
							if (region.Region is AtlasRegion ar) {
								// Calculate UV
								if (ar.degrees == 90) {
									// Uvs are rotated
									uv = pi switch {
										UL => new Vec2d(ar.u, ar.v2),
										UR => new Vec2d(ar.u, ar.v),
										BL => new Vec2d(ar.u2, ar.v2),
										BR => new Vec2d(ar.u2, ar.v),
										_ => uv
									};
								} else {
									uv = pi switch {
										UL => new Vec2d(ar.u, ar.v),
										UR => new Vec2d(ar.u2, ar.v),
										BL => new Vec2d(ar.u, ar.v2),
										BR => new Vec2d(ar.u2, ar.v2),
										_ => uv
									};
								}

								// Calculate position
								var minPos = new Vec2d(-region.Width, -region.Height) / 2;
								var maxPos = new Vec2d(region.Width, region.Height) / 2;
								minPos += new Vec2d(
									ar.offsetX / ar.originalWidth * region.Width,
									ar.offsetY / ar.originalHeight * region.Height);
								if (ar.degrees == 90) {
									maxPos -= new Vec2d(
										(ar.originalWidth - ar.offsetX - ar.packedHeight) / ar.originalWidth * region.Width,
										(ar.originalHeight - ar.offsetY - ar.packedWidth) / ar.originalHeight * region.Height);
								} else {
									maxPos -= new Vec2d(
										(ar.originalWidth - ar.offsetX - ar.packedWidth) / ar.originalWidth * region.Width,
										(ar.originalHeight - ar.offsetY - ar.packedHeight) / ar.originalHeight * region.Height);
								}
								pos = pi switch {
									UL => new Vec2d(minPos.x, maxPos.y),
									UR => new Vec2d(maxPos.x, maxPos.y),
									BL => new Vec2d(minPos.x, minPos.y),
									BR => new Vec2d(maxPos.x, minPos.y),
									_ => pos
								};
								pos *= new Vec2d(region.ScaleX, region.ScaleY);
								pos = pos.Rotate(new Angle(region.Rotation, degrees: true));
								pos += new Vec2d(region.X, region.Y);
							}

							var ppId = new Link(currentLink++);
							var pp = new AnimPatchPoint() {
								key = ppId,
								index = (uint)pointIndex,
								uv = uv,
								normal = Vec2d.Zero,
								local = new AnimPatchPointLocal() {
									boneId = template.bones[0].key,
									pos = pos,
									normal = Vec2d.Zero
								}
							};
							template.patchPoints.Add(pp);
							template.patches[0].points[pointIndex] = ppId;
							template.bones[0].pointLinks.Add(ppId);
						}
						pbk.templates.Add(template);
					}
					Bundle.AddFile(pbkPath.CookedPath(TargetContext), pbk);
					#endregion

					#region Animations
					// Create animations
					List<Path> animationPaths = new List<Path>();
					foreach (var anm in skeletonData.Animations) {
						var spineSkeleton = new Skeleton(skeletonData);
						var animationPath = $"{uncookedFolder}/{anm.Name}.anm";
						animationPaths.Add(new Path(animationPath));
						var fps = 60f;
						int frames = (int)MathF.Floor(anm.Duration * fps);
						var animation = new AnimTrack() {
							version = AnimTrack.VersionLegends,
							length = frames,
							bml = new CListO<AnimTrackBML>(),
							bonePAS = new CListO<AnimTrackBonePAS>(),
							boneZAL = new CListO<AnimTrackBoneZAL>(),
							multiplierA = 1,
							multiplierP = 1,
							multiplierS = 1,
							bonesLists = new CListO<AnimTrackBonesList>(),
							skeleton = new pair<StringID, Path>(skeletonPath.stringID, skeletonPath),
							texturePaths = new CListO<pair<StringID, Path>>() {
								new pair<StringID, Path>(texturePath.stringID, texturePath)
							},
							LocalAABB = new AABB() {
								MIN = new Vec2d(-5000, -5000),
								MAX = new Vec2d(5000, 5000)
							},
							bankId = bankId.stringID,
							unk2 = 3
						};

						var lastTime = 0f;
						var blend = MixBlend.First;
						var direction = MixDirection.In;
						ExposedList<Spine.Event> events = new ExposedList<Spine.Event>();
						BoneFrames[] boneFrames = new BoneFrames[skeleton.bones.Count];
						for (int i = 0; i < boneFrames.Length; i++) {
							boneFrames[i] = new BoneFrames();
						}
						AnimTrackBML currentBML = null;
						for (int i = 0; i < frames; i++) {
							var time = i / (float)fps;
							anm.Apply(spineSkeleton, lastTime, time, false, events, 1f, blend, direction);

							// Calculate BML
							var newBML = new AnimTrackBML() {
								frame = i,
								entries = new CListO<AnimTrackBML.Entry>()
							};
							foreach (var slot in spineSkeleton.Slots) {
								var att = slot.Attachment;
								if (att is not RegionAttachment region) continue;
								var templateName = $"{slot.Data.Name}/{att.Name}";
								newBML.entries.Add(new AnimTrackBML.Entry() {
									textureBankId = bankId,
									templateId = templateName
								});
							}
							if (currentBML != null) {
								// check attachments
								if (currentBML.entries.Count != newBML.entries.Count) {
									currentBML = null;
								} else {
									foreach (var e in newBML.entries) {
										if (!currentBML.entries.Any(e2 => e2.templateId == e.templateId)) {
											// BML has changed between frames, needs to be updated
											currentBML = null;
											break;
										}
									}
								}
							}
							if (currentBML == null) {
								currentBML = newBML;
								animation.bml.Add(currentBML);
							}
							

							// Check new bone positions etc, fill in BoneFrames. Later use this to fill BonePAS
							var bi = 0;
							foreach (var b in spineSkeleton.Bones) {
								var bf = boneFrames[bi];
								var pos = new Vec2d(b.X, -b.Y);
								var rot = new Angle(b.Rotation, degrees: true);
								var scl = new Vec2d(b.ScaleX, b.ScaleY);

								// Subtract bind pos/rot/scl
								pos -= new Vec2d(b.Data.X, -b.Data.Y);
								rot -= new Angle(b.Data.Rotation, degrees: true);
								scl /= new Vec2d(b.Data.ScaleX, b.Data.ScaleY);

								var f = new BoneFrame() {
									Frame = i,
									Position = pos,
									Angle = rot,
									Scale = scl
								};
								var lastFrame = bf.Frames.LastOrDefault();
								if (lastFrame == null || !lastFrame.Matches(f)) {
									if (lastFrame != null && lastFrame.Frame != (i - 1)) {
										// Current frame does not match last and is more than 1 frame beforet his one
										// So we have to add a new keyframe here to keep the game from interpolating
										bf.Frames.Add(new BoneFrame() {
											Frame = i - 1,
											Position = lastFrame.Position,
											Angle = lastFrame.Angle,
											Scale = lastFrame.Scale
										});
									}
									bf.Frames.Add(f);
								}
								bi++;
							}

							lastTime = time;
						}

						// Calculate PAS multipliers
						var positions = boneFrames.SelectMany(bf => bf.Frames.Select(f => f.Position));
						var scales = boneFrames.SelectMany(bf => bf.Frames.Select(f => f.Scale));
						var angles = boneFrames.SelectMany(bf => bf.Frames.Select(f => f.Angle));
						var positionMultiplier = positions.Max(p => MathF.Max(MathF.Abs(p.x), MathF.Abs(p.y))) + 0.5f;
						var scaleMultiplier = scales.Max(p => MathF.Max(MathF.Abs(p.x), MathF.Abs(p.y))) + 0.5f;
						var angleMultiplier = angles.Max(a => MathF.Abs(a)) + 0.5f;
						animation.multiplierA = angleMultiplier;
						animation.multiplierP = positionMultiplier;
						animation.multiplierS = scaleMultiplier;
						foreach (var bf in boneFrames) {
							foreach (var f in bf.Frames) {
								f.Position = f.Position / positionMultiplier;
								f.Scale = f.Scale / scaleMultiplier;
								f.Angle = new Angle(f.Angle / angleMultiplier);
							}

							animation.bonesLists.Add(new AnimTrackBonesList() {
								startPAS = (ushort)animation.bonePAS.Count,
								amountPAS = (ushort)bf.Frames.Count
							});
							foreach (var f in bf.Frames) {
								animation.bonePAS.Add(new AnimTrackBonePAS() {
									frame = (ushort)f.Frame,
									Position = f.Position,
									Rotation = f.Angle,
									Scale = f.Scale,
								});
							}
						}

						Bundle.AddFile(new Path(animationPath).CookedPath(TargetContext), animation);
					}
					#endregion

					#region Template
					// Create template
					var templatePath = new Path($"{uncookedPath}_animonly.tpl");
					GenericFile<Actor_Template> tpl = new GenericFile<Actor_Template>(new Actor_Template());
					var animTPL = tpl.obj.AddComponent<AnimatedComponent_Template>();

					animTPL.animSet = new SubAnimSet_Template() {
						animPackage = new AnimResourcePackage() {
							skeleton = skeletonPath,
							textureBank = new CListO<TextureBankPath>() {
								new TextureBankPath() {
									id = bankId,
									patchBank = pbkPath,
									materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
									textureSet = new GFXMaterialTexturePathSet() {
										diffuse = texturePath
									}
								}
							},
							animPathAABB = new CListO<AnimPathAABB>(),
							packed = true,
							fromHD = true
						},
						animations = new CListO<SubAnim_Template>()
					};
					animTPL.tree = new AnimTree_Template() {
						nodes = new CListO<Generic<BlendTreeNodeTemplate<AnimTreeResult>>>(),
						nodeTransitions = new CListO<BlendTreeTransition_Template<AnimTreeResult>>(),
					};
					foreach (var anm in skeletonData.Animations) {
						var animationPath = $"{uncookedFolder}/{anm.Name}.anm";
						animTPL.animSet.animPackage.animPathAABB.Add(new AnimPathAABB() {
							name = anm.Name,
							path = new Path(animationPath),
							aabb = new AABB() {
								MIN = new Vec2d(-100, -100),
								MAX = new Vec2d(100, 100),
							}
						});
						animTPL.animSet.animations.Add(new SubAnim_Template() {
							friendlyName = anm.Name,
							name = new Path(animationPath),
							loop = true,
							forceZOffset = true,
							forceZOffset2 = SubAnim_Template.BOOL._true,
						});
						animTPL.tree.nodes.Add(new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
							animationName = anm.Name,
							nodeName = anm.Name,
						}));
					}
					/*animTPL.tree = new AnimTree_Template() {
						nodeTransitions = new CListO<BlendTreeTransition_Template<AnimTreeResult>>() {
							new BlendTreeTransition_Template<AnimTreeResult>() {
								blend = 20,
								from = new CArrayO<StringID>() { "sg_stand" },
								to = new CArrayO<StringID>() { "sg_medi" }
							}
						}
					};*/

					animTPL.defaultAnimation = skeletonData.Animations.First().Name;
					animTPL.patchHLevel = 2;
					animTPL.patchVLevel = 2;
					animTPL.scale = Vec2d.One / 400f;
					animTPL.posOffset = Vec2d.Zero;


					Bundle.AddFile(templatePath.CookedPath(TargetContext), tpl);
					#endregion
				}
			}
		}

		/*public override async Task BuildBundle() {
			await base.BuildBundle();
			throw new NotImplementedException();
		}*/

		public class NoOpTextureLoader : TextureLoader {
			public void Load(AtlasPage page, string path) { }
			public void Unload(object texture) { }
		}

		private class BoneFrames {
			public List<BoneFrame> Frames { get; set; } = new List<BoneFrame>();
		}
		private class BoneFrame {
			public int Frame { get; set; }
			public Vec2d Position { get; set; }
			public Angle Angle { get; set; }
			public Vec2d Scale { get; set; }

			public bool Matches(BoneFrame frame) {
				if (frame.Position != Position) return false;
				if (frame.Angle != Angle) return false;
				if (frame.Scale != Scale) return false;
				return true;
			}
		}
	}
}
