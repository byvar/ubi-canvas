namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventWorldMapUnlock : Event {
		public CListO<StringID> unlocks;
		public int changeCurrentLevelName;
		public StringID levelName;
		public int saveGameState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unlocks = s.SerializeObject<CListO<StringID>>(unlocks, name: "unlocks");
			changeCurrentLevelName = s.Serialize<int>(changeCurrentLevelName, name: "changeCurrentLevelName");
			levelName = s.SerializeObject<StringID>(levelName, name: "levelName");
			saveGameState = s.Serialize<int>(saveGameState, name: "saveGameState");
		}
		public override uint? ClassCRC => 0x732617DC;
	}
}

