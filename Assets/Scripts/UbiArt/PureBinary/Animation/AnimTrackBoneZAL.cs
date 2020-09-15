using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackBoneZAL::serialize
	public class AnimTrackBoneZAL : CSerializable {
		public ushort frame;
		public float z;
		public short alpha;
		public int originsInt;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frame = s.Serialize<ushort>(frame, name: "frame");
			z = s.Serialize<float>(z, name: "z");
			alpha = s.Serialize<short>(alpha, name: "alpha");
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
				originsInt = s.Serialize<int>(originsInt, name: "originsInt");
			}
		}
	}
}
