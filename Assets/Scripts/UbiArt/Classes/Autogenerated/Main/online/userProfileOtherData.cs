using UnityEngine;

namespace UbiArt.online {
	public partial class userProfileOtherData : userProfileShortData {
		[Serialize("userItems"                )] public string userItems;
		[Serialize("lang"                     )] public uint lang;
		[Serialize("timeZoneOffset"           )] public int timeZoneOffset;
		[Serialize("gameVersion"              )] public string gameVersion;
		[Serialize("engineVersion"            )] public uint engineVersion;
		[Serialize("creatures"                )] public CList<ITF.RO2_PersistentGameData_Universe.RLC_CreatureData> creatures;
		[Serialize("currentAdvGraphicalFamily")] public uint currentAdvGraphicalFamily;
		[Serialize("joinDate"                 )] public string joinDate;
		[Serialize("lastUpdate"               )] public string lastUpdate;
		[Serialize("adventureCount"           )] public uint adventureCount;
		[Serialize("mapAdventureCount"        )] public uint mapAdventureCount;
		[Serialize("incubatorCreatureRegion"  )] public uint incubatorCreatureRegion;
		[Serialize("randomSeed"               )] public uint randomSeed;
		[Serialize("populations"              )] public CMap<ITF.StringID, ITF.StringID> populations;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(userItems));
			SerializeField(s, nameof(lang));
			SerializeField(s, nameof(timeZoneOffset));
			SerializeField(s, nameof(gameVersion));
			SerializeField(s, nameof(engineVersion));
			SerializeField(s, nameof(creatures));
			SerializeField(s, nameof(currentAdvGraphicalFamily));
			SerializeField(s, nameof(joinDate));
			SerializeField(s, nameof(lastUpdate));
			SerializeField(s, nameof(adventureCount));
			SerializeField(s, nameof(mapAdventureCount));
			SerializeField(s, nameof(incubatorCreatureRegion));
			SerializeField(s, nameof(randomSeed));
			SerializeField(s, nameof(populations));
		}
		public override uint? ClassCRC => 0x4B2CE325;
	}
}

