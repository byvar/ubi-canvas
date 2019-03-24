using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt.Animation {
	// See: ITF::AnimSkeleton::serialize
	// skl.ckd file
	public class AnimSkeleton : ICSerializable {
		public uint version;
		public CList<StringID> boneTags;
		public CList<StringID> boneIndices;
		public CList<StringID> boneTags2;
		public CList<StringID> boneIndices2;
		public CList<StringID> boneTags3;
		public CList<StringID> boneIndices3;
		public CList<AnimBone> bones;
		public CList<AnimBoneDyn> bonesDyn;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref version);
			s.Serialize(ref boneTags);
			s.Serialize(ref boneIndices);
			s.Serialize(ref boneTags2);
			s.Serialize(ref boneIndices2);
			s.Serialize(ref boneTags3);
			s.Serialize(ref boneIndices3);
			s.Serialize(ref bones);
			s.Serialize(ref bonesDyn);
			throw new Exception(s.Position + " - Reading Skeleton. Code Incomplete!");
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
