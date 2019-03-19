using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_SnakeBodyPart_Template : CSerializable {
		[Serialize("lengthOnTrajectory")] public float lengthOnTrajectory;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lengthOnTrajectory));
		}
		public override uint? ClassCRC => 0xEDBFD29A;
	}
}

