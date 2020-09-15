using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class userProfileData : userProfileOtherData {
		public string privateName;
		public string save;
		public string token;
		public CList<SocialNetworkIdentity> snsIds;
		public string deviceLanguage;
		public CArray<DeviceUIDInfo> deviceUID;
		public CMap<string, uint> hatchingParams;
		public CMap<uint, ITF.RO2_PersistentGameData_Universe.SeasonalEventData> seasonalEventList;
		public CMap<string, float> clusteringInfo;
		public CMap<StringID, StringID> playerPopulations;
		public string universeLastUpdate;
		public uint charlieCountdown;
		public uint saveVersionFormat;
		public uint saveBranchId;
		public uint saveUniqueId;
		public string saveUbiId;
		public bool notificationsEnabled;
		public incubationStatusResult incubationData;
		public float playTime;
		public uint nbSessions;
		public uint nbGemsAcquiredLtd;
		public uint storeVisitsLtd;
		public uint nbGemsUsedLtd;
		public string osVersion;
		public uint iapScore;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			privateName = s.Serialize<string>(privateName, name: "privateName");
			save = s.Serialize<string>(save, name: "save");
			token = s.Serialize<string>(token, name: "token");
			snsIds = s.SerializeObject<CList<SocialNetworkIdentity>>(snsIds, name: "snsIds");
			deviceLanguage = s.Serialize<string>(deviceLanguage, name: "deviceLanguage");
			deviceUID = s.SerializeObject<CArray<DeviceUIDInfo>>(deviceUID, name: "deviceUID");
			hatchingParams = s.SerializeObject<CMap<string, uint>>(hatchingParams, name: "hatchingParams");
			seasonalEventList = s.SerializeObject<CMap<uint, ITF.RO2_PersistentGameData_Universe.SeasonalEventData>>(seasonalEventList, name: "seasonalEventList");
			clusteringInfo = s.SerializeObject<CMap<string, float>>(clusteringInfo, name: "clusteringInfo");
			playerPopulations = s.SerializeObject<CMap<StringID, StringID>>(playerPopulations, name: "playerPopulations");
			universeLastUpdate = s.Serialize<string>(universeLastUpdate, name: "universeLastUpdate");
			charlieCountdown = s.Serialize<uint>(charlieCountdown, name: "charlieCountdown");
			saveVersionFormat = s.Serialize<uint>(saveVersionFormat, name: "saveVersionFormat");
			saveBranchId = s.Serialize<uint>(saveBranchId, name: "saveBranchId");
			saveUniqueId = s.Serialize<uint>(saveUniqueId, name: "saveUniqueId");
			saveUbiId = s.Serialize<string>(saveUbiId, name: "saveUbiId");
			notificationsEnabled = s.Serialize<bool>(notificationsEnabled, name: "notificationsEnabled");
			incubationData = s.SerializeObject<incubationStatusResult>(incubationData, name: "incubationData");
			playTime = s.Serialize<float>(playTime, name: "playTime");
			nbSessions = s.Serialize<uint>(nbSessions, name: "nbSessions");
			nbGemsAcquiredLtd = s.Serialize<uint>(nbGemsAcquiredLtd, name: "nbGemsAcquiredLtd");
			storeVisitsLtd = s.Serialize<uint>(storeVisitsLtd, name: "storeVisitsLtd");
			nbGemsUsedLtd = s.Serialize<uint>(nbGemsUsedLtd, name: "nbGemsUsedLtd");
			osVersion = s.Serialize<string>(osVersion, name: "osVersion");
			iapScore = s.Serialize<uint>(iapScore, name: "iapScore");
		}
		public override uint? ClassCRC => 0xC4AE8E75;
	}
}

