using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimBoneZAL::serialize
	public class AnimBoneZAL : ICSerializable {
		public ushort unk0;
		public float unk1;
		public short unk2;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref unk0);
			s.Serialize(ref unk1);
			s.Serialize(ref unk2);
		}
	}
}
