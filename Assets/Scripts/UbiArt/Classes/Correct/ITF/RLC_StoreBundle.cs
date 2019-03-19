using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_StoreBundle : RLC_DynamicStoreItem {
		[Serialize("Price"               )] public float Price;
		[Serialize("formattedPrice"      )] public string formattedPrice;
		[Serialize("locId"               )] public uint locId;
		[Serialize("infoLocId"           )] public uint infoLocId;
		[Serialize("reduction"           )] public float reduction;
		[Serialize("gemspacks"           )] public CList<RLC_GemsPack> gemspacks;
		[Serialize("eastereggspacks"     )] public CList<RLC_EasterEggPack> eastereggspacks;
		[Serialize("costume"             )] public CList<RLC_ShopCostume> costume;
		[Serialize("elixirs"             )] public CList<RLC_ElixirPack> elixirs;
		[Serialize("luckytickets"        )] public CList<RLC_LuckyTicketPack> luckytickets;
		[Serialize("foodpack"            )] public CList<RLC_FoodPack> foodpack;
		[Serialize("beatboxSaveSlotPacks")] public CList<RLC_BeatboxSaveSlotPack> beatboxSaveSlotPacks;
		[Serialize("challengeTokenPacks" )] public CList<RLC_ChallengeTokenPack> challengeTokenPacks;
		[Serialize("mglassPacks"         )] public CList<RLC_MGlassPack> mglassPacks;
		[Serialize("timeSavingPack"      )] public RLC_TimeSavingPack timeSavingPack;
		[Serialize("perks"               )] public RLC_StorePacksPerksInfo perks;
		[Serialize("dynamicPackID"       )] public string dynamicPackID;
		[Serialize("productIdentifier"   )] public string productIdentifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(formattedPrice));
			SerializeField(s, nameof(locId));
			SerializeField(s, nameof(infoLocId));
			SerializeField(s, nameof(reduction));
			SerializeField(s, nameof(gemspacks));
			SerializeField(s, nameof(eastereggspacks));
			SerializeField(s, nameof(costume));
			SerializeField(s, nameof(elixirs));
			SerializeField(s, nameof(luckytickets));
			SerializeField(s, nameof(foodpack));
			SerializeField(s, nameof(beatboxSaveSlotPacks));
			SerializeField(s, nameof(challengeTokenPacks));
			SerializeField(s, nameof(mglassPacks));
			SerializeField(s, nameof(timeSavingPack));
			SerializeField(s, nameof(perks));
			SerializeField(s, nameof(dynamicPackID));
			SerializeField(s, nameof(productIdentifier));
		}

		public enum Type {
			[Serialize("XMASPACK")] XMASPACK = 1,
			[Serialize("TIMEELIXIRPACK")] TIMEELIXIRPACK = 2,
			[Serialize("LUCKYTICKETPACK")] LUCKYTICKETPACK = 3,
			[Serialize("ALCHEMISTPACK")] ALCHEMISTPACK = 4,
			[Serialize("FARCRYPACK")] FARCRYPACK = 5,
			[Serialize("CHINESENEWYEARPACK")] CHINESENEWYEARPACK = 6,
			[Serialize("ASSASSINPACK")] ASSASSINPACK = 7,
			[Serialize("SAINTPATRICKPACK")] SAINTPATRICKPACK = 8,
			[Serialize("DISCOPACK")] DISCOPACK = 9,
			[Serialize("CLANCYPACK")] CLANCYPACK = 10,
			[Serialize("UBISOFTMEGAPACK")] UBISOFTMEGAPACK = 11,
			[Serialize("COMFORTPACK")] COMFORTPACK = 12,
			[Serialize("DELUXECOMFORTPACK")] DELUXECOMFORTPACK = 13,
			[Serialize("REPEATERPACK")] REPEATERPACK = 14,
			[Serialize("CONVERTERPACK")] CONVERTERPACK = 15,
			[Serialize("NEWCREATUREPACK")] NEWCREATUREPACK = 16,
			[Serialize("SPYGLASSPACK")] SPYGLASSPACK = 17,
			[Serialize("DOJOPACK")] DOJOPACK = 18,
			[Serialize("JOPACK")] JOPACK = 19,
			[Serialize("DYNAMICPACK1")] DYNAMICPACK1 = 20,
			[Serialize("DYNAMICPACK2")] DYNAMICPACK2 = 21,
			[Serialize("DYNAMICPACK3")] DYNAMICPACK3 = 22,
			[Serialize("DYNAMICPACK4")] DYNAMICPACK4 = 23,
			[Serialize("DYNAMICPACK5")] DYNAMICPACK5 = 24,
			[Serialize("DYNAMICPACK6")] DYNAMICPACK6 = 25,
			[Serialize("NEWCREATUREPACKFAMILY")] NEWCREATUREPACKFAMILY = 26,
			[Serialize("ULTRACOMFORTPACK")] ULTRACOMFORTPACK = 27,
			[Serialize("NOSLEEPPACK")] NOSLEEPPACK = 28,
			[Serialize("MEGAMARATHONPACK")] MEGAMARATHONPACK = 29,
			[Serialize("REMOVEADSPACK")] REMOVEADSPACK = 30,
			[Serialize("MEGAHELLOWHEELPACK")] MEGAHELLOWHEELPACK = 31,
			[Serialize("MEGAHELLOWHEELDISCOUNTPACK")] MEGAHELLOWHEELDISCOUNTPACK = 32,
			[Serialize("WINTERHOLIDAYPACK")] WINTERHOLIDAYPACK = 33,
			[Serialize("DESERTMARATHONPACK")] DESERTMARATHONPACK = 34,
			[Serialize("DESERTMARATHONDISCOUNTPACK")] DESERTMARATHONDISCOUNTPACK = 35,
			[Serialize("THEELECTROPACK")] THEELECTROPACK = 36,
			[Serialize("THEELECTRODISCOUNTPACK")] THEELECTRODISCOUNTPACK = 37,
			[Serialize("GOLDENMARATHONPACK")] GOLDENMARATHONPACK = 38,
			[Serialize("GOLDENMARATHONDISCOUNTPACK")] GOLDENMARATHONDISCOUNTPACK = 39,
			[Serialize("ASSASSINRAYCOSTUMEPACK")] ASSASSINRAYCOSTUMEPACK = 40,
			[Serialize("SNOWBOXCOSTUMEPACK")] SNOWBOXCOSTUMEPACK = 41,
			[Serialize("URSULACOSTUMEPACK")] URSULACOSTUMEPACK = 42,
			[Serialize("RABBITEENCOSTUMEPACK")] RABBITEENCOSTUMEPACK = 43,
			[Serialize("STYLISHSWANKERPACK")] STYLISHSWANKERPACK = 44,
			[Serialize("INVALID")] INVALID = 45,
		}
		public override uint? ClassCRC => 0xFBDC6487;
	}
}

