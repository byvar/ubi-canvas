using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_InAppPurchaseManager_Template : TemplateObj {
		public RLC_ScoreRecapReward Reward_BronzeCup;
		public RLC_ScoreRecapReward Reward_SilverCup;
		public RLC_ScoreRecapReward Reward_GoldCup;
		public RLC_ScoreRecapReward Reward_BronzeCupHard;
		public RLC_ScoreRecapReward Reward_SilverCupHard;
		public RLC_ScoreRecapReward Reward_GoldCupHard;
		public RLC_ScoreRecapReward Reward_decoyBronzeDefault;
		public RLC_ScoreRecapReward Reward_decoySilverDefault;
		public RLC_ScoreRecapReward Reward_decoyGoldDefault;
		public RLC_ScoreRecapReward Reward_decoyIntro;
		public uint Price_OneFood;
		public uint Price_ChangeObjective;
		public uint Price_InstantPowerup;
		public uint Price_MagnifyingGlass;
		public uint SpeedRunAddTimePriceWithGems;
		public uint SpeedRunAddTimeTimeWithGems;
		public uint SpeedRunAddTimeTimeWithVideo;
		public uint Price_Elixir_CommonToUnco;
		public uint Price_Elixir_UncoToRare;
		public CList<RLC_ShopCostume> Shop_Costumes_Barbara;
		public CList<RLC_ShopCostume> Shop_Costumes_Globox;
		public CList<RLC_ShopCostume> Shop_Costumes_Rayman;
		public CList<RLC_ShopCostume> Shop_Costumes_Teensy;
		public Path IconRayman;
		public Path IconBarbara;
		public Path IconGlobox;
		public Path IconTeensy;
		public Path CostumeScrollingButton;
		public CList<RLC_ElixirType> ElixirTypesOrderedForShop;
		public PathRef LuckyTicketRewardSquare;
		public PathRef LuckyTicketRewardGems;
		public PathRef luckyTicketRewardEgg;
		public PathRef LuckyTicketRewardFood;
		public PathRef LuckyTicketRewardGoldenTicket;
		public PathRef LuckyTicketRewardElixir;
		public PathRef LuckyTicketRewardElixirX2;
		public PathRef LuckyTicketRewardElixirX3;
		public PathRef LuckyTicketRewardAllElixirPack;
		public PathRef LuckyTicketRewardMagnifyingGlass;
		public PathRef LuckyTicketRewardChallengeToken;
		public PathRef LuckyTicketRewardEasterEgg;
		public PathRef LuckyTicketRewardEasterEgg01;
		public PathRef LuckyTicketRewardEasterEgg02;
		public PathRef LuckyTicketRewardEasterEgg03;
		public PathRef LuckyTicketRewardEasterEgg04;
		public float LuckyTicketTileRevealPercent;
		public Path MenuLuckyTicketRewardDiskIcon;
		public PathRef duplicateGaugeBannerLeftPath;
		public PathRef duplicateGaugeBannerRightPath;
		public StringID WwiseGUID_ShopEnter;
		public StringID WwiseGUID_ShopExit;
		public online.TimeInterval StarterPackAvailabilityInterval;
		public online.TimeInterval StarterPackTimeBetweenForcedPopups;
		public CMap<RLC_StoreBundle.Type, RLC_StoreBundleUIData> StoreBundleUIData2;
		public uint RewardedVideoGemsNb;
		public uint RewardedVideoFoodNb;
		public uint RewardedVideoSeasonalCurrencyNb;
		public uint RewardedVideoChallengeTokenNb;
		public uint GemGiftAmountBeforeShop;
		public RLC_LuckyTicketReward SecondLuckyTicketReward;
		public uint NbNewElixirsGivenInDialog;
		public bool showCostumePricesOnButtons;
		public bool automaticPopupWhenUsingLastFoodInRunner;
		public bool automaticPopupWhenUsingLastFoodInTree;
		public bool automaticPopupWhenUsingLastSpeedElixir;
		public CMap<uint, RLC_LuckyTicketCategoryWeight> ticketCategoryWeightsSimple;
		public CMap<uint, RLC_LuckyTicketCategoryWeight> ticketCategoryWeightsGolden;
		public CMap<uint, RLC_LuckyTicketCategoryWeight> ticketCategoryWeightsChocolate;
		public CMap<uint, RLC_LuckyTicketRewardWeight> ticketNormalRewardWeightsSimple;
		public CMap<uint, RLC_LuckyTicketRewardWeight> ticketNormalRewardWeightsGolden;
		public CMap<uint, RLC_LuckyTicketRewardWeight> ticketNormalRewardWeightsChocolate;
		public CMap<uint, RLC_LuckyTicketRewardWeight> ticketJackpotRewardWeightsSimple;
		public CMap<uint, RLC_LuckyTicketRewardWeight> ticketJackpotRewardWeightsGolden;
		public CMap<uint, RLC_LuckyTicketRewardWeight> ticketJackpotRewardWeightsChocolate;
		public CMap<uint, RLC_CreatureRarityWeight> ticketEggRarityWeightsSimple;
		public CMap<uint, RLC_CreatureRarityWeight> ticketEggRarityWeightsGolden;
		public CMap<uint, RLC_CreatureRarityWeight> ticketEggRarityWeightsChocolate;
		public CMap<uint, RLC_LuckyTicketReward> DailyRewards;
		public uint DailyRewardFoodMaximumForSwitchToFood;
		public bool DailyRewardCanSwitchToFood;
		public CMap<uint, RLC_ShopCostumeVersion> PromotedCostumeVersions;
		public uint unlockShopAdventureSequence;
		public uint unlockShopCompletedMapsCount;
		public uint tutoShopAdventureSequence;
		public uint tutoShopCompletedMapsCount;
		public bool displayGloboxCostumes;
		public bool displayTeensyCostumes;
		public CMap<StringID, uint> iapScores;
		public bool allowScoreRecapVideoReward;
		public RLC_ScoreRecapReward Reward_ScoreRecapVideoDefault;
		public bool support_iOS8;
		public Path DynamicPackSlotItem;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Reward_BronzeCup = s.SerializeObject<RLC_ScoreRecapReward>(Reward_BronzeCup, name: "Reward_BronzeCup");
			Reward_SilverCup = s.SerializeObject<RLC_ScoreRecapReward>(Reward_SilverCup, name: "Reward_SilverCup");
			Reward_GoldCup = s.SerializeObject<RLC_ScoreRecapReward>(Reward_GoldCup, name: "Reward_GoldCup");
			Reward_BronzeCupHard = s.SerializeObject<RLC_ScoreRecapReward>(Reward_BronzeCupHard, name: "Reward_BronzeCupHard");
			Reward_SilverCupHard = s.SerializeObject<RLC_ScoreRecapReward>(Reward_SilverCupHard, name: "Reward_SilverCupHard");
			Reward_GoldCupHard = s.SerializeObject<RLC_ScoreRecapReward>(Reward_GoldCupHard, name: "Reward_GoldCupHard");
			Reward_decoyBronzeDefault = s.SerializeObject<RLC_ScoreRecapReward>(Reward_decoyBronzeDefault, name: "Reward_decoyBronzeDefault");
			Reward_decoySilverDefault = s.SerializeObject<RLC_ScoreRecapReward>(Reward_decoySilverDefault, name: "Reward_decoySilverDefault");
			Reward_decoyGoldDefault = s.SerializeObject<RLC_ScoreRecapReward>(Reward_decoyGoldDefault, name: "Reward_decoyGoldDefault");
			Reward_decoyIntro = s.SerializeObject<RLC_ScoreRecapReward>(Reward_decoyIntro, name: "Reward_decoyIntro");
			Price_OneFood = s.Serialize<uint>(Price_OneFood, name: "Price_OneFood");
			Price_ChangeObjective = s.Serialize<uint>(Price_ChangeObjective, name: "Price_ChangeObjective");
			Price_InstantPowerup = s.Serialize<uint>(Price_InstantPowerup, name: "Price_InstantPowerup");
			Price_MagnifyingGlass = s.Serialize<uint>(Price_MagnifyingGlass, name: "Price_MagnifyingGlass");
			SpeedRunAddTimePriceWithGems = s.Serialize<uint>(SpeedRunAddTimePriceWithGems, name: "SpeedRunAddTimePriceWithGems");
			SpeedRunAddTimeTimeWithGems = s.Serialize<uint>(SpeedRunAddTimeTimeWithGems, name: "SpeedRunAddTimeTimeWithGems");
			SpeedRunAddTimeTimeWithVideo = s.Serialize<uint>(SpeedRunAddTimeTimeWithVideo, name: "SpeedRunAddTimeTimeWithVideo");
			Price_Elixir_CommonToUnco = s.Serialize<uint>(Price_Elixir_CommonToUnco, name: "Price_Elixir_CommonToUnco");
			Price_Elixir_UncoToRare = s.Serialize<uint>(Price_Elixir_UncoToRare, name: "Price_Elixir_UncoToRare");
			Shop_Costumes_Barbara = s.SerializeObject<CList<RLC_ShopCostume>>(Shop_Costumes_Barbara, name: "Shop_Costumes_Barbara");
			Shop_Costumes_Globox = s.SerializeObject<CList<RLC_ShopCostume>>(Shop_Costumes_Globox, name: "Shop_Costumes_Globox");
			Shop_Costumes_Rayman = s.SerializeObject<CList<RLC_ShopCostume>>(Shop_Costumes_Rayman, name: "Shop_Costumes_Rayman");
			Shop_Costumes_Teensy = s.SerializeObject<CList<RLC_ShopCostume>>(Shop_Costumes_Teensy, name: "Shop_Costumes_Teensy");
			IconRayman = s.SerializeObject<Path>(IconRayman, name: "IconRayman");
			IconBarbara = s.SerializeObject<Path>(IconBarbara, name: "IconBarbara");
			IconGlobox = s.SerializeObject<Path>(IconGlobox, name: "IconGlobox");
			IconTeensy = s.SerializeObject<Path>(IconTeensy, name: "IconTeensy");
			CostumeScrollingButton = s.SerializeObject<Path>(CostumeScrollingButton, name: "CostumeScrollingButton");
			ElixirTypesOrderedForShop = s.SerializeObject<CList<RLC_ElixirType>>(ElixirTypesOrderedForShop, name: "ElixirTypesOrderedForShop");
			LuckyTicketRewardSquare = s.SerializeObject<PathRef>(LuckyTicketRewardSquare, name: "LuckyTicketRewardSquare");
			LuckyTicketRewardGems = s.SerializeObject<PathRef>(LuckyTicketRewardGems, name: "LuckyTicketRewardGems");
			luckyTicketRewardEgg = s.SerializeObject<PathRef>(luckyTicketRewardEgg, name: "luckyTicketRewardEgg");
			LuckyTicketRewardFood = s.SerializeObject<PathRef>(LuckyTicketRewardFood, name: "LuckyTicketRewardFood");
			LuckyTicketRewardGoldenTicket = s.SerializeObject<PathRef>(LuckyTicketRewardGoldenTicket, name: "LuckyTicketRewardGoldenTicket");
			LuckyTicketRewardElixir = s.SerializeObject<PathRef>(LuckyTicketRewardElixir, name: "LuckyTicketRewardElixir");
			LuckyTicketRewardElixirX2 = s.SerializeObject<PathRef>(LuckyTicketRewardElixirX2, name: "LuckyTicketRewardElixirX2");
			LuckyTicketRewardElixirX3 = s.SerializeObject<PathRef>(LuckyTicketRewardElixirX3, name: "LuckyTicketRewardElixirX3");
			LuckyTicketRewardAllElixirPack = s.SerializeObject<PathRef>(LuckyTicketRewardAllElixirPack, name: "LuckyTicketRewardAllElixirPack");
			LuckyTicketRewardMagnifyingGlass = s.SerializeObject<PathRef>(LuckyTicketRewardMagnifyingGlass, name: "LuckyTicketRewardMagnifyingGlass");
			LuckyTicketRewardChallengeToken = s.SerializeObject<PathRef>(LuckyTicketRewardChallengeToken, name: "LuckyTicketRewardChallengeToken");
			LuckyTicketRewardEasterEgg = s.SerializeObject<PathRef>(LuckyTicketRewardEasterEgg, name: "LuckyTicketRewardEasterEgg");
			LuckyTicketRewardEasterEgg01 = s.SerializeObject<PathRef>(LuckyTicketRewardEasterEgg01, name: "LuckyTicketRewardEasterEgg01");
			LuckyTicketRewardEasterEgg02 = s.SerializeObject<PathRef>(LuckyTicketRewardEasterEgg02, name: "LuckyTicketRewardEasterEgg02");
			LuckyTicketRewardEasterEgg03 = s.SerializeObject<PathRef>(LuckyTicketRewardEasterEgg03, name: "LuckyTicketRewardEasterEgg03");
			LuckyTicketRewardEasterEgg04 = s.SerializeObject<PathRef>(LuckyTicketRewardEasterEgg04, name: "LuckyTicketRewardEasterEgg04");
			LuckyTicketTileRevealPercent = s.Serialize<float>(LuckyTicketTileRevealPercent, name: "LuckyTicketTileRevealPercent");
			MenuLuckyTicketRewardDiskIcon = s.SerializeObject<Path>(MenuLuckyTicketRewardDiskIcon, name: "MenuLuckyTicketRewardDiskIcon");
			duplicateGaugeBannerLeftPath = s.SerializeObject<PathRef>(duplicateGaugeBannerLeftPath, name: "duplicateGaugeBannerLeftPath");
			duplicateGaugeBannerRightPath = s.SerializeObject<PathRef>(duplicateGaugeBannerRightPath, name: "duplicateGaugeBannerRightPath");
			WwiseGUID_ShopEnter = s.SerializeObject<StringID>(WwiseGUID_ShopEnter, name: "WwiseGUID_ShopEnter");
			WwiseGUID_ShopExit = s.SerializeObject<StringID>(WwiseGUID_ShopExit, name: "WwiseGUID_ShopExit");
			StarterPackAvailabilityInterval = s.SerializeObject<online.TimeInterval>(StarterPackAvailabilityInterval, name: "StarterPackAvailabilityInterval");
			StarterPackTimeBetweenForcedPopups = s.SerializeObject<online.TimeInterval>(StarterPackTimeBetweenForcedPopups, name: "StarterPackTimeBetweenForcedPopups");
			StoreBundleUIData2 = s.SerializeObject<CMap<RLC_StoreBundle.Type, RLC_StoreBundleUIData>>(StoreBundleUIData2, name: "StoreBundleUIData2");
			RewardedVideoGemsNb = s.Serialize<uint>(RewardedVideoGemsNb, name: "RewardedVideoGemsNb");
			RewardedVideoFoodNb = s.Serialize<uint>(RewardedVideoFoodNb, name: "RewardedVideoFoodNb");
			RewardedVideoSeasonalCurrencyNb = s.Serialize<uint>(RewardedVideoSeasonalCurrencyNb, name: "RewardedVideoSeasonalCurrencyNb");
			RewardedVideoChallengeTokenNb = s.Serialize<uint>(RewardedVideoChallengeTokenNb, name: "RewardedVideoChallengeTokenNb");
			GemGiftAmountBeforeShop = s.Serialize<uint>(GemGiftAmountBeforeShop, name: "GemGiftAmountBeforeShop");
			SecondLuckyTicketReward = s.SerializeObject<RLC_LuckyTicketReward>(SecondLuckyTicketReward, name: "SecondLuckyTicketReward");
			NbNewElixirsGivenInDialog = s.Serialize<uint>(NbNewElixirsGivenInDialog, name: "NbNewElixirsGivenInDialog");
			showCostumePricesOnButtons = s.Serialize<bool>(showCostumePricesOnButtons, name: "showCostumePricesOnButtons");
			automaticPopupWhenUsingLastFoodInRunner = s.Serialize<bool>(automaticPopupWhenUsingLastFoodInRunner, name: "automaticPopupWhenUsingLastFoodInRunner");
			automaticPopupWhenUsingLastFoodInTree = s.Serialize<bool>(automaticPopupWhenUsingLastFoodInTree, name: "automaticPopupWhenUsingLastFoodInTree");
			automaticPopupWhenUsingLastSpeedElixir = s.Serialize<bool>(automaticPopupWhenUsingLastSpeedElixir, name: "automaticPopupWhenUsingLastSpeedElixir");
			ticketCategoryWeightsSimple = s.SerializeObject<CMap<uint, RLC_LuckyTicketCategoryWeight>>(ticketCategoryWeightsSimple, name: "ticketCategoryWeightsSimple");
			ticketCategoryWeightsGolden = s.SerializeObject<CMap<uint, RLC_LuckyTicketCategoryWeight>>(ticketCategoryWeightsGolden, name: "ticketCategoryWeightsGolden");
			ticketCategoryWeightsChocolate = s.SerializeObject<CMap<uint, RLC_LuckyTicketCategoryWeight>>(ticketCategoryWeightsChocolate, name: "ticketCategoryWeightsChocolate");
			ticketNormalRewardWeightsSimple = s.SerializeObject<CMap<uint, RLC_LuckyTicketRewardWeight>>(ticketNormalRewardWeightsSimple, name: "ticketNormalRewardWeightsSimple");
			ticketNormalRewardWeightsGolden = s.SerializeObject<CMap<uint, RLC_LuckyTicketRewardWeight>>(ticketNormalRewardWeightsGolden, name: "ticketNormalRewardWeightsGolden");
			ticketNormalRewardWeightsChocolate = s.SerializeObject<CMap<uint, RLC_LuckyTicketRewardWeight>>(ticketNormalRewardWeightsChocolate, name: "ticketNormalRewardWeightsChocolate");
			ticketJackpotRewardWeightsSimple = s.SerializeObject<CMap<uint, RLC_LuckyTicketRewardWeight>>(ticketJackpotRewardWeightsSimple, name: "ticketJackpotRewardWeightsSimple");
			ticketJackpotRewardWeightsGolden = s.SerializeObject<CMap<uint, RLC_LuckyTicketRewardWeight>>(ticketJackpotRewardWeightsGolden, name: "ticketJackpotRewardWeightsGolden");
			ticketJackpotRewardWeightsChocolate = s.SerializeObject<CMap<uint, RLC_LuckyTicketRewardWeight>>(ticketJackpotRewardWeightsChocolate, name: "ticketJackpotRewardWeightsChocolate");
			ticketEggRarityWeightsSimple = s.SerializeObject<CMap<uint, RLC_CreatureRarityWeight>>(ticketEggRarityWeightsSimple, name: "ticketEggRarityWeightsSimple");
			ticketEggRarityWeightsGolden = s.SerializeObject<CMap<uint, RLC_CreatureRarityWeight>>(ticketEggRarityWeightsGolden, name: "ticketEggRarityWeightsGolden");
			ticketEggRarityWeightsChocolate = s.SerializeObject<CMap<uint, RLC_CreatureRarityWeight>>(ticketEggRarityWeightsChocolate, name: "ticketEggRarityWeightsChocolate");
			DailyRewards = s.SerializeObject<CMap<uint, RLC_LuckyTicketReward>>(DailyRewards, name: "DailyRewards");
			DailyRewardFoodMaximumForSwitchToFood = s.Serialize<uint>(DailyRewardFoodMaximumForSwitchToFood, name: "DailyRewardFoodMaximumForSwitchToFood");
			DailyRewardCanSwitchToFood = s.Serialize<bool>(DailyRewardCanSwitchToFood, name: "DailyRewardCanSwitchToFood");
			PromotedCostumeVersions = s.SerializeObject<CMap<uint, RLC_ShopCostumeVersion>>(PromotedCostumeVersions, name: "PromotedCostumeVersions");
			unlockShopAdventureSequence = s.Serialize<uint>(unlockShopAdventureSequence, name: "unlockShopAdventureSequence");
			unlockShopCompletedMapsCount = s.Serialize<uint>(unlockShopCompletedMapsCount, name: "unlockShopCompletedMapsCount");
			tutoShopAdventureSequence = s.Serialize<uint>(tutoShopAdventureSequence, name: "tutoShopAdventureSequence");
			tutoShopCompletedMapsCount = s.Serialize<uint>(tutoShopCompletedMapsCount, name: "tutoShopCompletedMapsCount");
			displayGloboxCostumes = s.Serialize<bool>(displayGloboxCostumes, name: "displayGloboxCostumes");
			displayTeensyCostumes = s.Serialize<bool>(displayTeensyCostumes, name: "displayTeensyCostumes");
			iapScores = s.SerializeObject<CMap<StringID, uint>>(iapScores, name: "iapScores");
			allowScoreRecapVideoReward = s.Serialize<bool>(allowScoreRecapVideoReward, name: "allowScoreRecapVideoReward");
			Reward_ScoreRecapVideoDefault = s.SerializeObject<RLC_ScoreRecapReward>(Reward_ScoreRecapVideoDefault, name: "Reward_ScoreRecapVideoDefault");
			support_iOS8 = s.Serialize<bool>(support_iOS8, name: "support_iOS8");
			DynamicPackSlotItem = s.SerializeObject<Path>(DynamicPackSlotItem, name: "DynamicPackSlotItem");
		}
		public override uint? ClassCRC => 0xB0808422;
	}
}

