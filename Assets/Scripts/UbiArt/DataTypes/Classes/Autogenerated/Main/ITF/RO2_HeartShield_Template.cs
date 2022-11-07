namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_HeartShield_Template : RO2_PowerUpDisplay_Template {
		public Path heartActor;
		public StringID heartDeathBhvName;
		public StringID heartAppearBhvName;
		public Vec2d playerFollowOffset;
		public float speedBlend;
		public float speedMin;
		public float speedMax;
		public float blendAtSpeedMin;
		public float blendAtSpeedMax;
		public float depthOffset;
		public float approachDistance;
		public float approachStartBlend;
		public float approachEndBlend;
		public float approachBlendTime;
		public float m_approachEndDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			heartActor = s.SerializeObject<Path>(heartActor, name: "heartActor");
			heartDeathBhvName = s.SerializeObject<StringID>(heartDeathBhvName, name: "heartDeathBhvName");
			heartAppearBhvName = s.SerializeObject<StringID>(heartAppearBhvName, name: "heartAppearBhvName");
			playerFollowOffset = s.SerializeObject<Vec2d>(playerFollowOffset, name: "playerFollowOffset");
			speedBlend = s.Serialize<float>(speedBlend, name: "speedBlend");
			speedMin = s.Serialize<float>(speedMin, name: "speedMin");
			speedMax = s.Serialize<float>(speedMax, name: "speedMax");
			blendAtSpeedMin = s.Serialize<float>(blendAtSpeedMin, name: "blendAtSpeedMin");
			blendAtSpeedMax = s.Serialize<float>(blendAtSpeedMax, name: "blendAtSpeedMax");
			depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
			approachDistance = s.Serialize<float>(approachDistance, name: "approachDistance");
			approachStartBlend = s.Serialize<float>(approachStartBlend, name: "approachStartBlend");
			approachEndBlend = s.Serialize<float>(approachEndBlend, name: "approachEndBlend");
			approachBlendTime = s.Serialize<float>(approachBlendTime, name: "approachBlendTime");
			m_approachEndDistance = s.Serialize<float>(m_approachEndDistance, name: "m_approachEndDistance");
		}
		public override uint? ClassCRC => 0x38602DC1;
	}
}

