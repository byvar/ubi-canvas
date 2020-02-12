using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_Universe : PersistentGameData_Universe {
		[Serialize("score"                 )] public Ray_PersistentGameData_Score score;
		[Serialize("worldMapData"          )] public Ray_PersistentGameData_WorldMap worldMapData;
		[Serialize("trackingData"          )] public Ray_PersistentGameData_UniverseTracking trackingData;
		[Serialize("discoveredCageMapList" )] public CList<AbsoluteObjectPath> discoveredCageMapList;
		[Serialize("teethReturned"         )] public uint teethReturned;
		[Serialize("usedPlayerIDInfo"      )] public StringID usedPlayerIDInfo;
		[Serialize("sprintTutorialDisabled")] public int sprintTutorialDisabled;
		[Serialize("costumeLastPrice"      )] public uint costumeLastPrice;
		[Serialize("costumesUsed"          )] public CList<StringID> costumesUsed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(score));
			SerializeField(s, nameof(worldMapData));
			SerializeField(s, nameof(trackingData));
			SerializeField(s, nameof(discoveredCageMapList));
			SerializeField(s, nameof(teethReturned));
			SerializeField(s, nameof(usedPlayerIDInfo));
			SerializeField(s, nameof(sprintTutorialDisabled));
			SerializeField(s, nameof(costumeLastPrice));
			SerializeField(s, nameof(costumesUsed));
		}
		public override uint? ClassCRC => 0x3B2081A7;
	}
}

