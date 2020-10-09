using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SwingRopeComponent : SoftPlatformComponent {
		public Angle initialAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				initialAngle = s.SerializeObject<Angle>(initialAngle, name: "initialAngle");
			}
		}
		public override uint? ClassCRC => 0x3076274A;
	}
}

