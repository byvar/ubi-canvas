namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ShooterGardianMoray_Template : Ray_SnakeAIComponent_Template {
		public float waterPerturbationForce;
		public float waterTestWidth;
		public float waterTestBubonWidth;
		public float waterTestTailLength;
		public float waterTestTailWidth;
		public float waterTestHeadLength;
		public float waterTestHeadWidth;
		public float waterSpawnFxDelay;
		public Path deathRewardSpawnPath;
		public uint deathRewardNumber;
		public float deathRewardSpawnDuration;
		public Vec2d deathRewardSpawnDist;
		public Vec2d deathRewardSpawnAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waterPerturbationForce = s.Serialize<float>(waterPerturbationForce, name: "waterPerturbationForce");
			waterTestWidth = s.Serialize<float>(waterTestWidth, name: "waterTestWidth");
			waterTestBubonWidth = s.Serialize<float>(waterTestBubonWidth, name: "waterTestBubonWidth");
			waterTestTailLength = s.Serialize<float>(waterTestTailLength, name: "waterTestTailLength");
			waterTestTailWidth = s.Serialize<float>(waterTestTailWidth, name: "waterTestTailWidth");
			waterTestHeadLength = s.Serialize<float>(waterTestHeadLength, name: "waterTestHeadLength");
			waterTestHeadWidth = s.Serialize<float>(waterTestHeadWidth, name: "waterTestHeadWidth");
			waterSpawnFxDelay = s.Serialize<float>(waterSpawnFxDelay, name: "waterSpawnFxDelay");
			deathRewardSpawnPath = s.SerializeObject<Path>(deathRewardSpawnPath, name: "deathRewardSpawnPath");
			deathRewardNumber = s.Serialize<uint>(deathRewardNumber, name: "deathRewardNumber");
			deathRewardSpawnDuration = s.Serialize<float>(deathRewardSpawnDuration, name: "deathRewardSpawnDuration");
			deathRewardSpawnDist = s.SerializeObject<Vec2d>(deathRewardSpawnDist, name: "deathRewardSpawnDist");
			deathRewardSpawnAngle = s.SerializeObject<Vec2d>(deathRewardSpawnAngle, name: "deathRewardSpawnAngle");
		}
		public override uint? ClassCRC => 0x72E73AE1;
	}
}

