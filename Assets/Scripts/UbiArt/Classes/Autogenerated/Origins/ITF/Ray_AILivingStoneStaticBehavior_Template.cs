using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AILivingStoneStaticBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("idle"                   )] public Placeholder idle;
		[Serialize("uturn"                  )] public Placeholder uturn;
		[Serialize("aggro"                  )] public Placeholder aggro;
		[Serialize("attack"                 )] public Placeholder attack;
		[Serialize("detectionRadius"        )] public float detectionRadius;
		[Serialize("detectionHysteresisTime")] public float detectionHysteresisTime;
		[Serialize("attackRange"            )] public Placeholder attackRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(uturn));
			SerializeField(s, nameof(aggro));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(detectionRadius));
			SerializeField(s, nameof(detectionHysteresisTime));
			SerializeField(s, nameof(attackRange));
		}
		public override uint? ClassCRC => 0xAD191865;
	}
}

