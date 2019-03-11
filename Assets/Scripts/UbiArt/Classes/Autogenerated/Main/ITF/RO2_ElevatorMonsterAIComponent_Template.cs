using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ElevatorMonsterAIComponent_Template : ActorComponent_Template {
		[Serialize("ratioSpeed"     )] public float ratioSpeed;
		[Serialize("distanceForHit" )] public float distanceForHit;
		[Serialize("countDownAttack")] public float countDownAttack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ratioSpeed));
			SerializeField(s, nameof(distanceForHit));
			SerializeField(s, nameof(countDownAttack));
		}
		public override uint? ClassCRC => 0x5E7A6BA7;
	}
}

