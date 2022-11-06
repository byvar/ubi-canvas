using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_StoneManAIComponent_Template : CSerializable {
		public Placeholder receiveHitWithBoulderBehaviorNew;
		public Placeholder closeRangeAttackWithBoulderBehavior;
		public Placeholder closeRangeBackAttackBehavior;
		public Placeholder closeRangeBackAttackWithBoulderBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			receiveHitWithBoulderBehaviorNew = s.SerializeObject<Placeholder>(receiveHitWithBoulderBehaviorNew, name: "receiveHitWithBoulderBehaviorNew");
			closeRangeAttackWithBoulderBehavior = s.SerializeObject<Placeholder>(closeRangeAttackWithBoulderBehavior, name: "closeRangeAttackWithBoulderBehavior");
			closeRangeBackAttackBehavior = s.SerializeObject<Placeholder>(closeRangeBackAttackBehavior, name: "closeRangeBackAttackBehavior");
			closeRangeBackAttackWithBoulderBehavior = s.SerializeObject<Placeholder>(closeRangeBackAttackWithBoulderBehavior, name: "closeRangeBackAttackWithBoulderBehavior");
		}
		public override uint? ClassCRC => 0xB995CB03;
	}
}

