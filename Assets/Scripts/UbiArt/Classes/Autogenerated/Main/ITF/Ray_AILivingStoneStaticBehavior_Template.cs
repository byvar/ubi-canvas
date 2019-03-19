using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AILivingStoneStaticBehavior_Template : TemplateAIBehavior {
		[Serialize("idle"                   )] public Generic<AIAction_Template> idle;
		[Serialize("uturn"                  )] public Generic<AIAction_Template> uturn;
		[Serialize("aggro"                  )] public Generic<AIAction_Template> aggro;
		[Serialize("attack"                 )] public Generic<AIAction_Template> attack;
		[Serialize("detectionRadius"        )] public float detectionRadius;
		[Serialize("detectionHysteresisTime")] public float detectionHysteresisTime;
		[Serialize("attackRange"            )] public AABB attackRange;
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

