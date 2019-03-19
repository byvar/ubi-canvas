using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchSpringPlatformNoAnimComponent : RO2_TouchSpringPlatformBaseComponent {
		[Serialize("limitRight")] public float limitRight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(limitRight));
			}
		}
		public override uint? ClassCRC => 0x394ED704;
	}
}

