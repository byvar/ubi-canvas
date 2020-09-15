using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreatureDetectorComponent_Template : ShapeDetectorComponent_Template {
		public bool ignoreZ;
		public float maxDetectionRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
			maxDetectionRadius = s.Serialize<float>(maxDetectionRadius, name: "maxDetectionRadius");
		}
		public override uint? ClassCRC => 0xA94B3F0F;
	}
}

