using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.Animation {
	// See: ITF::AnimBoneZAL::serialize
	public class AnimBoneZAL {
		public ushort unk0;
		public float unk1;
		public short unk2;

		public AnimBoneZAL(Reader reader) {
			unk0 = reader.ReadUInt16();
			unk1 = reader.ReadSingle();
			unk2 = reader.ReadInt16();
		}
	}
}
