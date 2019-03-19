using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class userProfileData : userProfileOtherData {
		[Serialize("privateName"         )] public string privateName;
		[Serialize("save"                )] public string save;
		[Serialize("token"               )] public string token;
		[Serialize("snsIds"              )] public CList<SocialNetworkIdentity> snsIds;
		[Serialize("deviceLanguage"      )] public string deviceLanguage;
		[Serialize("deviceUID"           )] public CArray<DeviceUIDInfo> deviceUID;
		[Serialize("hatchingParams"      )] public CMap<string, uint> hatchingParams;
		[Serialize("seasonalEventList"   )] public CMap<uint, ITF.RO2_PersistentGameData_Universe.SeasonalEventData> seasonalEventList;
		[Serialize("clusteringInfo"      )] public CMap<string, float> clusteringInfo;
		[Serialize("playerPopulations"   )] public CMap<StringID, StringID> playerPopulations;
		[Serialize("universeLastUpdate"  )] public string universeLastUpdate;
		[Serialize("charlieCountdown"    )] public uint charlieCountdown;
		[Serialize("saveVersionFormat"   )] public uint saveVersionFormat;
		[Serialize("saveBranchId"        )] public uint saveBranchId;
		[Serialize("saveUniqueId"        )] public uint saveUniqueId;
		[Serialize("saveUbiId"           )] public string saveUbiId;
		[Serialize("notificationsEnabled")] public bool notificationsEnabled;
		[Serialize("incubationData"      )] public incubationStatusResult incubationData;
		[Serialize("playTime"            )] public float playTime;
		[Serialize("nbSessions"          )] public uint nbSessions;
		[Serialize("nbGemsAcquiredLtd"   )] public uint nbGemsAcquiredLtd;
		[Serialize("storeVisitsLtd"      )] public uint storeVisitsLtd;
		[Serialize("nbGemsUsedLtd"       )] public uint nbGemsUsedLtd;
		[Serialize("osVersion"           )] public string osVersion;
		[Serialize("iapScore"            )] public uint iapScore;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(privateName));
			SerializeField(s, nameof(save));
			SerializeField(s, nameof(token));
			SerializeField(s, nameof(snsIds));
			SerializeField(s, nameof(deviceLanguage));
			SerializeField(s, nameof(deviceUID));
			SerializeField(s, nameof(hatchingParams));
			SerializeField(s, nameof(seasonalEventList));
			SerializeField(s, nameof(clusteringInfo));
			SerializeField(s, nameof(playerPopulations));
			SerializeField(s, nameof(universeLastUpdate));
			SerializeField(s, nameof(charlieCountdown));
			SerializeField(s, nameof(saveVersionFormat));
			SerializeField(s, nameof(saveBranchId));
			SerializeField(s, nameof(saveUniqueId));
			SerializeField(s, nameof(saveUbiId));
			SerializeField(s, nameof(notificationsEnabled));
			SerializeField(s, nameof(incubationData));
			SerializeField(s, nameof(playTime));
			SerializeField(s, nameof(nbSessions));
			SerializeField(s, nameof(nbGemsAcquiredLtd));
			SerializeField(s, nameof(storeVisitsLtd));
			SerializeField(s, nameof(nbGemsUsedLtd));
			SerializeField(s, nameof(osVersion));
			SerializeField(s, nameof(iapScore));
		}
		public override uint? ClassCRC => 0xC4AE8E75;
	}
}

