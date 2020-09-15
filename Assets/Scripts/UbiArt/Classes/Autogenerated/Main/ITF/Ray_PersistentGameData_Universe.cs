using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_Universe : PersistentGameData_Universe {
		public Ray_PersistentGameData_Score score;
		public Ray_PersistentGameData_WorldMap worldMapData;
		public Ray_PersistentGameData_UniverseTracking trackingData;
		public CList<AbsoluteObjectPath> discoveredCageMapList;
		public uint teethReturned;
		public StringID usedPlayerIDInfo;
		public int sprintTutorialDisabled;
		public uint costumeLastPrice;
		public CList<StringID> costumesUsed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			score = s.SerializeObject<Ray_PersistentGameData_Score>(score, name: "score");
			worldMapData = s.SerializeObject<Ray_PersistentGameData_WorldMap>(worldMapData, name: "worldMapData");
			trackingData = s.SerializeObject<Ray_PersistentGameData_UniverseTracking>(trackingData, name: "trackingData");
			discoveredCageMapList = s.SerializeObject<CList<AbsoluteObjectPath>>(discoveredCageMapList, name: "discoveredCageMapList");
			teethReturned = s.Serialize<uint>(teethReturned, name: "teethReturned");
			usedPlayerIDInfo = s.SerializeObject<StringID>(usedPlayerIDInfo, name: "usedPlayerIDInfo");
			sprintTutorialDisabled = s.Serialize<int>(sprintTutorialDisabled, name: "sprintTutorialDisabled");
			costumeLastPrice = s.Serialize<uint>(costumeLastPrice, name: "costumeLastPrice");
			costumesUsed = s.SerializeObject<CList<StringID>>(costumesUsed, name: "costumesUsed");
		}
		public override uint? ClassCRC => 0x3B2081A7;
	}
}

