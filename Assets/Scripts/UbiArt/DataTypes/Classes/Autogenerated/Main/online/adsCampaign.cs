namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class adsCampaign : CSerializable {
		public string name;
		public RLC_AdsType adlocation;
		public uint showOnceInXHours;
		public uint notShownAdsInXHours;
		public uint notShownAdsInXDays;
		public uint totalSpendsMin;
		public uint totalSpendsMax;
		public uint adventureMin;
		public uint adventureMax;
		public uint gemsMin;
		public uint gemsMax;
		public uint activeDaysMin;
		public uint activeDaysMax;
		public uint spyglassMin;
		public uint spyglassMax;
		public uint starsCount;
		public RLC_EggType eggType;
		public ITF.RLC_MapType levelType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.Serialize<string>(name, name: "name");
			adlocation = s.Serialize<RLC_AdsType>(adlocation, name: "adlocation");
			showOnceInXHours = s.Serialize<uint>(showOnceInXHours, name: "showOnceInXHours");
			notShownAdsInXHours = s.Serialize<uint>(notShownAdsInXHours, name: "notShownAdsInXHours");
			notShownAdsInXDays = s.Serialize<uint>(notShownAdsInXDays, name: "notShownAdsInXDays");
			totalSpendsMin = s.Serialize<uint>(totalSpendsMin, name: "totalSpendsMin");
			totalSpendsMax = s.Serialize<uint>(totalSpendsMax, name: "totalSpendsMax");
			adventureMin = s.Serialize<uint>(adventureMin, name: "adventureMin");
			adventureMax = s.Serialize<uint>(adventureMax, name: "adventureMax");
			gemsMin = s.Serialize<uint>(gemsMin, name: "gemsMin");
			gemsMax = s.Serialize<uint>(gemsMax, name: "gemsMax");
			activeDaysMin = s.Serialize<uint>(activeDaysMin, name: "activeDaysMin");
			activeDaysMax = s.Serialize<uint>(activeDaysMax, name: "activeDaysMax");
			spyglassMin = s.Serialize<uint>(spyglassMin, name: "spyglassMin");
			spyglassMax = s.Serialize<uint>(spyglassMax, name: "spyglassMax");
			starsCount = s.Serialize<uint>(starsCount, name: "starsCount");
			eggType = s.Serialize<RLC_EggType>(eggType, name: "eggType");
			levelType = s.Serialize<ITF.RLC_MapType>(levelType, name: "levelType");
		}
		public enum RLC_AdsType {
			[Serialize("RLC_AdsType_Unknown"              )] Unknown = 0,
			[Serialize("RLC_AdsType_DoubleRewards"        )] DoubleRewards = 1,
			[Serialize("RLC_AdsType_FreeTimeElixir"       )] FreeTimeElixir = 2,
			[Serialize("RLC_AdsType_FreeSpyGlass"         )] FreeSpyGlass = 3,
			[Serialize("RLC_AdsType_IncubatorGoldElixir"  )] IncubatorGoldElixir = 4,
			[Serialize("RLC_AdsType_IncubatorSilverElixir")] IncubatorSilverElixir = 5,
			[Serialize("RLC_AdsType_Count"                )] Count = 6,
		}
		public enum RLC_EggType {
			[Serialize("RLC_EggType_Unknown"    )] Unknown = 0,
			[Serialize("RLC_EggType_DecoyBronze")] DecoyBronze = 1,
			[Serialize("RLC_EggType_DecoySilver")] DecoySilver = 2,
			[Serialize("RLC_EggType_DecoyGold"  )] DecoyGold = 3,
			[Serialize("RLC_EggType_Bronze"     )] Bronze = 4,
			[Serialize("RLC_EggType_Silver"     )] Silver = 5,
			[Serialize("RLC_EggType_Gold"       )] Gold = 6,
			[Serialize("RLC_EggType_Queen"      )] Queen = 7,
		}
	}
}

