namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class userProfileOtherData : userProfileShortData {
		public string userItems;
		public uint lang;
		public int timeZoneOffset;
		public string gameVersion;
		public uint engineVersion;
		public CListO<ITF.RO2_PersistentGameData_Universe.RLC_CreatureData> creatures;
		public uint currentAdvGraphicalFamily;
		public string joinDate;
		public string lastUpdate;
		public uint adventureCount;
		public uint mapAdventureCount;
		public uint incubatorCreatureRegion;
		public uint randomSeed;
		public CMap<StringID, StringID> populations;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			userItems = s.Serialize<string>(userItems, name: "userItems");
			lang = s.Serialize<uint>(lang, name: "lang");
			timeZoneOffset = s.Serialize<int>(timeZoneOffset, name: "timeZoneOffset");
			gameVersion = s.Serialize<string>(gameVersion, name: "gameVersion");
			engineVersion = s.Serialize<uint>(engineVersion, name: "engineVersion");
			creatures = s.SerializeObject<CListO<ITF.RO2_PersistentGameData_Universe.RLC_CreatureData>>(creatures, name: "creatures");
			currentAdvGraphicalFamily = s.Serialize<uint>(currentAdvGraphicalFamily, name: "currentAdvGraphicalFamily");
			joinDate = s.Serialize<string>(joinDate, name: "joinDate");
			lastUpdate = s.Serialize<string>(lastUpdate, name: "lastUpdate");
			adventureCount = s.Serialize<uint>(adventureCount, name: "adventureCount");
			mapAdventureCount = s.Serialize<uint>(mapAdventureCount, name: "mapAdventureCount");
			incubatorCreatureRegion = s.Serialize<uint>(incubatorCreatureRegion, name: "incubatorCreatureRegion");
			randomSeed = s.Serialize<uint>(randomSeed, name: "randomSeed");
			populations = s.SerializeObject<CMap<StringID, StringID>>(populations, name: "populations");
		}
		public override uint? ClassCRC => 0x4B2CE325;
	}
}

