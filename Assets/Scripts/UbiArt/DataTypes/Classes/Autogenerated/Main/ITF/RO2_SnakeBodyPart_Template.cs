using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_SnakeBodyPart_Template : CSerializable {
		public float lengthOnTrajectory;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lengthOnTrajectory = s.Serialize<float>(lengthOnTrajectory, name: "lengthOnTrajectory");
		}
		public override uint? ClassCRC => 0xEDBFD29A;
	}
}

