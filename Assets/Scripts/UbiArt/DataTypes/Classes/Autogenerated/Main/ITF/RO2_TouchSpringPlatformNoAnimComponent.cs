using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchSpringPlatformNoAnimComponent : RO2_TouchSpringPlatformBaseComponent {
		public float limitRight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				limitRight = s.Serialize<float>(limitRight, name: "limitRight");
			}
		}
		public override uint? ClassCRC => 0x394ED704;
	}
}

