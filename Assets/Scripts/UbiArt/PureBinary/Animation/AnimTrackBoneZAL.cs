using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackBoneZAL::serialize
	public class AnimTrackBoneZAL : CSerializable {
		[Serialize("frame")] public ushort frame;
		[Serialize("z"    )] public float z;
		[Serialize("alpha")] public short alpha;
		[Serialize("originsInt")] public int originsInt;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(frame));
			SerializeField(s, nameof(z));
			SerializeField(s, nameof(alpha));
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
				SerializeField(s, nameof(originsInt));
			}
		}
	}
}
