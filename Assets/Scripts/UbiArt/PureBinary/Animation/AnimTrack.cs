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
		public CList<AnimTrackBML> bml;
		public CList<AnimTrackBonePAS> bonePAS;
		public CList<AnimTrackBoneZAL> boneZAL;
		public float multiplierA;
		public float multiplierP;
		public float multiplierS;
		public CList<AnimTrackPolyline> polylines;
		public CList<AnimTrackBonesList> bonesLists;
		public CList<AnimTrackFrameEvents> frameEvents;
		public CList<AnimTrackFrameSoundEvents> soundEvents;
		public CList<Vec2d> vectors;
		public Vec2d vec0;
		public Vec2d vec1;
		public Vec2d vec2;
		public Vec2d vec3;
		public Pair<StringID, Path> skeleton;
		public Pair<StringID, CString> skeletonOrigins;
		public KeyArray<int> texturePathKeysOrigins;
		public CList<Pair<StringID, Path>> texturePaths;
		public CList<Pair<StringID, CString>> texturePathsOrigins;
		public uint unk0;
		public uint unk1;
		public uint unk2;
		public ulong unk0Origins;
		public CList<ulong> unk1Origins;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");
			length = s.Serialize<float>(length, name: "length");
			bml = s.SerializeObject<CList<AnimTrackBML>>(bml, name: "bml");
			bonePAS = s.SerializeObject<CList<AnimTrackBonePAS>>(bonePAS, name: "bonePAS");
			boneZAL = s.SerializeObject<CList<AnimTrackBoneZAL>>(boneZAL, name: "boneZAL");
			multiplierA = s.Serialize<float>(multiplierA, name: "multiplierA");
			multiplierP = s.Serialize<float>(multiplierP, name: "multiplierP");
			multiplierS = s.Serialize<float>(multiplierS, name: "multiplierS");
			polylines = s.SerializeObject<CList<AnimTrackPolyline>>(polylines, name: "polylines");
			bonesLists = s.SerializeObject<CList<AnimTrackBonesList>>(bonesLists, name: "bonesLists");
			frameEvents = s.SerializeObject<CList<AnimTrackFrameEvents>>(frameEvents, name: "frameEvents");
			soundEvents = s.SerializeObject<CList<AnimTrackFrameSoundEvents>>(soundEvents, name: "soundEvents");
			vectors = s.SerializeObject<CList<Vec2d>>(vectors, name: "vectors");
			vec0 = s.SerializeObject<Vec2d>(vec0, name: "vec0");
			vec1 = s.SerializeObject<Vec2d>(vec1, name: "vec1");
			vec2 = s.SerializeObject<Vec2d>(vec2, name: "vec2");
			vec3 = s.SerializeObject<Vec2d>(vec3, name: "vec3");
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				skeleton = s.SerializeObject<Pair<StringID, Path>>(skeleton, name: "skeleton");
				texturePaths = s.SerializeObject<CList<Pair<StringID, Path>>>(texturePaths, name: "texturePaths");
				unk0 = s.Serialize<uint>(unk0, name: "unk0");
				if (Settings.s.game == Settings.Game.RL) {
					unk1 = s.Serialize<uint>(unk1, name: "unk1");
				}
				unk2 = s.Serialize<uint>(unk2, name: "unk2");
			} else {
				skeletonOrigins = s.SerializeObject<Pair<StringID, CString>>(skeletonOrigins, name: "skeletonOrigins");
				texturePathKeysOrigins = s.SerializeObject<KeyArray<int>>(texturePathKeysOrigins, name: "texturePathKeysOrigins");
				texturePathsOrigins = s.SerializeObject<CList<Pair<StringID, CString>>>(texturePathsOrigins, name: "texturePathsOrigins");
				unk0Origins = s.Serialize<ulong>(unk0Origins, name: "unk0Origins");
				unk1Origins = s.SerializeObject<CList<ulong>>(unk1Origins, name: "unk1Origins");
				unk2 = s.Serialize<uint>(unk2, name: "unk2");
			}
		}

		public AnimSkeleton skel;
		public TextureCooked[] texs;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				if (skeleton != null && skeleton.Item2 != null && isFirstLoad) {
					MapLoader l = MapLoader.Loader;
					l.Load(skeleton.Item2, (extS) => {
						if (l.skl.ContainsKey(skeleton.Item2.stringID)) {
							skel = l.skl[skeleton.Item2.stringID];
						} else {
							extS.log = l.logEnabled;
							extS.Serialize(ref skel);
							l.skl[skeleton.Item2.stringID] = skel;
							l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
						}
					});
				}
				if (texturePaths != null) {
					texs = new TextureCooked[texturePaths.Count];
					for (int i = 0; i < texturePaths.Count; i++) {
						LoadTexture(i, texturePaths[i].Item2);
					}
				}
			} else {
				if (skeletonOrigins != null && skeletonOrigins.Item2 != null && isFirstLoad) {
					MapLoader l = MapLoader.Loader;
					l.Load(skeletonOrigins.Item2, (extS) => {
						Path p = new Path(skeletonOrigins.Item2.str);
						if (l.skl.ContainsKey(p.stringID)) {
							skel = l.skl[p.stringID];
						} else {
							extS.log = l.logEnabled;
							extS.Serialize(ref skel);
							l.skl[p.stringID] = skel;
							l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
						}
					});
				}
				if (texturePathsOrigins != null) {
					texs = new TextureCooked[texturePathsOrigins.Count];
					for (int i = 0; i < texturePathsOrigins.Count; i++) {
						LoadTexture(i, new Path(texturePathsOrigins[i].Item2.str));
					}
				}
			}
		}

		protected void LoadTexture(int index, Path path) {
			MapLoader l = MapLoader.Loader;
			l.Load(path, (extS) => {
				if (l.tex.ContainsKey(path.stringID)) {
					texs[index] = l.tex[path.stringID];
				} else {
					extS.Serialize(ref texs[index]);
					TextureCooked tex = texs[index];
					tex.atlas = l.uvAtlasManager.GetAtlasIfExists(path);
					l.tex[path.stringID] = tex;
					l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
				}
			});
		}

	}
}
