namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PlayerForceFollowComponent_Template : ActorComponent_Template {
		public float sprintDistance;
		public float sprintDistanceHysteresis;
		public Vec2d offset;
		public bool forcePositionMode;
		public float forcePositionModeDistanceThreshold;
		public float forcePositionModeSprintThreshold;
		public float forcePositionModeBlendFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sprintDistance = s.Serialize<float>(sprintDistance, name: "sprintDistance");
			sprintDistanceHysteresis = s.Serialize<float>(sprintDistanceHysteresis, name: "sprintDistanceHysteresis");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
			forcePositionMode = s.Serialize<bool>(forcePositionMode, name: "forcePositionMode");
			forcePositionModeDistanceThreshold = s.Serialize<float>(forcePositionModeDistanceThreshold, name: "forcePositionModeDistanceThreshold");
			forcePositionModeSprintThreshold = s.Serialize<float>(forcePositionModeSprintThreshold, name: "forcePositionModeSprintThreshold");
			forcePositionModeBlendFactor = s.Serialize<float>(forcePositionModeBlendFactor, name: "forcePositionModeBlendFactor");
		}
		public override uint? ClassCRC => 0x2932FAAA;
	}
}

