using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class adsCampaign : CSerializable {
		[Serialize("name"               )] public string name;
		[Serialize("adlocation"         )] public RLC_AdsType adlocation;
		[Serialize("showOnceInXHours"   )] public uint showOnceInXHours;
		[Serialize("notShownAdsInXHours")] public uint notShownAdsInXHours;
		[Serialize("notShownAdsInXDays" )] public uint notShownAdsInXDays;
		[Serialize("totalSpendsMin"     )] public uint totalSpendsMin;
		[Serialize("totalSpendsMax"     )] public uint totalSpendsMax;
		[Serialize("adventureMin"       )] public uint adventureMin;
		[Serialize("adventureMax"       )] public uint adventureMax;
		[Serialize("gemsMin"            )] public uint gemsMin;
		[Serialize("gemsMax"            )] public uint gemsMax;
		[Serialize("activeDaysMin"      )] public uint activeDaysMin;
		[Serialize("activeDaysMax"      )] public uint activeDaysMax;
		[Serialize("spyglassMin"        )] public uint spyglassMin;
		[Serialize("spyglassMax"        )] public uint spyglassMax;
		[Serialize("starsCount"         )] public uint starsCount;
		[Serialize("eggType"            )] public RLC_EggType eggType;
		[Serialize("levelType"          )] public ITF.RLC_MapType levelType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(adlocation));
			SerializeField(s, nameof(showOnceInXHours));
			SerializeField(s, nameof(notShownAdsInXHours));
			SerializeField(s, nameof(notShownAdsInXDays));
			SerializeField(s, nameof(totalSpendsMin));
			SerializeField(s, nameof(totalSpendsMax));
			SerializeField(s, nameof(adventureMin));
			SerializeField(s, nameof(adventureMax));
			SerializeField(s, nameof(gemsMin));
			SerializeField(s, nameof(gemsMax));
			SerializeField(s, nameof(activeDaysMin));
			SerializeField(s, nameof(activeDaysMax));
			SerializeField(s, nameof(spyglassMin));
			SerializeField(s, nameof(spyglassMax));
			SerializeField(s, nameof(starsCount));
			SerializeField(s, nameof(eggType));
			SerializeField(s, nameof(levelType));
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

