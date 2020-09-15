using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AILivingStoneStaticBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> idle;
		public Generic<AIAction_Template> uturn;
		public Generic<AIAction_Template> aggro;
		public Generic<AIAction_Template> attack;
		public float detectionRadius;
		public float detectionHysteresisTime;
		public AABB attackRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIAction_Template>>(idle, name: "idle");
			uturn = s.SerializeObject<Generic<AIAction_Template>>(uturn, name: "uturn");
			aggro = s.SerializeObject<Generic<AIAction_Template>>(aggro, name: "aggro");
			attack = s.SerializeObject<Generic<AIAction_Template>>(attack, name: "attack");
			detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
			detectionHysteresisTime = s.Serialize<float>(detectionHysteresisTime, name: "detectionHysteresisTime");
			attackRange = s.SerializeObject<AABB>(attackRange, name: "attackRange");
		}
		public override uint? ClassCRC => 0xAD191865;
	}
}

