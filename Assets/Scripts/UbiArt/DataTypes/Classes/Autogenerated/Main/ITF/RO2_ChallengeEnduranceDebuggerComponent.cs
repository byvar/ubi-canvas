namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ChallengeEnduranceDebuggerComponent : ActorComponent {
		public Path modePath;
		public uint startDifficulty;
		public uint stressTestMinSeed;
		public uint stressTestMaxSeed;
		public uint stressTestSpawnCount;
		public float stressTestCompetitionDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				modePath = s.SerializeObject<Path>(modePath, name: "modePath");
				startDifficulty = s.Serialize<uint>(startDifficulty, name: "startDifficulty");
				stressTestMinSeed = s.Serialize<uint>(stressTestMinSeed, name: "stressTestMinSeed");
				stressTestMaxSeed = s.Serialize<uint>(stressTestMaxSeed, name: "stressTestMaxSeed");
				stressTestSpawnCount = s.Serialize<uint>(stressTestSpawnCount, name: "stressTestSpawnCount");
				stressTestCompetitionDistance = s.Serialize<float>(stressTestCompetitionDistance, name: "stressTestCompetitionDistance");
			}
		}
		public override uint? ClassCRC => 0x69C804F3;
	}
}

