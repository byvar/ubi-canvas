using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AILookatBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> idle;
		public Generic<AIAction_Template> uturn;
		public Generic<AIAction_Template> aggro;
		public Generic<AIAction_Template> attack;
		public float detectionRadius;
		public float detectionHysteresisTime;
		public float attackRadius;
		public float attackDelay;
		public int attackLookAt;
		public float lookAtSmoothFactor;
		public int stickOnWalls;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIAction_Template>>(idle, name: "idle");
			uturn = s.SerializeObject<Generic<AIAction_Template>>(uturn, name: "uturn");
			aggro = s.SerializeObject<Generic<AIAction_Template>>(aggro, name: "aggro");
			attack = s.SerializeObject<Generic<AIAction_Template>>(attack, name: "attack");
			detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
			detectionHysteresisTime = s.Serialize<float>(detectionHysteresisTime, name: "detectionHysteresisTime");
			attackRadius = s.Serialize<float>(attackRadius, name: "attackRadius");
			attackDelay = s.Serialize<float>(attackDelay, name: "attackDelay");
			attackLookAt = s.Serialize<int>(attackLookAt, name: "attackLookAt");
			lookAtSmoothFactor = s.Serialize<float>(lookAtSmoothFactor, name: "lookAtSmoothFactor");
			stickOnWalls = s.Serialize<int>(stickOnWalls, name: "stickOnWalls");
		}
		public override uint? ClassCRC => 0x572AE3DD;
	}
}

