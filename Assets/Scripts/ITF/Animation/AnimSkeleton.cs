using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF.Animation {
	// See: ITF::AnimSkeleton::serialize
	// skl.ckd file
	public class AnimSkeleton {
		public uint version;
		public Container<StringID> boneTags;
		public Container<StringID> boneIndices;
		public Container<StringID> boneTags2;
		public Container<StringID> boneIndices2;
		public Container<StringID> boneTags3;
		public Container<StringID> boneIndices3;
		public Container<AnimBone> bones;
		public Container<AnimBoneDyn> bonesDyn;

		public AnimSkeleton(Reader reader) {
			version = reader.ReadUInt32();
			boneTags = new Container<StringID>(reader);
			boneIndices = new Container<StringID>(reader);
			boneTags2 = new Container<StringID>(reader);
			boneIndices2 = new Container<StringID>(reader);
			boneTags3 = new Container<StringID>(reader);
			boneIndices3 = new Container<StringID>(reader);
			bones = new Container<AnimBone>(reader);
			bonesDyn = new Container<AnimBoneDyn>(reader);
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
