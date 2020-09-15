using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonificationAction_Template : Ray_AIPerformHitPunchAction_Template {
		public float trajectoryDuration;
		public float gravityMultiplier;
		public float gravityMultiplierAfterFail;
		public float initialSpeedAfterFail;
		public float tangentPhaseLimit;
		public float maxTargetHeightDifference;
		public float maxTargetDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			trajectoryDuration = s.Serialize<float>(trajectoryDuration, name: "trajectoryDuration");
			gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
			gravityMultiplierAfterFail = s.Serialize<float>(gravityMultiplierAfterFail, name: "gravityMultiplierAfterFail");
			initialSpeedAfterFail = s.Serialize<float>(initialSpeedAfterFail, name: "initialSpeedAfterFail");
			tangentPhaseLimit = s.Serialize<float>(tangentPhaseLimit, name: "tangentPhaseLimit");
			maxTargetHeightDifference = s.Serialize<float>(maxTargetHeightDifference, name: "maxTargetHeightDifference");
			maxTargetDistance = s.Serialize<float>(maxTargetDistance, name: "maxTargetDistance");
		}
		public override uint? ClassCRC => 0x14B8C0F5;
	}
}

