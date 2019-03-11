using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_StoneManAIComponent_Template : CSerializable {
		[Serialize("receiveHitWithBoulderBehaviorNew"       )] public Placeholder receiveHitWithBoulderBehaviorNew;
		[Serialize("closeRangeAttackWithBoulderBehavior"    )] public Placeholder closeRangeAttackWithBoulderBehavior;
		[Serialize("closeRangeBackAttackBehavior"           )] public Placeholder closeRangeBackAttackBehavior;
		[Serialize("closeRangeBackAttackWithBoulderBehavior")] public Placeholder closeRangeBackAttackWithBoulderBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(receiveHitWithBoulderBehaviorNew));
			SerializeField(s, nameof(closeRangeAttackWithBoulderBehavior));
			SerializeField(s, nameof(closeRangeBackAttackBehavior));
			SerializeField(s, nameof(closeRangeBackAttackWithBoulderBehavior));
		}
		public override uint? ClassCRC => 0xB995CB03;
	}
}

