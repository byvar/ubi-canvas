namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleTriggerComponent : COL_BaseInteractiveComponent {
		public COL_BattleSetupsConfig battleSetupsConfigOverride;
		[Description("Ally CharacterId to force on the first spawn setup")]
		public StringID forcedCharacterId_1;
		[Description("Ally CharacterId to force on the second spawn setup")]
		public StringID forcedCharacterId_2;
		[Description("Item reward for boss enemy")]
		public StringID bossItemReward;
		public Enum_forcedInitiativeType forcedInitiativeType;
		public Vec2d fleeBattlePosOffsetOverride;
		public bool useFleeBattlePosOffsetOverride;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			battleSetupsConfigOverride = s.SerializeObject<COL_BattleSetupsConfig>(battleSetupsConfigOverride, name: "battleSetupsConfigOverride");
			forcedCharacterId_1 = s.SerializeObject<StringID>(forcedCharacterId_1, name: "forcedCharacterId_1");
			forcedCharacterId_2 = s.SerializeObject<StringID>(forcedCharacterId_2, name: "forcedCharacterId_2");
			bossItemReward = s.SerializeObject<StringID>(bossItemReward, name: "bossItemReward");
			forcedInitiativeType = s.Serialize<Enum_forcedInitiativeType>(forcedInitiativeType, name: "forcedInitiativeType");
			fleeBattlePosOffsetOverride = s.SerializeObject<Vec2d>(fleeBattlePosOffsetOverride, name: "fleeBattlePosOffsetOverride");
			useFleeBattlePosOffsetOverride = s.Serialize<bool>(useFleeBattlePosOffsetOverride, name: "useFleeBattlePosOffsetOverride", options: CSerializerObject.Options.BoolAsByte);
		}
		public enum Enum_forcedInitiativeType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x193D5565;
	}
}

