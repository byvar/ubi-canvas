using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RailComponent : ActorComponent {
		public float limitLeft;
		public float limitRight;
		public float extremityLeftOffset;
		public float extremityRightOffset;
		public float initPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				limitLeft = s.Serialize<float>(limitLeft, name: "limitLeft");
				limitRight = s.Serialize<float>(limitRight, name: "limitRight");
				extremityLeftOffset = s.Serialize<float>(extremityLeftOffset, name: "extremityLeftOffset");
				extremityRightOffset = s.Serialize<float>(extremityRightOffset, name: "extremityRightOffset");
				initPos = s.Serialize<float>(initPos, name: "initPos");
			}
		}
		public override uint? ClassCRC => 0x278C80D1;
	}
}

