using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AILookatBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("idle"                   )] public Placeholder idle;
		[Serialize("uturn"                  )] public Placeholder uturn;
		[Serialize("aggro"                  )] public Placeholder aggro;
		[Serialize("attack"                 )] public Placeholder attack;
		[Serialize("detectionRadius"        )] public float detectionRadius;
		[Serialize("detectionHysteresisTime")] public float detectionHysteresisTime;
		[Serialize("attackRadius"           )] public float attackRadius;
		[Serialize("attackDelay"            )] public float attackDelay;
		[Serialize("attackLookAt"           )] public bool attackLookAt;
		[Serialize("lookAtSmoothFactor"     )] public float lookAtSmoothFactor;
		[Serialize("stickOnWalls"           )] public bool stickOnWalls;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(uturn));
			SerializeField(s, nameof(aggro));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(detectionRadius));
			SerializeField(s, nameof(detectionHysteresisTime));
			SerializeField(s, nameof(attackRadius));
			SerializeField(s, nameof(attackDelay));
			SerializeField(s, nameof(attackLookAt));
			SerializeField(s, nameof(lookAtSmoothFactor));
			SerializeField(s, nameof(stickOnWalls));
		}
		public override uint? ClassCRC => 0x572AE3DD;
	}
}

