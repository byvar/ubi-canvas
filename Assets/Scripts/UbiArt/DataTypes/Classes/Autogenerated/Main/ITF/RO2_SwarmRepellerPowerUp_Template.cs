namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SwarmRepellerPowerUp_Template : RO2_PowerUpDisplay_Template {
		public Path repellerActor;
		public Vec2d playerFollowOffset;
		public float speedBlend = 1f;
		public float speedMin;
		public float speedMax = 1f;
		public float blendAtSpeedMin;
		public float blendAtSpeedMax = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			repellerActor = s.SerializeObject<Path>(repellerActor, name: "repellerActor");
			playerFollowOffset = s.SerializeObject<Vec2d>(playerFollowOffset, name: "playerFollowOffset");
			speedBlend = s.Serialize<float>(speedBlend, name: "speedBlend");
			speedMin = s.Serialize<float>(speedMin, name: "speedMin");
			speedMax = s.Serialize<float>(speedMax, name: "speedMax");
			blendAtSpeedMin = s.Serialize<float>(blendAtSpeedMin, name: "blendAtSpeedMin");
			blendAtSpeedMax = s.Serialize<float>(blendAtSpeedMax, name: "blendAtSpeedMax");
		}
		public override uint? ClassCRC => 0xDC99EBB2;
	}
}

