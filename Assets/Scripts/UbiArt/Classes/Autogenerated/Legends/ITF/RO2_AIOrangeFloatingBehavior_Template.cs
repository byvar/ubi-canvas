using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIOrangeFloatingBehavior_Template : RO2_AIWaterFloatingBehavior_Template {
		public float orangeMinSpeed;
		public float orangeMaxSpeed;
		public float landingSpeedXThreshold;
		public float arrivalDistance;
		public float moveThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			orangeMinSpeed = s.Serialize<float>(orangeMinSpeed, name: "orangeMinSpeed");
			orangeMaxSpeed = s.Serialize<float>(orangeMaxSpeed, name: "orangeMaxSpeed");
			landingSpeedXThreshold = s.Serialize<float>(landingSpeedXThreshold, name: "landingSpeedXThreshold");
			arrivalDistance = s.Serialize<float>(arrivalDistance, name: "arrivalDistance");
			moveThreshold = s.Serialize<float>(moveThreshold, name: "moveThreshold");
		}
		public override uint? ClassCRC => 0xFBA39F47;
	}
}

