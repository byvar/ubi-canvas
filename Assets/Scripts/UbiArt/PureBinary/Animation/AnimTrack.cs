using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrack::serialize
	// anm.ckd file
	public class AnimTrack : CSerializable {
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
		public Vec2d vec0;
		public Vec2d vec1;
		public Vec2d vec2;
		public Vec2d vec3;
		public Pair<StringID, Path> skeleton;
		public Pair<StringID, CString> skeletonOrigins;
		public KeyArray<int> texturePathKeysOrigins;
		public CListO<Pair<StringID, Path>> texturePaths;
		public CListO<Pair<StringID, CString>> texturePathsOrigins;
		public uint unk0;
		public uint unk1;
		public uint unk2;
		public ulong unk0Origins;
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
			vec0 = s.SerializeObject<Vec2d>(vec0, name: "vec0");
			vec1 = s.SerializeObject<Vec2d>(vec1, name: "vec1");
			vec2 = s.SerializeObject<Vec2d>(vec2, name: "vec2");
			vec3 = s.SerializeObject<Vec2d>(vec3, name: "vec3");
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				skeleton = s.SerializeObject<Pair<StringID, Path>>(skeleton, name: "skeleton");
				texturePaths = s.SerializeObject<CListO<Pair<StringID, Path>>>(texturePaths, name: "textures");
				unk0 = s.Serialize<uint>(unk0, name: "unk0");
				if (s.Settings.game == Settings.Game.RL) {
					unk1 = s.Serialize<uint>(unk1, name: "unk1");
				}
				unk2 = s.Serialize<uint>(unk2, name: "unk2");
			} else {
				skeletonOrigins = s.SerializeObject<Pair<StringID, CString>>(skeletonOrigins, name: "skeleton");
				texturePathKeysOrigins = s.SerializeObject<KeyArray<int>>(texturePathKeysOrigins, name: "texturePathKeys");
				texturePathsOrigins = s.SerializeObject<CListO<Pair<StringID, CString>>>(texturePathsOrigins, name: "textures");
				unk0Origins = s.Serialize<ulong>(unk0Origins, name: "unk0");
				unk1Origins = s.SerializeObject<CListP<ulong>>(unk1Origins, name: "unk1");
				unk2 = s.Serialize<uint>(unk2, name: "unk2");
			}
		}

		public AnimSkeleton skel;
		public TextureCooked[] texs;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			Context c = s.Context;
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				if (skeleton != null && skeleton.Item2 != null && IsFirstLoad) {
					c.Load(skeleton.Item2, (extS) => {
						if (c.skl.ContainsKey(skeleton.Item2.stringID)) {
							skel = c.skl[skeleton.Item2.stringID];
						} else {
							skel = extS.SerializeObject<AnimSkeleton>(skel);
							c.skl[skeleton.Item2.stringID] = skel;
							c.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
						}
					});
				}
				if (texturePaths != null) {
					texs = new TextureCooked[texturePaths.Count];
					for (int i = 0; i < texturePaths.Count; i++) {
						LoadTexture(c, i, texturePaths[i].Item2);
					}
				}
			} else {
				if (skeletonOrigins != null && skeletonOrigins.Item2 != null && IsFirstLoad) {
					c.Load(skeletonOrigins.Item2, (extS) => {
						Path p = new Path(skeletonOrigins.Item2.str);
						if (c.skl.ContainsKey(p.stringID)) {
							skel = c.skl[p.stringID];
						} else {
							skel = extS.SerializeObject<AnimSkeleton>(skel);
							c.skl[p.stringID] = skel;
							c.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
						}
					});
				}
				if (texturePathsOrigins != null) {
					texs = new TextureCooked[texturePathsOrigins.Count];
					for (int i = 0; i < texturePathsOrigins.Count; i++) {
						LoadTexture(c, i, new Path(texturePathsOrigins[i].Item2.str));
					}
				}
			}
		}

		protected void LoadTexture(Context c, int index, Path path) {
			c.Load(path, (extS) => {
				if (c.tex.ContainsKey(path.stringID)) {
					texs[index] = c.tex[path.stringID];
				} else {
					texs[index] = extS.SerializeObject<TextureCooked>(texs[index]);
					TextureCooked tex = texs[index];
					tex.atlas = c.uvAtlasManager.GetAtlasIfExists(path);
					c.tex[path.stringID] = tex;
					c.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
				}
			});
		}

	}
}
