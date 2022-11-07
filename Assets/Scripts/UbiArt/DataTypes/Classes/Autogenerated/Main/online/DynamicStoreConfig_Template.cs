namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class DynamicStoreConfig_Template : ITF.TemplateObj {
		public uint StarterGemCounter;
		public uint StarterFoodCount;
		public uint StarterElixirSpeedHatchingCount;
		public uint StarterElixirGoldCount;
		public uint StarterElixirSilverCount;
		public uint StarterElixirNewCreatureCount;
		public uint StarterBeatboxSlotCount;
		public uint StarterMGlassCount;
		public uint IAPTierFromDeviceCountry;
		public CMap<uint, StoreItemSettings> storeTradesOverride;
		public CMap<uint, PrimaryItemSettings> storePrimaryOverride;
		public uint forcedIAPTier;
		public uint forcedReductionActive;
		public float forcedReductionRatio;
		public CMap<uint, uint> timeSavingPackTimes;
		public uint maxNewEggIAPPerSave;
		public uint AdventureTimeRegion_Default;
		public uint AdventureTimeRegion_Medieval;
		public uint AdventureTimeRegion_ToadStory;
		public uint AdventureTimeRegion_Greece;
		public uint AdventureTimeRegion_UnderWater;
		public uint AdventureTimeRegion_Shaolin;
		public uint AdventureTimeRegion_LandOfTheDead;
		public uint AdventureTimeRegion_Desert;
		public uint CreatureExhaustOnLevelEnd;
		public uint UseFoodRefilling;
		public uint FoodRefillTimeInSeconds;
		public uint FoodRefillCapAmount;
		public uint LevelPlayFoodAmount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StarterGemCounter = s.Serialize<uint>(StarterGemCounter, name: "StarterGemCounter");
			StarterFoodCount = s.Serialize<uint>(StarterFoodCount, name: "StarterFoodCount");
			StarterElixirSpeedHatchingCount = s.Serialize<uint>(StarterElixirSpeedHatchingCount, name: "StarterElixirSpeedHatchingCount");
			StarterElixirGoldCount = s.Serialize<uint>(StarterElixirGoldCount, name: "StarterElixirGoldCount");
			StarterElixirSilverCount = s.Serialize<uint>(StarterElixirSilverCount, name: "StarterElixirSilverCount");
			StarterElixirNewCreatureCount = s.Serialize<uint>(StarterElixirNewCreatureCount, name: "StarterElixirNewCreatureCount");
			StarterBeatboxSlotCount = s.Serialize<uint>(StarterBeatboxSlotCount, name: "StarterBeatboxSlotCount");
			StarterMGlassCount = s.Serialize<uint>(StarterMGlassCount, name: "StarterMGlassCount");
			IAPTierFromDeviceCountry = s.Serialize<uint>(IAPTierFromDeviceCountry, name: "IAPTierFromDeviceCountry");
			storeTradesOverride = s.SerializeObject<CMap<uint, StoreItemSettings>>(storeTradesOverride, name: "storeTradesOverride");
			storePrimaryOverride = s.SerializeObject<CMap<uint, PrimaryItemSettings>>(storePrimaryOverride, name: "storePrimaryOverride");
			forcedIAPTier = s.Serialize<uint>(forcedIAPTier, name: "forcedIAPTier");
			forcedReductionActive = s.Serialize<uint>(forcedReductionActive, name: "forcedReductionActive");
			forcedReductionRatio = s.Serialize<float>(forcedReductionRatio, name: "forcedReductionRatio");
			timeSavingPackTimes = s.SerializeObject<CMap<uint, uint>>(timeSavingPackTimes, name: "timeSavingPackTimes");
			maxNewEggIAPPerSave = s.Serialize<uint>(maxNewEggIAPPerSave, name: "maxNewEggIAPPerSave");
			AdventureTimeRegion_Default = s.Serialize<uint>(AdventureTimeRegion_Default, name: "AdventureTimeRegion_Default");
			AdventureTimeRegion_Medieval = s.Serialize<uint>(AdventureTimeRegion_Medieval, name: "AdventureTimeRegion_Medieval");
			AdventureTimeRegion_ToadStory = s.Serialize<uint>(AdventureTimeRegion_ToadStory, name: "AdventureTimeRegion_ToadStory");
			AdventureTimeRegion_Greece = s.Serialize<uint>(AdventureTimeRegion_Greece, name: "AdventureTimeRegion_Greece");
			AdventureTimeRegion_UnderWater = s.Serialize<uint>(AdventureTimeRegion_UnderWater, name: "AdventureTimeRegion_UnderWater");
			AdventureTimeRegion_Shaolin = s.Serialize<uint>(AdventureTimeRegion_Shaolin, name: "AdventureTimeRegion_Shaolin");
			AdventureTimeRegion_LandOfTheDead = s.Serialize<uint>(AdventureTimeRegion_LandOfTheDead, name: "AdventureTimeRegion_LandOfTheDead");
			AdventureTimeRegion_Desert = s.Serialize<uint>(AdventureTimeRegion_Desert, name: "AdventureTimeRegion_Desert");
			CreatureExhaustOnLevelEnd = s.Serialize<uint>(CreatureExhaustOnLevelEnd, name: "CreatureExhaustOnLevelEnd");
			UseFoodRefilling = s.Serialize<uint>(UseFoodRefilling, name: "UseFoodRefilling");
			FoodRefillTimeInSeconds = s.Serialize<uint>(FoodRefillTimeInSeconds, name: "FoodRefillTimeInSeconds");
			FoodRefillCapAmount = s.Serialize<uint>(FoodRefillCapAmount, name: "FoodRefillCapAmount");
			LevelPlayFoodAmount = s.Serialize<uint>(LevelPlayFoodAmount, name: "LevelPlayFoodAmount");
		}
		public override uint? ClassCRC => 0x760ED863;
	}
}

