using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_PagePortalComponent : RO2_TeleportPortalComponent {
		public float enterExitDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				enterExitDist = s.Serialize<float>(enterExitDist, name: "enterExitDist");
			}
		}
		public override uint? ClassCRC => 0x69DC1680;
	}
}

