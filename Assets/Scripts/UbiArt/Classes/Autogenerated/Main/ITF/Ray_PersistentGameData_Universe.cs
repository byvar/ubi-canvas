using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_Universe : CSerializable {
		[Serialize("score"                          )] public Placeholder score;
		[Serialize("Ray_PersistentGameData_Score"   )] public Placeholder Ray_PersistentGameData_Score;
		[Serialize("lumCount"                       )] public Placeholder lumCount;
		[Serialize("worldMapData"                   )] public Placeholder worldMapData;
		[Serialize("Ray_PersistentGameData_WorldMap")] public Placeholder Ray_PersistentGameData_WorldMap;
		[Serialize("trackingData"                   )] public Placeholder trackingData;
		[Serialize("discoveredCageMapList"          )] public Placeholder discoveredCageMapList;
		[Serialize("teethReturned"                  )] public uint teethReturned;
		[Serialize("usedPlayerIDInfo"               )] public StringID usedPlayerIDInfo;
		[Serialize("sprintTutorialDisabled"         )] public int sprintTutorialDisabled;
		[Serialize("costumeLastPrice"               )] public uint costumeLastPrice;
		[Serialize("costumesUsed"                   )] public Placeholder costumesUsed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(score));
			SerializeField(s, nameof(Ray_PersistentGameData_Score));
			SerializeField(s, nameof(lumCount));
			SerializeField(s, nameof(worldMapData));
			SerializeField(s, nameof(Ray_PersistentGameData_WorldMap));
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

