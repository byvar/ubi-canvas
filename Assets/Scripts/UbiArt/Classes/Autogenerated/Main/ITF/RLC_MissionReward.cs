using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MissionReward : CSerializable {
		[Serialize("rewardType" )] public Enum_rewardType rewardType;
		[Serialize("rewardCount")] public uint rewardCount;
		[Serialize("rewardName" )] public StringID rewardName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rewardType));
			SerializeField(s, nameof(rewardCount));
			SerializeField(s, nameof(rewardName));
		}
		public enum Enum_rewardType {
			[Serialize("_unknown"             )] _unknown = 0,
			[Serialize("Gems"                 )] Gems = 1,
			[Serialize("Costume"              )] Costume = 2,
			[Serialize("LuckyTicket"          )] LuckyTicket = 3,
			[Serialize("GoldenTicket"         )] GoldenTicket = 4,
			[Serialize("Region"               )] Region = 5,
			[Serialize("Family"               )] Family = 6,
			[Serialize("HunterLevel"          )] HunterLevel = 7,
			[Serialize("Food"                 )] Food = 8,
			[Serialize("Egg"                  )] Egg = 9,
			[Serialize("Elixirs"              )] Elixirs = 10,
			[Serialize("AllElixirPack"        )] AllElixirPack = 11,
			[Serialize("TwoElixirs"           )] TwoElixirs = 12,
			[Serialize("ThreeElixirs"         )] ThreeElixirs = 13,
			[Serialize("BeatboxSaveSlots"     )] BeatboxSaveSlots = 14,
			[Serialize("CreatureFamilyEvent"  )] CreatureFamilyEvent = 15,
			[Serialize("SeasonalCurrency"     )] SeasonalCurrency = 16,
			[Serialize("SeasonalTicket"       )] SeasonalTicket = 17,
			[Serialize("SeasonalEgg"          )] SeasonalEgg = 18,
			[Serialize("MagnifyingGlass"      )] MagnifyingGlass = 19,
			[Serialize("DecoyEggBronze"       )] DecoyEggBronze = 20,
			[Serialize("DecoyEggSilver"       )] DecoyEggSilver = 21,
			[Serialize("DecoyEggGold"         )] DecoyEggGold = 22,
			[Serialize("DecoyEggQueen"        )] DecoyEggQueen = 23,
			[Serialize("ScoreRecapVideo"      )] ScoreRecapVideo = 24,
			[Serialize("CreatureFamilyEndless")] CreatureFamilyEndless = 25,
			[Serialize("ChallengeToken"       )] ChallengeToken = 26,
			[Serialize("ChallengeTicket"      )] ChallengeTicket = 27,
			[Serialize("ChallengeReward"      )] ChallengeReward = 28,
			[Serialize("SeasonalCurrency01"   )] SeasonalCurrency01 = 29,
			[Serialize("SeasonalCurrency02"   )] SeasonalCurrency02 = 30,
			[Serialize("SeasonalCurrency03"   )] SeasonalCurrency03 = 31,
			[Serialize("SeasonalCurrency04"   )] SeasonalCurrency04 = 32,
		}
		public override uint? ClassCRC => 0x42A88E7E;
	}
}

