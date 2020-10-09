using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_BossPlantAIComponent_Template : AIComponent_Template {
		public Vec2d targetEvaluationOffset;
		public float playRateMultiplierMinDistance;
		public float playRateMultiplierMaxDistance;
		public float playRateMultiplierMinValue;
		public float playRateMultiplierMaxValue;
		public float playRateMultiplierAcceleration;
		public float playRateMultiplierDeceleration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			targetEvaluationOffset = s.SerializeObject<Vec2d>(targetEvaluationOffset, name: "targetEvaluationOffset");
			playRateMultiplierMinDistance = s.Serialize<float>(playRateMultiplierMinDistance, name: "playRateMultiplierMinDistance");
			playRateMultiplierMaxDistance = s.Serialize<float>(playRateMultiplierMaxDistance, name: "playRateMultiplierMaxDistance");
			playRateMultiplierMinValue = s.Serialize<float>(playRateMultiplierMinValue, name: "playRateMultiplierMinValue");
			playRateMultiplierMaxValue = s.Serialize<float>(playRateMultiplierMaxValue, name: "playRateMultiplierMaxValue");
			playRateMultiplierAcceleration = s.Serialize<float>(playRateMultiplierAcceleration, name: "playRateMultiplierAcceleration");
			playRateMultiplierDeceleration = s.Serialize<float>(playRateMultiplierDeceleration, name: "playRateMultiplierDeceleration");
		}
		public override uint? ClassCRC => 0x75618729;
	}
}

