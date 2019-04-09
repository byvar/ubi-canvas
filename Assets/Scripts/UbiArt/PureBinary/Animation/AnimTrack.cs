using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrack::serialize
	// anm.ckd file
	public class AnimTrack : ICSerializable {
		public uint version;
		public float unk;
		public CList<AnimTrackBML> bml;
		public CList<AnimBonePAS> bonePAS;
		public CList<uint> unks;
		public CList<AnimBonePAS> bonePAS2;
		public CList<AnimBoneZAL> boneZAL;
		public float flt0;
		public float flt1;
		public float flt2;
		public CList<AnimTrackPolyline> polylines;
		public CList<AnimTrackBonesList> bonesLists;
		public CList<AnimTrackFrameEvents> frameEvents;
		public CList<AnimTrackFrameSoundEvents> soundEvents;
		public CList<Vector2> vectors;
		public Vector2 vec0;
		public Vector2 vec1;
		public Vector2 vec2;
		public Vector2 vec3;
		public TexturePath skeletonPath;
		public CList<TexturePath> texturePaths;
		public uint unk0;
		public uint unk1;
		public uint unk2;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref version);
			s.Serialize(ref unk);
			s.Serialize(ref bml);
			s.Serialize(ref bonePAS);
			if (Settings.s.game == Settings.Game.RA) {
				s.Serialize(ref unks);
				if (unks.Count == 0) {
					s.Serialize(ref bonePAS2);
				}
			}
			s.Serialize(ref boneZAL);
			s.Serialize(ref flt0);
			s.Serialize(ref flt1);
			s.Serialize(ref flt2);
			s.Serialize(ref polylines);
			s.Serialize(ref bonesLists);
			s.Serialize(ref frameEvents);
			s.Serialize(ref soundEvents);
			s.Serialize(ref vectors);
			s.Serialize(ref vec0);
			s.Serialize(ref vec1);
			s.Serialize(ref vec2);
			s.Serialize(ref vec3);
			s.Serialize(ref skeletonPath);
			s.Serialize(ref texturePaths);
			s.Serialize(ref unk0);
			if (Settings.s.game == Settings.Game.RL) {
				s.Serialize(ref unk2);
			}
			s.Serialize(ref unk1);
		}

		public class TexturePath : ICSerializable {
			public StringID sid;
			public Path path;

			public void Serialize(CSerializerObject s, string name) {
				s.Serialize(ref sid);
				s.Serialize(ref path);
			}
		}
	}
}
