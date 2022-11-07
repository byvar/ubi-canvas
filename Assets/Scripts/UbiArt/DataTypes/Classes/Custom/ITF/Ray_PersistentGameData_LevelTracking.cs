namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_LevelTracking : CSerializable {
		public uint runCount;
		public uint challengeTimeAttackCount;
		public uint challengeHidden1;
		public uint challengeHidden2;
		public uint challengeCage;
		public float firstTimeLevelCompleted;
		public uint challengeLumsStage1;
		public uint challengeLumsStage2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			runCount = s.Serialize<uint>(runCount, name: "runCount");
			challengeTimeAttackCount = s.Serialize<uint>(challengeTimeAttackCount, name: "challengeTimeAttackCount");
			challengeHidden1 = s.Serialize<uint>(challengeHidden1, name: "challengeHidden1");
			challengeHidden2 = s.Serialize<uint>(challengeHidden2, name: "challengeHidden2");
			challengeCage = s.Serialize<uint>(challengeCage, name: "challengeCage");
			firstTimeLevelCompleted = s.Serialize<float>(firstTimeLevelCompleted, name: "firstTimeLevelCompleted");
			challengeLumsStage1 = s.Serialize<uint>(challengeLumsStage1, name: "challengeLumsStage1");
			challengeLumsStage2 = s.Serialize<uint>(challengeLumsStage2, name: "challengeLumsStage2");
		}
	}
}
