using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GyroSpikyComponent : RO2_RailComponent {
		[Serialize("tiltAngleLeft" )] public Angle tiltAngleLeft;
		[Serialize("tiltAngleRight")] public Angle tiltAngleRight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(tiltAngleLeft));
				SerializeField(s, nameof(tiltAngleRight));
			}
		}
		public override uint? ClassCRC => 0x9679A1B4;
	}
}

