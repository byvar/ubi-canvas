using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIAlInfernoWaiterBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		public Generic<AIAction_Template> fall;
		public Generic<AIAction_Template> patrol;
		public Generic<AIAction_Template> longRangeAttack;
		public Generic<AIAction_Template> crushed;
		public Generic<AIAction_Template> uturn_walk;
		public AABB longRangeAttackDetectionRange;
		public StringID flamesFXName;
		public StringID catchWalkAnimation;
		public float crushedVerticalSpeedThreshold;
		public float attackTimeThreshold;
		public float brakingForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fall = s.SerializeObject<Generic<AIAction_Template>>(fall, name: "fall");
			patrol = s.SerializeObject<Generic<AIAction_Template>>(patrol, name: "patrol");
			longRangeAttack = s.SerializeObject<Generic<AIAction_Template>>(longRangeAttack, name: "longRangeAttack");
			crushed = s.SerializeObject<Generic<AIAction_Template>>(crushed, name: "crushed");
			uturn_walk = s.SerializeObject<Generic<AIAction_Template>>(uturn_walk, name: "uturn_walk");
			longRangeAttackDetectionRange = s.SerializeObject<AABB>(longRangeAttackDetectionRange, name: "longRangeAttackDetectionRange");
			flamesFXName = s.SerializeObject<StringID>(flamesFXName, name: "flamesFXName");
			catchWalkAnimation = s.SerializeObject<StringID>(catchWalkAnimation, name: "catchWalkAnimation");
			crushedVerticalSpeedThreshold = s.Serialize<float>(crushedVerticalSpeedThreshold, name: "crushedVerticalSpeedThreshold");
			attackTimeThreshold = s.Serialize<float>(attackTimeThreshold, name: "attackTimeThreshold");
			brakingForce = s.Serialize<float>(brakingForce, name: "brakingForce");
		}
		public override uint? ClassCRC => 0xC586D512;
	}
}

