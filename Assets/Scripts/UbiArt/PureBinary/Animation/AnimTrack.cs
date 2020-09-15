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
		[Serialize("version"    )] public uint version;
		[Serialize("length"     )] public float length;
		[Serialize("BML"        )] public CList<AnimTrackBML> bml;
		[Serialize("PAS"        )] public CList<AnimTrackBonePAS> bonePAS;
		[Serialize("ZAL"        )] public CList<AnimTrackBoneZAL> boneZAL;
		[Serialize("multiplierA")] public float multiplierA;
		[Serialize("multiplierP")] public float multiplierP;
		[Serialize("multiplierS")] public float multiplierS;
		[Serialize("polylines"  )] public CList<AnimTrackPolyline> polylines;
		[Serialize("bones"      )] public CList<AnimTrackBonesList> bonesLists;
		[Serialize("frameEvents")] public CList<AnimTrackFrameEvents> frameEvents;
		[Serialize("soundEvents")] public CList<AnimTrackFrameSoundEvents> soundEvents;
		[Serialize("vectors"    )] public CList<Vec2d> vectors;
		[Serialize("vec0"       )] public Vec2d vec0;
		[Serialize("vec1"       )] public Vec2d vec1;
		[Serialize("vec2"       )] public Vec2d vec2;
		[Serialize("vec3"       )] public Vec2d vec3;
		[Serialize("skeleton"   )] public Pair<StringID, Path> skeleton;
		[Serialize("skeleton"   )] public Pair<StringID, CString> skeletonOrigins;
		[Serialize("texturePathKeys")] public KeyArray<int> texturePathKeysOrigins;
		[Serialize("textures"   )] public CList<Pair<StringID, Path>> texturePaths;
		[Serialize("textures"   )] public CList<Pair<StringID, CString>> texturePathsOrigins;
		[Serialize("unk0"       )] public uint unk0;
		[Serialize("unk1"       )] public uint unk1;
		[Serialize("unk2"       )] public uint unk2;
		[Serialize("unk0"       )] public ulong unk0Origins;
		[Serialize("unk1"       )] public CList<ulong> unk1Origins;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(length));
			SerializeField(s, nameof(bml));
			SerializeField(s, nameof(bonePAS));
			SerializeField(s, nameof(boneZAL));
			SerializeField(s, nameof(multiplierA));
			SerializeField(s, nameof(multiplierP));
			SerializeField(s, nameof(multiplierS));
			SerializeField(s, nameof(polylines));
			SerializeField(s, nameof(bonesLists));
			SerializeField(s, nameof(frameEvents));
			SerializeField(s, nameof(soundEvents));
			SerializeField(s, nameof(vectors));
			SerializeField(s, nameof(vec0));
			SerializeField(s, nameof(vec1));
			SerializeField(s, nameof(vec2));
			SerializeField(s, nameof(vec3));
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				SerializeField(s, nameof(skeleton));
				SerializeField(s, nameof(texturePaths));
				SerializeField(s, nameof(unk0));
				if (Settings.s.game == Settings.Game.RL) {
					SerializeField(s, nameof(unk1));
				}
				SerializeField(s, nameof(unk2));
			} else {
				SerializeField(s, nameof(skeletonOrigins));
				SerializeField(s, nameof(texturePathKeysOrigins));
				SerializeField(s, nameof(texturePathsOrigins));
				SerializeField(s, nameof(unk0Origins));
				SerializeField(s, nameof(unk1Origins));
				SerializeField(s, nameof(unk2));
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
