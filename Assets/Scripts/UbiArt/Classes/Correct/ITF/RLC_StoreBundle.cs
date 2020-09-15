using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_StoreBundle : RLC_DynamicStoreItem {
		public float Price;
		public string formattedPrice;
		public uint locId_;
		public uint infoLocId;
		public float reduction;
		public CList<RLC_GemsPack> gemspacks;
		public CList<RLC_EasterEggPack> eastereggspacks;
		public CList<RLC_ShopCostume> costume;
		public CList<RLC_ElixirPack> elixirs;
		public CList<RLC_LuckyTicketPack> luckytickets;
		public CList<RLC_FoodPack> foodpack;
		public CList<RLC_BeatboxSaveSlotPack> beatboxSaveSlotPacks;
		public CList<RLC_ChallengeTokenPack> challengeTokenPacks;
		public CList<RLC_MGlassPack> mglassPacks;
		public RLC_TimeSavingPack timeSavingPack;
		public RLC_StorePacksPerksInfo perks;
		public string dynamicPackID;
		public string productIdentifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Price = s.Serialize<float>(Price, name: "Price");
			formattedPrice = s.Serialize<string>(formattedPrice, name: "formattedPrice");
			locId_ = s.Serialize<uint>(locId_, name: "locId_");
			infoLocId = s.Serialize<uint>(infoLocId, name: "infoLocId");
			reduction = s.Serialize<float>(reduction, name: "reduction");
			gemspacks = s.SerializeObject<CList<RLC_GemsPack>>(gemspacks, name: "gemspacks");
			eastereggspacks = s.SerializeObject<CList<RLC_EasterEggPack>>(eastereggspacks, name: "eastereggspacks");
			costume = s.SerializeObject<CList<RLC_ShopCostume>>(costume, name: "costume");
			elixirs = s.SerializeObject<CList<RLC_ElixirPack>>(elixirs, name: "elixirs");
			luckytickets = s.SerializeObject<CList<RLC_LuckyTicketPack>>(luckytickets, name: "luckytickets");
			foodpack = s.SerializeObject<CList<RLC_FoodPack>>(foodpack, name: "foodpack");
			beatboxSaveSlotPacks = s.SerializeObject<CList<RLC_BeatboxSaveSlotPack>>(beatboxSaveSlotPacks, name: "beatboxSaveSlotPacks");
			challengeTokenPacks = s.SerializeObject<CList<RLC_ChallengeTokenPack>>(challengeTokenPacks, name: "challengeTokenPacks");
			mglassPacks = s.SerializeObject<CList<RLC_MGlassPack>>(mglassPacks, name: "mglassPacks");
			timeSavingPack = s.SerializeObject<RLC_TimeSavingPack>(timeSavingPack, name: "timeSavingPack");
			perks = s.SerializeObject<RLC_StorePacksPerksInfo>(perks, name: "perks");
			dynamicPackID = s.Serialize<string>(dynamicPackID, name: "dynamicPackID");
			productIdentifier = s.Serialize<string>(productIdentifier, name: "productIdentifier");
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

