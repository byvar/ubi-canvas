namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MissionManager_Template : TemplateObj {
		public CMap<StringID, RLC_Mission> missions;
		public CMap<StringID, RLC_MissionReward> rewards;
		public CMap<uint, uint> DailyObjectiveMissingPiecesPrices;
		public uint PriceForShuffleDailyObjective;
		public PathRef AchievementFamilyTabPath;
		public Path TutoTapPath;
		public Path TutoPressDownPath;
		public bool AutoOpenNewDailyObjectives;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			missions = s.SerializeObject<CMap<StringID, RLC_Mission>>(missions, name: "missions");
			rewards = s.SerializeObject<CMap<StringID, RLC_MissionReward>>(rewards, name: "rewards");
			DailyObjectiveMissingPiecesPrices = s.SerializeObject<CMap<uint, uint>>(DailyObjectiveMissingPiecesPrices, name: "DailyObjectiveMissingPiecesPrices");
			PriceForShuffleDailyObjective = s.Serialize<uint>(PriceForShuffleDailyObjective, name: "PriceForShuffleDailyObjective");
			AchievementFamilyTabPath = s.SerializeObject<PathRef>(AchievementFamilyTabPath, name: "AchievementFamilyTabPath");
			TutoTapPath = s.SerializeObject<Path>(TutoTapPath, name: "TutoTapPath");
			TutoPressDownPath = s.SerializeObject<Path>(TutoPressDownPath, name: "TutoPressDownPath");
			AutoOpenNewDailyObjectives = s.Serialize<bool>(AutoOpenNewDailyObjectives, name: "AutoOpenNewDailyObjectives");
		}
		public override uint? ClassCRC => 0x7AB8E76D;
	}
}

