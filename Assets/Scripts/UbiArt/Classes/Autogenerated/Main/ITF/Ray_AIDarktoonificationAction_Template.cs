using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonificationAction_Template : Ray_AIPerformHitPunchAction_Template {
		[Serialize("trajectoryDuration"        )] public float trajectoryDuration;
		[Serialize("gravityMultiplier"         )] public float gravityMultiplier;
		[Serialize("gravityMultiplierAfterFail")] public float gravityMultiplierAfterFail;
		[Serialize("initialSpeedAfterFail"     )] public float initialSpeedAfterFail;
		[Serialize("tangentPhaseLimit"         )] public float tangentPhaseLimit;
		[Serialize("maxTargetHeightDifference" )] public float maxTargetHeightDifference;
		[Serialize("maxTargetDistance"         )] public float maxTargetDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(trajectoryDuration));
			SerializeField(s, nameof(gravityMultiplier));
			SerializeField(s, nameof(gravityMultiplierAfterFail));
			SerializeField(s, nameof(initialSpeedAfterFail));
			SerializeField(s, nameof(tangentPhaseLimit));
			SerializeField(s, nameof(maxTargetHeightDifference));
			SerializeField(s, nameof(maxTargetDistance));
		}
		public override uint? ClassCRC => 0x14B8C0F5;
	}
}

