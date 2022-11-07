namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MissionCreatureDisplay_Template : RLC_BasicCreatureDisplay_Template {
		public Mission_Difficulty missionDifficulty;
		public Mission_Type missionType;
		public StringID missionId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			missionDifficulty = s.Serialize<Mission_Difficulty>(missionDifficulty, name: "missionDifficulty");
			missionType = s.Serialize<Mission_Type>(missionType, name: "missionType");
			missionId = s.SerializeObject<StringID>(missionId, name: "missionId");
		}
		public enum Mission_Difficulty {
			[Serialize("Mission_Difficulty::easy")] easy = 0,
			[Serialize("Mission_Difficulty::hard")] hard = 2,
		}
		public enum Mission_Type {
			[Serialize("Mission_Type::lums"       )] lums = 0,
			[Serialize("Mission_Type::enemy"      )] enemy = 1,
			[Serialize("Mission_Type::completion" )] completion = 2,
			[Serialize("Mission_Type::exploration")] exploration = 3,
		}
		public override uint? ClassCRC => 0xD08B10F6;
	}
}

