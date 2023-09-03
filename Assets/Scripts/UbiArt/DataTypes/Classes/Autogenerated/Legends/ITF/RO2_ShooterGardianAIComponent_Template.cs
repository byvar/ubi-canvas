namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterGardianAIComponent_Template : RO2_SimpleAIComponent_Template {
		public uint minHitStunLevel;
		public float multiPlayerLifePointFactor;
		public Path deathRewardSpawnPath;
		public uint deathRewardNumber;
		public float deathRewardSpawnDuration;
		public Vec2d deathRewardSpawnDist;
		public Vec2d deathRewardSpawnAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minHitStunLevel = s.Serialize<uint>(minHitStunLevel, name: "minHitStunLevel");
			multiPlayerLifePointFactor = s.Serialize<float>(multiPlayerLifePointFactor, name: "multiPlayerLifePointFactor");
			deathRewardSpawnPath = s.SerializeObject<Path>(deathRewardSpawnPath, name: "deathRewardSpawnPath");
			deathRewardNumber = s.Serialize<uint>(deathRewardNumber, name: "deathRewardNumber");
			deathRewardSpawnDuration = s.Serialize<float>(deathRewardSpawnDuration, name: "deathRewardSpawnDuration");
			deathRewardSpawnDist = s.SerializeObject<Vec2d>(deathRewardSpawnDist, name: "deathRewardSpawnDist");
			deathRewardSpawnAngle = s.SerializeObject<Vec2d>(deathRewardSpawnAngle, name: "deathRewardSpawnAngle");
		}
		public override uint? ClassCRC => 0x69FBAF75;
	}
}

