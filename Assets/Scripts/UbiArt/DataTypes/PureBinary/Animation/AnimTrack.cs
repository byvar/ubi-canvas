using System;
using System.Linq;
using UbiArt.ITF;

namespace UbiArt.Animation {
	// See: ITF::AnimTrack::serialize
	// anm.ckd file
	public class AnimTrack : CSerializable {
		public const uint VersionLegends = 34;

		public uint version;
		public float length;
		public CListO<AnimTrackBML> bml;
		public CListO<AnimTrackBonePAS> bonePAS;
		public CListO<AnimTrackBoneZAL> boneZAL;
		public float multiplierA;
		public float multiplierP;
		public float multiplierS;
		public CListO<AnimTrackPolyline> polylines;
		public CListO<AnimTrackBonesList> bonesLists;
		public CListO<AnimTrackFrameEvents> frameEvents;
		public CListO<AnimTrackFrameSoundEvents> soundEvents;
		public CListO<Vec2d> vectors;
		public AABB LocalAABB;
		public AABB WorldAABB = new AABB() { MIN = Vec2d.Infinity, MAX = Vec2d.MinusInfinity };
		public pair<StringID, Path> skeleton;
		public pair<StringID, CString> skeletonOrigins;
		public KeyArray<int> texturePathKeysOrigins;
		public CListO<pair<StringID, Path>> texturePaths;
		public CListO<pair<StringID, CString>> texturePathsOrigins;
		public uint bankId0;
		public uint bankId;
		public uint unk2;
		public CListP<ulong> unk1Origins;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");
			length = s.Serialize<float>(length, name: "length");
			bml = s.SerializeObject<CListO<AnimTrackBML>>(bml, name: "BML");
			bonePAS = s.SerializeObject<CListO<AnimTrackBonePAS>>(bonePAS, name: "PAS");
			boneZAL = s.SerializeObject<CListO<AnimTrackBoneZAL>>(boneZAL, name: "ZAL");
			multiplierA = s.Serialize<float>(multiplierA, name: "multiplierA");
			multiplierP = s.Serialize<float>(multiplierP, name: "multiplierP");
			multiplierS = s.Serialize<float>(multiplierS, name: "multiplierS");
			polylines = s.SerializeObject<CListO<AnimTrackPolyline>>(polylines, name: "polylines");
			bonesLists = s.SerializeObject<CListO<AnimTrackBonesList>>(bonesLists, name: "bones");
			frameEvents = s.SerializeObject<CListO<AnimTrackFrameEvents>>(frameEvents, name: "frameEvents");
			soundEvents = s.SerializeObject<CListO<AnimTrackFrameSoundEvents>>(soundEvents, name: "soundEvents");
			vectors = s.SerializeObject<CListO<Vec2d>>(vectors, name: "vectors");
			LocalAABB = s.SerializeObject<AABB>(LocalAABB, name: "LocalAABB");
			WorldAABB = s.SerializeObject<AABB>(WorldAABB, name: "WorldAABB");
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				skeleton = s.SerializeObject<pair<StringID, Path>>(skeleton, name: "skeleton");
				texturePaths = s.SerializeObject<CListO<pair<StringID, Path>>>(texturePaths, name: "textures");
				if (s.Settings.Game == Game.RL) {
					bankId0 = s.Serialize<uint>(bankId0, name: "bankId0");
				}
				bankId = s.Serialize<uint>(bankId, name: "bankId");
				unk2 = s.Serialize<uint>(unk2, name: "unk2");
			} else {
				skeletonOrigins = s.SerializeObject<pair<StringID, CString>>(skeletonOrigins, name: "skeleton");
				texturePathKeysOrigins = s.SerializeObject<KeyArray<int>>(texturePathKeysOrigins, name: "texturePathKeys");
				texturePathsOrigins = s.SerializeObject<CListO<pair<StringID, CString>>>(texturePathsOrigins, name: "textures");
				bankId0 = s.Serialize<uint>(bankId0, name: "bankId0");
				bankId = s.Serialize<uint>(bankId, name: "bankId");
				unk1Origins = s.SerializeObject<CListP<ulong>>(unk1Origins, name: "unk1");
				unk2 = s.Serialize<uint>(unk2, name: "unk2");
			}
		}

		public AnimSkeleton skel;
		public TextureCooked[] texs;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			Loader l = s.Context.Loader;
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				if (skeleton != null && skeleton.Item2 != null && IsFirstLoad) {
					l.LoadFile<AnimSkeleton>(skeleton.Item2, result => skel = result);
				}
				if (texturePaths != null) {
					texs = new TextureCooked[texturePaths.Count];
					for (int i = 0; i < texturePaths.Count; i++) {
						LoadTexture(l, i, texturePaths[i].Item2);
					}
				}
			} else {
				if (skeletonOrigins != null && skeletonOrigins.Item2 != null && IsFirstLoad) {
					l.LoadFile<AnimSkeleton>(new Path(skeletonOrigins.Item2.str), result => skel = result);
				}
				if (texturePathsOrigins != null) {
					texs = new TextureCooked[texturePathsOrigins.Count];
					for (int i = 0; i < texturePathsOrigins.Count; i++) {
						LoadTexture(l, i, new Path(texturePathsOrigins[i].Item2.str));
					}
				}
			}
		}

		protected void LoadTexture(Loader l, int index, Path path) {
			l.LoadTexture(path, tex => {
				texs[index] = tex;
			});
		}
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			if (s.Context.HasSettings<ConversionSettings>()) {
				var conv = s.Context.GetSettings<ConversionSettings>();
				if (conv.OldSettings.EngineVersion <= EngineVersion.RO && s.Settings.EngineVersion > EngineVersion.RO) {
					version = VersionLegends;

					// Convert to Legends
					if (skeletonOrigins != null) {
						skeleton = new pair<StringID, Path>(skeletonOrigins.Item1, new Path(skeletonOrigins.Item2));
					}
					if (texturePathsOrigins != null) {
						texturePaths = new CListO<pair<StringID, Path>>();
						for(int i = 0; i < texturePathKeysOrigins.keysLegends.Count; i++) {
							var pathIndex = texturePathKeysOrigins.values[i];
							var path = new Path(texturePathsOrigins[pathIndex].Item2);
							texturePaths.Add(new pair<StringID, Path>(texturePathKeysOrigins.keysLegends[i], path));
						}
					}
					ConvertOriginsPositionsToLegends(s);
				}
			}
			Reinit(s.Settings);
		}
		public void Reinit(Settings settings) {
			if (settings.Game == Game.RL && version >= VersionLegends) {
				version = VersionLegends;
			}
		}

		public void ConvertOriginsPositionsToLegends(CSerializerObject s) {

			var conv = s.Context.GetSettings<ConversionSettings>();
			var contextToUse = conv.OldContext ?? s.Context;

			bool checkPBK = true;

			var skeletonPath = skeleton.Item2;
			var texturePath = texturePaths?.FirstOrDefault()?.Item2;

			var skel = contextToUse.Cache.Get<AnimSkeleton>(skeletonPath);
			if (skel != null) {
				var addBones = skel.bones.Count - bonesLists.Count;
				if (addBones > 0) {
					for (int i = 0; i < addBones; i++) {
						bonesLists.Add(new AnimTrackBonesList() {
							startPAS = (ushort)bonePAS.Count,
							startZAL = (ushort)boneZAL.Count,
							amountZAL = 0,
							amountPAS = 0
						});
					}
				}
				foreach (var b in bonesLists) {
					if (b.amountPAS == 0) {
						// Make one PAS entry
						b.startPAS = (ushort)bonePAS.Count;
						b.amountPAS = 1;
						bonePAS.Add(new AnimTrackBonePAS() {
							Scale = Vec2d.One / multiplierS,
						});
					}
				}
				
				// We're converting the animation positions to accommodate for the lack of "boneLength" in Legends and up
				var positions = bonePAS.Select(pas => pas.Position * multiplierP).ToArray();
				var scales = bonePAS.Select(pas => pas.Scale * multiplierS).ToArray();
				for (int b = 0; b < bonesLists.Count; b++) {
					var skelBoneDyn = skel.bonesDyn[b];
					AnimBoneDyn skelParentBoneDyn = null;

					int parentIndex = -1;
					if (skel.bones[b].parentKey.stringID != 0) {
						AnimBone parent = skel.GetBoneFromLink(skel.bones[b].parentKey);
						parentIndex = skel.bones.IndexOf(parent);
					}
					if (parentIndex != -1) skelParentBoneDyn = skel.bonesDyn[parentIndex];

					var bone = bonesLists[b];
					bool hasPAS = bone.amountPAS > 0;

					if (hasPAS) {
						// We assume nothing else is using the same PAS... correct if there are any bugs
						for (int i = bone.startPAS; i < bone.startPAS + bone.amountPAS; i++) {
							AnimBoneDyn parentBoneDyn = null;
							AnimBoneDyn boneDyn = null; 
							if (checkPBK) {
								// We check which BML is used for this PAS
								var frame = bonePAS[i].frame;
								var currentBML = bml.LastOrDefault(bm => bm.frame <= frame);
								if (currentBML != null) {
									foreach (var entry in currentBML.entries) {
										var texPathToUse = texturePaths?.FirstOrDefault(t => t.Item1 == entry.textureBankId)?.Item2;
										AnimPatchBank pbk = null;
										if (texturePath != null) {
											var pbkPath = new Path($"{texturePath.GetFilenameWithoutExtension(fullPath: true)}.pbk");
											pbk = contextToUse.Cache.Get<AnimPatchBank>(pbkPath);
										}
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
										var posSkel = skelBoneDyn.PositionPreConversion ?? skelBoneDyn.position;
										var bindPosSkel = posSkel.x / blSkel;
										var tplPosSkel = posSkel.x / blTpl;

										var animSID = contextToUse.Cache.Structs[typeof(AnimTrack)].FirstOrDefault(a => a.Value == this);
										var animPath = contextToUse.Loader.Paths[animSID.Key].filename;
										s.Context.SystemLogger.LogInfo($"{animPath}: BoneLength Difference: {b}: {blTpl - blSkel}");
										
										//positions[i].x += (blTpl - blSkel) / blSkel; // Correct before scale conversion

										// To add: ((bindPosition + localPosition) * (1/TPL_BL - 1/SKEL_BL))
										positions[i].x += (posSkel.x + positions[i].x) * (1/blTpl - 1/blSkel);
									}
								}
							}
							if (boneDyn != skelBoneDyn) {
								var blSkel = skelBoneDyn.boneLength;
								var blTpl = boneDyn.boneLength;
								scales[i].x *= blTpl / blSkel;
							}
						}
					}
				}
				// Positions are modified, put them back in
				var positionMultiplier = positions.Max(p => MathF.Max(MathF.Abs(p.x), MathF.Abs(p.y)));
				var scaleMultiplier = scales.Max(p => MathF.Max(MathF.Abs(p.x), MathF.Abs(p.y)));
				var oldMultiplierP = multiplierP;
				var oldMultiplierS = multiplierS;
				multiplierP = positionMultiplier;
				multiplierS = scaleMultiplier;
				positions = positions.Select(p => p / positionMultiplier).ToArray();
				scales = scales.Select(p => p / scaleMultiplier).ToArray();
				for (int i = 0; i < bonePAS.Count; i++) {
					//UnityEngine.Debug.Log($"New: {positions[i] * multiplierP} - Old: {bonePAS[i].Position * oldMultiplierP}");
					bonePAS[i].Position = positions[i];
					bonePAS[i].Scale = scales[i];
				}
			}
		}

	}
}
