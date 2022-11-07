namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AudioEventManager_BattleData : CSerializable {
		public Placeholder startBattleNormal;
		public Placeholder startBattlePreemptive;
		public Placeholder startBattleAmbushed;
		public Placeholder gameOverSfx;
		public StringID musicStateBattleDefault;
		public StringID musicStateBattleWin;
		public StringID musicStateBattleLose;
		public StringID musicStateBattleLevelUp;
		public StringID musicStateBattleFlee;
		public StringID musicStateBattleMiniBoss;
		public StringID musicStateBattleWinBoss;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startBattleNormal = s.SerializeObject<Placeholder>(startBattleNormal, name: "startBattleNormal");
			startBattlePreemptive = s.SerializeObject<Placeholder>(startBattlePreemptive, name: "startBattlePreemptive");
			startBattleAmbushed = s.SerializeObject<Placeholder>(startBattleAmbushed, name: "startBattleAmbushed");
			gameOverSfx = s.SerializeObject<Placeholder>(gameOverSfx, name: "gameOverSfx");
			musicStateBattleDefault = s.SerializeObject<StringID>(musicStateBattleDefault, name: "musicStateBattleDefault");
			musicStateBattleWin = s.SerializeObject<StringID>(musicStateBattleWin, name: "musicStateBattleWin");
			musicStateBattleLose = s.SerializeObject<StringID>(musicStateBattleLose, name: "musicStateBattleLose");
			musicStateBattleLevelUp = s.SerializeObject<StringID>(musicStateBattleLevelUp, name: "musicStateBattleLevelUp");
			musicStateBattleFlee = s.SerializeObject<StringID>(musicStateBattleFlee, name: "musicStateBattleFlee");
			musicStateBattleMiniBoss = s.SerializeObject<StringID>(musicStateBattleMiniBoss, name: "musicStateBattleMiniBoss");
			musicStateBattleWinBoss = s.SerializeObject<StringID>(musicStateBattleWinBoss, name: "musicStateBattleWinBoss");
		}
		public override uint? ClassCRC => 0xF1EBE701;
	}
}

