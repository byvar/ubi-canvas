namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ShooterGardianAIComponent_Template : Ray_SimpleAIComponent_Template {
		public uint minHitStunLevel;
		public float multiPlayerLifePointFactor;
		public Path deathRewardSpawnPath;
		public uint deathRewardNumber;
		public float deathRewardSpawnDuration;
		public Vec2d deathRewardSpawnDist;
		public Vec2d deathRewardSpawnAngle;

		public Path Path__7;
		public StringID StringID__8;
		public uint uint__9;
		public float float__10;
		public float float__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO) {
				minHitStunLevel = s.Serialize<uint>(minHitStunLevel, name: "minHitStunLevel");
				multiPlayerLifePointFactor = s.Serialize<float>(multiPlayerLifePointFactor, name: "multiPlayerLifePointFactor");
				deathRewardSpawnPath = s.SerializeObject<Path>(deathRewardSpawnPath, name: "deathRewardSpawnPath");
				deathRewardNumber = s.Serialize<uint>(deathRewardNumber, name: "deathRewardNumber");
				deathRewardSpawnDuration = s.Serialize<float>(deathRewardSpawnDuration, name: "deathRewardSpawnDuration");
				deathRewardSpawnDist = s.SerializeObject<Vec2d>(deathRewardSpawnDist, name: "deathRewardSpawnDist");
				deathRewardSpawnAngle = s.SerializeObject<Vec2d>(deathRewardSpawnAngle, name: "deathRewardSpawnAngle");
			} else {
				minHitStunLevel = s.Serialize<uint>(minHitStunLevel, name: "minHitStunLevel");
				multiPlayerLifePointFactor = s.Serialize<float>(multiPlayerLifePointFactor, name: "multiPlayerLifePointFactor");
				deathRewardSpawnPath = s.SerializeObject<Path>(deathRewardSpawnPath, name: "deathRewardSpawnPath");
				deathRewardNumber = s.Serialize<uint>(deathRewardNumber, name: "deathRewardNumber");
				deathRewardSpawnDuration = s.Serialize<float>(deathRewardSpawnDuration, name: "deathRewardSpawnDuration");
				deathRewardSpawnDist = s.SerializeObject<Vec2d>(deathRewardSpawnDist, name: "deathRewardSpawnDist");
				deathRewardSpawnAngle = s.SerializeObject<Vec2d>(deathRewardSpawnAngle, name: "deathRewardSpawnAngle");
				Path__7 = s.SerializeObject<Path>(Path__7, name: "Path__7");
				StringID__8 = s.SerializeObject<StringID>(StringID__8, name: "StringID__8");
				uint__9 = s.Serialize<uint>(uint__9, name: "uint__9");
				float__10 = s.Serialize<float>(float__10, name: "float__10");
				float__11 = s.Serialize<float>(float__11, name: "float__11");
			}
		}
		public override uint? ClassCRC => 0xA7CBA488;
	}
}

