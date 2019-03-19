using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossPlantAIComponent_Template : AIComponent_Template {
		[Serialize("targetEvaluationOffset"        )] public Vector2 targetEvaluationOffset;
		[Serialize("playRateMultiplierMinDistance" )] public float playRateMultiplierMinDistance;
		[Serialize("playRateMultiplierMaxDistance" )] public float playRateMultiplierMaxDistance;
		[Serialize("playRateMultiplierMinValue"    )] public float playRateMultiplierMinValue;
		[Serialize("playRateMultiplierMaxValue"    )] public float playRateMultiplierMaxValue;
		[Serialize("playRateMultiplierAcceleration")] public float playRateMultiplierAcceleration;
		[Serialize("playRateMultiplierDeceleration")] public float playRateMultiplierDeceleration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(targetEvaluationOffset));
			SerializeField(s, nameof(playRateMultiplierMinDistance));
			SerializeField(s, nameof(playRateMultiplierMaxDistance));
			SerializeField(s, nameof(playRateMultiplierMinValue));
			SerializeField(s, nameof(playRateMultiplierMaxValue));
			SerializeField(s, nameof(playRateMultiplierAcceleration));
			SerializeField(s, nameof(playRateMultiplierDeceleration));
		}
		public override uint? ClassCRC => 0x75618729;
	}
}

