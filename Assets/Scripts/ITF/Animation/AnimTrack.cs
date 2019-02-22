using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.Animation {
	// See: ITF::AnimTrack::serialize
	// anm.ckd file
	public class AnimTrack {
		public uint version;
		public float unk;
		public Container<AnimTrackBML> bml;
		public Container<AnimBonePAS> bonePAS;
		public Container<uint> unks;
		public Container<AnimBonePAS> bonePAS2;
		public Container<AnimBoneZAL> boneZAL;
		public float flt0;
		public float flt1;
		public float flt2;
		public Container<AnimTrackPolyline> polylines;
		public Container<AnimTrackBonesList> bonesLists;
		public Container<AnimTrackFrameEvents> frameEvents;
		public Container<AnimTrackFrameSoundEvents> soundEvents;
		public Container<Vector2> vectors;
		public Vector2 vec0;
		public Vector2 vec1;
		public Vector2 vec2;
		public Vector2 vec3;
		public TexturePath skeletonPath;
		public Container<TexturePath> texturePaths;
		public uint unk0;
		public uint unk1;

		public AnimTrack(Reader reader) {
			version = reader.ReadUInt32();
			unk = reader.ReadSingle();
			bml = new Container<AnimTrackBML>(reader);
			bonePAS = new Container<AnimBonePAS>(reader);
			unks = new Container<uint>(reader);
			if (unks.Count == 0) {
				bonePAS2 = new Container<AnimBonePAS>(reader);
			}
			boneZAL = new Container<AnimBoneZAL>(reader);
			flt0 = reader.ReadSingle();
			flt1 = reader.ReadSingle();
			flt2 = reader.ReadSingle();
			polylines = new Container<AnimTrackPolyline>(reader);
			bonesLists = new Container<AnimTrackBonesList>(reader);
			frameEvents = new Container<AnimTrackFrameEvents>(reader);
			soundEvents = new Container<AnimTrackFrameSoundEvents>(reader);
			vectors = new Container<Vector2>(reader);
			vec0 = reader.ReadVector2();
			vec1 = reader.ReadVector2();
			vec2 = reader.ReadVector2();
			vec3 = reader.ReadVector2();
			skeletonPath = new TexturePath(reader);
			texturePaths = new Container<TexturePath>(reader);
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
