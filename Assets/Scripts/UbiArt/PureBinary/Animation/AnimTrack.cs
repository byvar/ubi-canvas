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
		[Serialize("PAS"        )] public CList<AnimBonePAS> bonePAS;
		[Serialize("unks"       )] public CList<uint> unks;
		[Serialize("PAS2"       )] public CList<AnimBonePAS> bonePAS2;
		[Serialize("ZAL"        )] public CList<AnimBoneZAL> boneZAL;
		[Serialize("flt0"       )] public float flt0;
		[Serialize("flt1"       )] public float flt1;
		[Serialize("flt2"       )] public float flt2;
		[Serialize("polylines"  )] public CList<AnimTrackPolyline> polylines;
		[Serialize("bones"      )] public CList<AnimTrackBonesList> bonesLists;
		[Serialize("frameEvents")] public CList<AnimTrackFrameEvents> frameEvents;
		[Serialize("soundEvents")] public CList<AnimTrackFrameSoundEvents> soundEvents;
		[Serialize("vectors"    )] public CList<Vector2> vectors;
		[Serialize("vec0"       )] public Vector2 vec0;
		[Serialize("vec1"       )] public Vector2 vec1;
		[Serialize("vec2"       )] public Vector2 vec2;
		[Serialize("vec3"       )] public Vector2 vec3;
		[Serialize("skeleton"   )] public Pair<StringID, Path> skeleton;
		[Serialize("textures"   )] public CList<Pair<StringID, Path>> texturePaths;
		[Serialize("unk0"       )] public uint unk0;
		[Serialize("unk1"       )] public uint unk1;
		[Serialize("unk2"       )] public uint unk2;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(length));
			SerializeField(s, nameof(bml));
			SerializeField(s, nameof(bonePAS));
			if (Settings.s.game == Settings.Game.RA) {
				SerializeField(s, nameof(unks));
				if (unks.Count == 0) {
					SerializeField(s, nameof(bonePAS2));
				}
			}
			SerializeField(s, nameof(boneZAL));
			SerializeField(s, nameof(flt0));
			SerializeField(s, nameof(flt1));
			SerializeField(s, nameof(flt2));
			SerializeField(s, nameof(polylines));
			SerializeField(s, nameof(bonesLists));
			SerializeField(s, nameof(frameEvents));
			SerializeField(s, nameof(soundEvents));
			SerializeField(s, nameof(vectors));
			SerializeField(s, nameof(vec0));
			SerializeField(s, nameof(vec1));
			SerializeField(s, nameof(vec2));
			SerializeField(s, nameof(vec3));
			SerializeField(s, nameof(skeleton));
			SerializeField(s, nameof(texturePaths));
			SerializeField(s, nameof(unk0));
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(unk1));
			}
			SerializeField(s, nameof(unk2));
		}

		public AnimSkeleton skel;
		public TextureCooked[] texs;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (skeleton != null && skeleton.Item2 != null && isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(skeleton.Item2, (extS) => {
					if (l.skl.ContainsKey(skeleton.Item2.stringID)) {
						skel = l.skl[skeleton.Item2.stringID];
					} else {
						extS.Serialize(ref skel);
						l.skl[skeleton.Item2.stringID] = skel;
						l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
					}
				});
			}
			if (texturePaths != null) {
				for (int i = 0; i < texturePaths.Count; i++) {
					LoadTexture(i, texturePaths[i].Item2);
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
