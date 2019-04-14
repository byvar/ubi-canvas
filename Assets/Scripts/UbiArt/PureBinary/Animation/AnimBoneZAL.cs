using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimBoneZAL::serialize
	public class AnimBoneZAL : CSerializable {
		[Serialize("frame")] public ushort frame;
		[Serialize("unk1")] public float unk1;
		[Serialize("unk2")] public short unk2;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(frame));
			SerializeField(s, nameof(unk1));
			SerializeField(s, nameof(unk2));
		}
	}
}
