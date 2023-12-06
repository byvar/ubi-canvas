using System;
using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UbiArt.ITF;

namespace UbiArt {
	public class OriginsAnimationConverter {
		public class AnimationGroup {
			public AnimSkeleton Skeleton { get; set; }
			public Dictionary<Path, Path> TextureBanks { get; set; } = new Dictionary<Path, Path>();
			public Dictionary<Path, AnimPatchBank> PatchBanks { get; set; } = new Dictionary<Path, AnimPatchBank>();
			public Dictionary<Path, AnimTrack> Animations { get; set; } = new Dictionary<Path, AnimTrack>();
		}
		public Dictionary<AnimSkeleton, AnimationGroup> AnimationGroups { get; set; } = new Dictionary<AnimSkeleton, AnimationGroup>();

		public void CreateAnimationGroups(Context context) {
			var structs = context.Cache.Structs;
			if (structs.TryGetValue(typeof(AnimTrack), out var anims)) {
				foreach (var anim in anims) {
					var animPath = context.Loader.Paths[anim.Key];
					var a = (AnimTrack)anim.Value;
					if (a.skeletonOrigins != null) {
						a.skeleton = new pair<StringID, Path>(a.skeletonOrigins.Item1, new Path(a.skeletonOrigins.Item2));
					}
					if (a.texturePathsOrigins != null) {
						a.texturePaths = new CListO<pair<StringID, Path>>();
						for (int i = 0; i < a.texturePathKeysOrigins.keysLegends.Count; i++) {
							var pathIndex = a.texturePathKeysOrigins.values[i];
							var path = new Path(a.texturePathsOrigins[pathIndex].Item2);
							a.texturePaths.Add(new pair<StringID, Path>(a.texturePathKeysOrigins.keysLegends[i], path));
						}
					}
					var skeletonPath = a?.skeleton?.Item2;
					if(skeletonPath == null) continue;
					var skeleton = context.Cache.Get<AnimSkeleton>(skeletonPath);
					if(skeleton == null) continue;
					if (!AnimationGroups.ContainsKey(skeleton)) {
						AnimationGroups[skeleton] = new AnimationGroup() {
							Skeleton = skeleton
						};
					}
					var grp = AnimationGroups[skeleton];
					grp.Animations[animPath] = a;
					if (a.texturePaths != null) {
						foreach (var texPath in a.texturePaths) {
							var texturePath = texPath?.Item2;
							if(texturePath == null || texturePath.IsNull) continue;
							if (!grp.TextureBanks.ContainsKey(texturePath)) {
								var pbkPath = new Path($"{texturePath.GetFilenameWithoutExtension(fullPath: true)}.pbk");
								var pbk = context.Cache.Get<AnimPatchBank>(pbkPath);
								grp.TextureBanks[texturePath] = pbkPath;
								grp.PatchBanks[pbkPath] = pbk;
							}
						}
					}
				}
			}
		}

		public void ProcessAll(Context context) {
			foreach (var group in AnimationGroups) {
				ProcessAnimationGroup(context, group.Value);
			}
		}

		public void ProcessAnimationGroup(Context context, AnimationGroup group) {
			foreach (var anim in group.Animations) {
				ProcessAnimationTrack(context, group, anim.Value, anim.Key);
			}
			foreach (var pbk in group.PatchBanks) {
				ProcessPatchBank(context, group, pbk.Value);
			}
			ProcessSkeleton(context, group, group.Skeleton);
		}

		public void ProcessPatchBank(Context context, AnimationGroup group, AnimPatchBank pbk) {

			if (pbk.templates != null) {
				foreach (var template in pbk.templates) {
					if (template?.bones != null) {
						var bones = template.bones;
						var bonesDyn = template?.bonesDyn;
						for (int i = 0; i < bones.Count; i++) {
							int parentIndex = -1;
							if (bones[i].parentKey.stringID != 0) {
								AnimBone parent = template.GetBoneFromLink(bones[i].parentKey);
								if (parent != null) {
									parentIndex = bones.IndexOf(parent);
								}
							}
							if (parentIndex != -1) {
								//bonesDyn[i].PositionPreConversion = new Vec2d(bonesDyn[i].position.x, bonesDyn[i].position.y);
								//bonesDyn[i].position.x /= bonesDyn[parentIndex].boneLength;
								//bonesDyn[i].position.x += 1;
								//bonesDyn[i].position.x += bonesDyn[parentIndex].boneLength;
							}
						}
					}
					if (template?.bonesDyn != null) {
						var bones = template.bones;
						for (int i = 0; i < bones.Count; i++) {
							var skelBoneIndex = group.Skeleton.GetBoneIndexFromTag(bones[i].tag);
							var skelBoneDyn = group.Skeleton.bonesDyn[skelBoneIndex];
							var boneDyn = template.bonesDyn[i];

							boneDyn.scale.x *= skelBoneDyn.boneLength;
							//boneDyn.scale.y *= (skelBoneDyn.boneLength / boneDyn.boneLength);
							//boneDyn.scale.x *= boneDyn.boneLength;
							//boneDyn.scale.y *= skelBoneDyn.boneLength / boneDyn.boneLength;// skeleton.bonesDyn[boneIndex].boneLength / atl.bonesDyn[i].boneLength
							//boneDyn

							//boneDyn.scale.x *= boneDyn.boneLength;



							//boneDyn.boneLength = 1f;


							// bindscale:
							//atl.bonesDyn[i].scale.GetUnityVector() / skeleton.bonesDyn[boneIndex].scale.GetUnityVector();
							// but this becomes:
							//(skeleton/atl) * atl.scale / (skeleton * skeleton.scale)
						}
					}
				}
			}
		}

		public void ProcessSkeleton(Context context, AnimationGroup group, AnimSkeleton skeleton) {
			for (int i = 0; i < skeleton.bones.Count; i++) {
				int parentIndex = -1;
				if (skeleton.bones[i].parentKey.stringID != 0) {
					AnimBone parent = skeleton.GetBoneFromLink(skeleton.bones[i].parentKey);
					parentIndex = skeleton.bones.IndexOf(parent);
				}
				if (parentIndex != -1) {
					//bonesDyn[i].position.x += bonesDyn[parentIndex].boneLength;
					//skeleton.bonesDyn[i].PositionPreConversion = new Vec2d(skeleton.bonesDyn[i].position.x, skeleton.bonesDyn[i].position.y);
					skeleton.bonesDyn[i].position.x /= skeleton.bonesDyn[parentIndex].boneLength; // Divide by bonelength (xscale multiplier)
					skeleton.bonesDyn[i].position.x += 1; // Add bonelength, divided by bonelength (xscale multiplier) = 1
				}
			}
			if (skeleton.bonesDyn != null) {
				foreach (var boneDyn in skeleton.bonesDyn) {
					boneDyn.scale.x *= boneDyn.boneLength;
					//boneDyn.boneLength = 1f;
				}
			}
		}

		public void ProcessAnimationTrack(Context context, AnimationGroup group, AnimTrack track, Path animPath) {
			bool checkPBK = true;

			var skel = group.Skeleton;
			if (skel != null) {
				var addBones = skel.bones.Count - track.bonesLists.Count;
				if (addBones > 0) {
					for (int i = 0; i < addBones; i++) {
						track.bonesLists.Add(new AnimTrackBonesList() {
							startPAS = (ushort)track.bonePAS.Count,
							startZAL = (ushort)track.boneZAL.Count,
							amountZAL = 0,
							amountPAS = 0
						});
					}
				}
				foreach (var b in track.bonesLists) {
					if (b.amountPAS == 0) {
						// Make one PAS entry
						b.startPAS = (ushort)track.bonePAS.Count;
						b.amountPAS = 1;
						track.bonePAS.Add(new AnimTrackBonePAS() {
							Scale = Vec2d.One / track.multiplierS,
						});
					}
				}

				// We're converting the animation positions to accommodate for the lack of "boneLength" in Legends and up
				var positions = track.bonePAS.Select(pas => pas.Position * track.multiplierP).ToArray();
				var scales = track.bonePAS.Select(pas => pas.Scale * track.multiplierS).ToArray();
				for (int b = 0; b < track.bonesLists.Count; b++) {
					var skelBoneDyn = skel.bonesDyn[b];
					AnimBoneDyn skelParentBoneDyn = null;

					int parentIndex = -1;
					if (skel.bones[b].parentKey.stringID != 0) {
						AnimBone parent = skel.GetBoneFromLink(skel.bones[b].parentKey);
						parentIndex = skel.bones.IndexOf(parent);
					}
					if (parentIndex != -1) skelParentBoneDyn = skel.bonesDyn[parentIndex];

					var bone = track.bonesLists[b];
					bool hasPAS = bone.amountPAS > 0;

					if (hasPAS) {
						// We assume nothing else is using the same PAS... correct if there are any bugs
						for (int i = bone.startPAS; i < bone.startPAS + bone.amountPAS; i++) {
							AnimBoneDyn parentBoneDyn = null;
							AnimBoneDyn boneDyn = null;
							if (checkPBK) {
								// We check which BML is used for this PAS
								var frame = track.bonePAS[i].frame;
								var currentBML = track.bml.LastOrDefault(bm => bm.frame <= frame);
								if (currentBML != null) {
									foreach (var entry in currentBML.entries) {
										var texPathToUse = track.texturePaths?.FirstOrDefault(t => t.Item1 == entry.textureBankId)?.Item2;
										var bankPath = group.TextureBanks[texPathToUse];
										var bank = group.PatchBanks[bankPath];
										AnimPatchBank pbk = group.PatchBanks[bankPath];

										if (pbk != null) {
											int templateIndex = pbk.templateKeys.GetKeyIndex(entry.templateId);
											templateIndex = pbk.templateKeys.values[templateIndex];
											var template = pbk.templates[templateIndex];
											var bonePBK = template.bones.FirstOrDefault(bone => skel.GetBoneIndexFromTag(bone.tag) == b);
											if (skelParentBoneDyn != null) {
												var parentBonePBK = template.bones.FirstOrDefault(bone => skel.GetBoneIndexFromTag(bone.tag) == parentIndex);
												if (parentBonePBK != null) {
													parentBoneDyn = template.bonesDyn[template.bones.IndexOf(parentBonePBK)];
												}
											}
											if (bonePBK != null) {
												boneDyn = template.bonesDyn[template.bones.IndexOf(bonePBK)];
											}
										}
									}
								}
							}
							if (parentBoneDyn == null) parentBoneDyn = skelParentBoneDyn;
							if (boneDyn == null) boneDyn = skelBoneDyn;

							if (parentBoneDyn != null) {
								//positions[i].x *= (parentBoneDyn.boneLength + 1);
								//positions[i].x /= parentBoneDyn.boneLength;
								//positions[i].x /= parentBoneDyn.boneLength;
								positions[i].x /= skelParentBoneDyn.boneLength;

								// Correct positions here using difference between boneLength in template & skeleton
								if (parentBoneDyn != skelParentBoneDyn) {
									var blSkel = skelParentBoneDyn.boneLength;
									var blTpl = parentBoneDyn.boneLength;
									if (blTpl != blSkel) {
										var posSkel = skelBoneDyn.position;
										var bindPosSkel = posSkel.x / blSkel;
										var tplPosSkel = posSkel.x / blTpl;

										context.SystemLogger.LogInfo($"{animPath.filename}: BoneLength Difference: {b}: {blTpl - blSkel}");

										//positions[i].x += (blTpl - blSkel) / blSkel; // Correct before scale conversion

										// To add: ((bindPosition + localPosition) * (1/TPL_BL - 1/SKEL_BL))
										//positions[i].x += (posSkel.x + positions[i].x) * (1 / blTpl - 1 / blSkel);

										positions[i].x += (posSkel.x /*+ positions[i].x*/) * (1 / blTpl - 1 / blSkel);

										/*positions[i].x *= blTpl / blSkel;
										positions[i].x += (posSkel.x * blTpl / blSkel) - posSkel.x;
										positions[i].x += (blTpl / blSkel) - 1;*/
									}
								}
							}
							if (boneDyn != skelBoneDyn) {
								var blSkel = skelBoneDyn.boneLength;
								var blTpl = boneDyn.boneLength;
								scales[i].x *= blTpl / blSkel;
								//scales[i].x *= blTpl / blSkel;
							}
						}
					}
				}
				// Positions are modified, put them back in
				var positionMultiplier = positions.Max(p => MathF.Max(MathF.Abs(p.x), MathF.Abs(p.y)));
				var scaleMultiplier = scales.Max(p => MathF.Max(MathF.Abs(p.x), MathF.Abs(p.y)));
				var oldMultiplierP = track.multiplierP;
				var oldMultiplierS = track.multiplierS;
				track.multiplierP = positionMultiplier;
				track.multiplierS = scaleMultiplier;
				positions = positions.Select(p => p / positionMultiplier).ToArray();
				scales = scales.Select(p => p / scaleMultiplier).ToArray();
				for (int i = 0; i < track.bonePAS.Count; i++) {
					//UnityEngine.Debug.Log($"New: {positions[i] * multiplierP} - Old: {bonePAS[i].Position * oldMultiplierP}");
					track.bonePAS[i].Position = positions[i];
					track.bonePAS[i].Scale = scales[i];
				}
			}
		}
	}
}
