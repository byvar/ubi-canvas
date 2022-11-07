namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleCharacterSpawnSetupComponent : CSerializable {
		[Description("Spawn index")]
		public int spawnIndex;
		public bool spawnFlipped;
		[Description("The team of the associated character")]
		public Enum_teamType teamType;
		[Description("ObjectId of the associated spotlight used for action/target selection")]
		public Placeholder spotlightID;
		[Description("ObjectId of the associated platform intro sequence")]
		public Placeholder platformIntroSequenceID;
		[Description("ObjectId of the associated platform death sequence")]
		public Placeholder platformDeathSequenceID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spawnIndex = s.Serialize<int>(spawnIndex, name: "spawnIndex");
			spawnFlipped = s.Serialize<bool>(spawnFlipped, name: "spawnFlipped", options: CSerializerObject.Options.BoolAsByte);
			teamType = s.Serialize<Enum_teamType>(teamType, name: "teamType");
			spotlightID = s.SerializeObject<Placeholder>(spotlightID, name: "spotlightID");
			platformIntroSequenceID = s.SerializeObject<Placeholder>(platformIntroSequenceID, name: "platformIntroSequenceID");
			platformDeathSequenceID = s.SerializeObject<Placeholder>(platformDeathSequenceID, name: "platformDeathSequenceID");
		}
		public enum Enum_teamType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x276A5E3B;
	}
}

