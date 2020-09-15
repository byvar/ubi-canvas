using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ElevatorMonsterAIComponent_Template : CSerializable {
		public float ratioSpeed;
		public float distanceForHit;
		public float countDownAttack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ratioSpeed = s.Serialize<float>(ratioSpeed, name: "ratioSpeed");
			distanceForHit = s.Serialize<float>(distanceForHit, name: "distanceForHit");
			countDownAttack = s.Serialize<float>(countDownAttack, name: "countDownAttack");
		}
		public override uint? ClassCRC => 0x49F8D32A;
	}
}

