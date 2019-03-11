using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrack::serialize
	// anm.ckd file
	public class AnimTrack {
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

		public AnimTrack(Reader reader) {
			version = reader.ReadUInt32();
			unk = reader.ReadSingle();
			bml = new CList<AnimTrackBML>(reader);
			bonePAS = new CList<AnimBonePAS>(reader);
			unks = new CList<uint>(reader);
			if (unks.Count == 0) {
				bonePAS2 = new CList<AnimBonePAS>(reader);
			}
			boneZAL = new CList<AnimBoneZAL>(reader);
			flt0 = reader.ReadSingle();
			flt1 = reader.ReadSingle();
			flt2 = reader.ReadSingle();
			polylines = new CList<AnimTrackPolyline>(reader);
			bonesLists = new CList<AnimTrackBonesList>(reader);
			frameEvents = new CList<AnimTrackFrameEvents>(reader);
			soundEvents = new CList<AnimTrackFrameSoundEvents>(reader);
			vectors = new CList<Vector2>(reader);
			vec0 = reader.ReadVector2();
			vec1 = reader.ReadVector2();
			vec2 = reader.ReadVector2();
			vec3 = reader.ReadVector2();
			skeletonPath = new TexturePath(reader);
			texturePaths = new CList<TexturePath>(reader);
			unk0 = reader.ReadUInt32();
			unk1 = reader.ReadUInt32();
		}

		public class TexturePath {
			public StringID sid;
			public Path path;
			public TexturePath(Reader reader) {
				sid = new StringID(reader);
				path = new Path(reader);
			}
		}
	}
}
