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
		[Serialize("z"    )] public float z;
		[Serialize("alpha")] public short alpha;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(frame));
			SerializeField(s, nameof(z));
			SerializeField(s, nameof(alpha));
		}
	}
}
