namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuLeaderboardComponent_Template : CSerializable {
		public int bufferWantedSize;
		public int bufferQuerySize;
		public int spawnItemsByFrame;
		public StringID playerCardMenuName;
		public Path invitationIconPath;
		public Path costumeIconPath;
		public Path statusIconPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bufferWantedSize = s.Serialize<int>(bufferWantedSize, name: "bufferWantedSize");
			bufferQuerySize = s.Serialize<int>(bufferQuerySize, name: "bufferQuerySize");
			spawnItemsByFrame = s.Serialize<int>(spawnItemsByFrame, name: "spawnItemsByFrame");
			playerCardMenuName = s.SerializeObject<StringID>(playerCardMenuName, name: "playerCardMenuName");
			invitationIconPath = s.SerializeObject<Path>(invitationIconPath, name: "invitationIconPath");
			costumeIconPath = s.SerializeObject<Path>(costumeIconPath, name: "costumeIconPath");
			statusIconPath = s.SerializeObject<Path>(statusIconPath, name: "statusIconPath");
		}
		public override uint? ClassCRC => 0x6400F258;
	}
}

