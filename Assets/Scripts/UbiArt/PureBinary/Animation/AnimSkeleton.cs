using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt.Animation {
	// See: ITF::AnimSkeleton::serialize
	// skl.ckd file
	public class AnimSkeleton {
		public uint version;
		public CList<StringID> boneTags;
		public CList<StringID> boneIndices;
		public CList<StringID> boneTags2;
		public CList<StringID> boneIndices2;
		public CList<StringID> boneTags3;
		public CList<StringID> boneIndices3;
		public CList<AnimBone> bones;
		public CList<AnimBoneDyn> bonesDyn;

		public AnimSkeleton(Reader reader) {
			version = reader.ReadUInt32();
			boneTags = new CList<StringID>(reader);
			boneIndices = new CList<StringID>(reader);
			boneTags2 = new CList<StringID>(reader);
			boneIndices2 = new CList<StringID>(reader);
			boneTags3 = new CList<StringID>(reader);
			boneIndices3 = new CList<StringID>(reader);
			bones = new CList<AnimBone>(reader);
			bonesDyn = new CList<AnimBoneDyn>(reader);
			/*
			Example of what comes after this:
			00000000
			01CE8C67
			F77E1A0C
			00000001
			00000000
			00000000
			00000000
			*/
		}
	}
}
