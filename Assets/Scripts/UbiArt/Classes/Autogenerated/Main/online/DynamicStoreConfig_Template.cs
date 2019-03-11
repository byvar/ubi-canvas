using UnityEngine;

namespace UbiArt.online {
	public partial class DynamicStoreConfig_Template : ITF.TemplateObj {
		[Serialize("StarterGemCounter"                )] public uint StarterGemCounter;
		[Serialize("StarterFoodCount"                 )] public uint StarterFoodCount;
		[Serialize("StarterElixirSpeedHatchingCount"  )] public uint StarterElixirSpeedHatchingCount;
		[Serialize("StarterElixirGoldCount"           )] public uint StarterElixirGoldCount;
		[Serialize("StarterElixirSilverCount"         )] public uint StarterElixirSilverCount;
		[Serialize("StarterElixirNewCreatureCount"    )] public uint StarterElixirNewCreatureCount;
		[Serialize("StarterBeatboxSlotCount"          )] public uint StarterBeatboxSlotCount;
		[Serialize("StarterMGlassCount"               )] public uint StarterMGlassCount;
		[Serialize("IAPTierFromDeviceCountry"         )] public uint IAPTierFromDeviceCountry;
		[Serialize("storeTradesOverride"              )] public CMap<uint, StoreItemSettings> storeTradesOverride;
		[Serialize("storePrimaryOverride"             )] public CMap<uint, PrimaryItemSettings> storePrimaryOverride;
		[Serialize("forcedIAPTier"                    )] public uint forcedIAPTier;
		[Serialize("forcedReductionActive"            )] public uint forcedReductionActive;
		[Serialize("forcedReductionRatio"             )] public float forcedReductionRatio;
		[Serialize("KEY"                              )] public uint KEY;
		[Serialize("timeSavingPackTimes"              )] public CArray<uint> timeSavingPackTimes;
		[Serialize("maxNewEggIAPPerSave"              )] public uint maxNewEggIAPPerSave;
		[Serialize("AdventureTimeRegion_Default"      )] public uint AdventureTimeRegion_Default;
		[Serialize("AdventureTimeRegion_Medieval"     )] public uint AdventureTimeRegion_Medieval;
		[Serialize("AdventureTimeRegion_ToadStory"    )] public uint AdventureTimeRegion_ToadStory;
		[Serialize("AdventureTimeRegion_Greece"       )] public uint AdventureTimeRegion_Greece;
		[Serialize("AdventureTimeRegion_UnderWater"   )] public uint AdventureTimeRegion_UnderWater;
		[Serialize("AdventureTimeRegion_Shaolin"      )] public uint AdventureTimeRegion_Shaolin;
		[Serialize("AdventureTimeRegion_LandOfTheDead")] public uint AdventureTimeRegion_LandOfTheDead;
		[Serialize("AdventureTimeRegion_Desert"       )] public uint AdventureTimeRegion_Desert;
		[Serialize("CreatureExhaustOnLevelEnd"        )] public uint CreatureExhaustOnLevelEnd;
		[Serialize("UseFoodRefilling"                 )] public uint UseFoodRefilling;
		[Serialize("FoodRefillTimeInSeconds"          )] public uint FoodRefillTimeInSeconds;
		[Serialize("FoodRefillCapAmount"              )] public uint FoodRefillCapAmount;
		[Serialize("LevelPlayFoodAmount"              )] public uint LevelPlayFoodAmount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StarterGemCounter));
			SerializeField(s, nameof(StarterFoodCount));
			SerializeField(s, nameof(StarterElixirSpeedHatchingCount));
			SerializeField(s, nameof(StarterElixirGoldCount));
			SerializeField(s, nameof(StarterElixirSilverCount));
			SerializeField(s, nameof(StarterElixirNewCreatureCount));
			SerializeField(s, nameof(StarterBeatboxSlotCount));
			SerializeField(s, nameof(StarterMGlassCount));
			SerializeField(s, nameof(IAPTierFromDeviceCountry));
			SerializeField(s, nameof(storeTradesOverride));
			SerializeField(s, nameof(storePrimaryOverride));
			SerializeField(s, nameof(forcedIAPTier));
			SerializeField(s, nameof(forcedReductionActive));
			SerializeField(s, nameof(forcedReductionRatio));
			SerializeField(s, nameof(KEY));
			SerializeField(s, nameof(timeSavingPackTimes));
			SerializeField(s, nameof(maxNewEggIAPPerSave));
			SerializeField(s, nameof(AdventureTimeRegion_Default));
			SerializeField(s, nameof(AdventureTimeRegion_Medieval));
			SerializeField(s, nameof(AdventureTimeRegion_ToadStory));
			SerializeField(s, nameof(AdventureTimeRegion_Greece));
			SerializeField(s, nameof(AdventureTimeRegion_UnderWater));
			SerializeField(s, nameof(AdventureTimeRegion_Shaolin));
			SerializeField(s, nameof(AdventureTimeRegion_LandOfTheDead));
			SerializeField(s, nameof(AdventureTimeRegion_Desert));
			SerializeField(s, nameof(CreatureExhaustOnLevelEnd));
			SerializeField(s, nameof(UseFoodRefilling));
			SerializeField(s, nameof(FoodRefillTimeInSeconds));
			SerializeField(s, nameof(FoodRefillCapAmount));
			SerializeField(s, nameof(LevelPlayFoodAmount));
		}
		public override uint? ClassCRC => 0x760ED863;
	}
}

