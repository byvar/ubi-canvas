using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GyroSpikyComponent : RO2_RailComponent {
		public Angle tiltAngleLeft;
		public Angle tiltAngleRight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				tiltAngleLeft = s.SerializeObject<Angle>(tiltAngleLeft, name: "tiltAngleLeft");
				tiltAngleRight = s.SerializeObject<Angle>(tiltAngleRight, name: "tiltAngleRight");
			}
		}
		public override uint? ClassCRC => 0x9679A1B4;
	}
}

