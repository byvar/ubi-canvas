using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AdventureManager_Template : TemplateObj {
		public CMap<StringID, Generic<RLC_Map>> maps;
		public CMap<StringID, RLC_Adventure> adventures;
		public CMap<PathRef, uint> deprecatedMaps;
		public CMap<PathRef, uint> deprecatedAdventures;
		public CMap<uint, RLC_MagnifyingGlass> MagnifyingGlassWeight;
		public uint bonusMapRandRangeMin;
		public uint bonusMapRandRangeMax;
		public uint challengeMapRandRangeMin;
		public uint challengeMapRandRangeMax;
		public bool challengeMapActive;
		public bool bonusMapActive;
		public bool queenMapActive;
		public CListP<uint> findCharlieFrequency;
		public uint findCharlieIntroduction;
		public float findCharlieSpawnChance;
		public float findCharlieTeaseDuration;
		public float findCharlieTeaseCountdownMin;
		public float findCharlieTeaseCountdownMax;
		public CArrayO<Generic<RLC_RegionGfxConfig>> RegionGfxConfig;
		public GFXPrimitiveParam defaultLineRootPrimitiveParam;
		public bool useNextRegionSelection;
		public bool nextRegionSelectionConfirmation;
		public bool blowOnceIfMultipleRegionsToReval;
		public float delayAfterBlowing;
		public float nextRegionTravelMarkDistMinOldMarks;
		public float nextRegionTravelMarkDistMinEggCages;
		public float nextRegionTravelMarkDistMinRegionName;
		public uint computeTravelMarkMaxTries;
		public bool checkTravelMarkInsideShape;
		public float travelMarkFlipChance;
		public float travelMarkRotatePiChance;
		public float travelMarkRotateAngleMaxDegree;
		public float travelMarkMinScaleX;
		public float travelMarkMaxScaleX;
		public float travelMarkMinScaleY;
		public float travelMarkMaxScaleY;
		public bool travelMarkMultiplyScaleXtoY;
		public bool travelMarksApplyRegionNameColor;
		public uint travelMarksNbMaxToDisplay;
		public CListP<uint> travelMarksNbMaxToDisplayByUnlockedRegionsNb;
		public uint travelMarksCountdownNbFade;
		public float travelMarksPctFade;
		public float travelMarksAlphaMax;
		public float nextRegionEggCageSpawnZ;
		public uint nextRegionEggCageForcedSpawningNb;
		public float nextRegionBoatSpawnZ;
		public float nextRegionBoatScale;
		public float nextRegionBoatShowDuration;
		public float nextRegionBoatSailingDuration;
		public float nextRegionBoatDisappearingDuration;
		public float nextRegionBoatSailingTangentSize;
		public bool eggCageAnimSpawnFallEachTime;
		public PathRef eggCageSelectionPath;
		public bool cameraShowsEggCageSpawning;
		public float cameraShowsEggCageSpawningDelay;
		public bool cameraShowsEggCageRevealing;
		public float cameraShowsEggCageRevealingDelay;
		public CListP<uint> nextRegionChoiceNb;
		public uint NextRegionRandom_NewRegionRevealedForcedEggCageSpawnNb;
		public float NextRegionRandomWeight_NewRegionRevealed;
		public float NextRegionRandomWeight_Default;
		public float NextRegionRandomWeight_LastAdventureRegion;
		public float NextRegionRandomWeight_ChosenMultiplier;
		public uint NextRegionEggSameRegionInARowCptToExcludeIt;
		public uint MagnifyingGlassAppearanceAdventureNb;
		public uint MagnifyingGlassTutorialForcedEggCageSpawnNb;
		public Path DragTutoHandPath;
		public Path DragTutoEggPath;
		public Path DragTutoCirclePath;
		public CMap<RLC_GraphicalFamily, Path> GraphicalFamilyTextLeftIcons;
		public CMap<RLC_GraphicalFamily, Path> GraphicalFamilyTextRightIcons;
		public PathRef TutoNewElixir3DPath;
		public Path TutoIconGemPath;
		public Path SmallTutoIconGemPath;
		public Path TutoIconMapPath;
		public Path TutoIconLevelPath;
		public Path TutoIconLevelLumsPath;
		public Path TutoIconLevelEnemyPath;
		public Path TutoIconLevelExploPath;
		public Path TutoIconLevelTimePath;
		public Path TutoIconTreePath;
		public Path TutoIconShopPath;
		public Path TutoIconFoodPath;
		public Path TutoIconMagnetPath;
		public Path TutoIconShieldPath;
		public Path TutoIconRadarPath;
		public Path TutoIconSandclockPath;
		public Path TutoIconGameCenterPath;
		public Path TutoIconGameServicesPath;
		public Path TutoIconGameCirclePath;
		public Path TutoIconPlayAppleTVPath;
		public CMap<string, Path> TutoIconsForPad;
		public CMap<string, string> TutoNextSteps;
		public Path TutoIconFacebookPath;
		public Path TutoIconFacebookSmallPath;
		public Path TutoIconSinaweiboPath;
		public Path TutoIconSinaWeiboSmallPath;
		public float TreeHandOnMapButtonAppearTimer;
		public float TreeHandOnMapButtonResetTimer;
		public CListO<RLC_EggVisualConfig> EggVisualConfigs;
		public CMap<RLC_GraphicalKit, string> EveryPlayMetaDataKits;
		public CMap<RLC_MapType, string> EveryPlayMetaDataMapTypes;
		public CMap<StringID, string> EveryPlayMetaDataCostumes;
		public StringID WwiseGUID_NextRegion_Medieval;
		public StringID WwiseGUID_NextRegion_ToadStory;
		public StringID WwiseGUID_NextRegion_Greece;
		public StringID WwiseGUID_NextRegion_UnderWater;
		public StringID WwiseGUID_NextRegion_Shaolin;
		public StringID WwiseGUID_NextRegion_LandOfTheDead;
		public StringID WwiseGUID_NextRegion_Desert;
		public Path BoatPath;
		public float BoatTeaseCountDownMin;
		public float BoatTeaseCountDownMax;
		public PathRef ForcedGreeceFirstLevelPathRef;
		public uint AdventureSequenceOnBoardingFinished;
		public StringID WwiseGUID_eggCageSpawningRtpc;
		public StringID eggCageSpawningRtpcMaxValue;
		public float nextRegionCameraSpeedToHideTelescopeButton;
		public bool nextRegionCameraDoubleTapZoomOutAllowed;
		public bool nextRegionCameraAutoZoomOutEndOfRitual;
		public bool nextRegionCameraEggSelectionForceZoomIn;
		public bool nextRegionCameraEggSelectionCancelledRestoreZoom;
		public bool nextRegionCameraTelescopeRestoreZoom;
		public float nextRegionCaptainAnimStandVariationTimerMin;
		public float nextRegionCaptainAnimStandVariationTimerMax;
		public bool pressCaptainToRevealTelescope;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maps = s.SerializeObject<CMap<StringID, Generic<RLC_Map>>>(maps, name: "maps");
			adventures = s.SerializeObject<CMap<StringID, RLC_Adventure>>(adventures, name: "adventures");
			deprecatedMaps = s.SerializeObject<CMap<PathRef, uint>>(deprecatedMaps, name: "deprecatedMaps");
			deprecatedAdventures = s.SerializeObject<CMap<PathRef, uint>>(deprecatedAdventures, name: "deprecatedAdventures");
			MagnifyingGlassWeight = s.SerializeObject<CMap<uint, RLC_MagnifyingGlass>>(MagnifyingGlassWeight, name: "MagnifyingGlassWeight");
			bonusMapRandRangeMin = s.Serialize<uint>(bonusMapRandRangeMin, name: "bonusMapRandRangeMin");
			bonusMapRandRangeMax = s.Serialize<uint>(bonusMapRandRangeMax, name: "bonusMapRandRangeMax");
			challengeMapRandRangeMin = s.Serialize<uint>(challengeMapRandRangeMin, name: "challengeMapRandRangeMin");
			challengeMapRandRangeMax = s.Serialize<uint>(challengeMapRandRangeMax, name: "challengeMapRandRangeMax");
			challengeMapActive = s.Serialize<bool>(challengeMapActive, name: "challengeMapActive");
			bonusMapActive = s.Serialize<bool>(bonusMapActive, name: "bonusMapActive");
			queenMapActive = s.Serialize<bool>(queenMapActive, name: "queenMapActive");
			findCharlieFrequency = s.SerializeObject<CListP<uint>>(findCharlieFrequency, name: "findCharlieFrequency");
			findCharlieIntroduction = s.Serialize<uint>(findCharlieIntroduction, name: "findCharlieIntroduction");
			findCharlieSpawnChance = s.Serialize<float>(findCharlieSpawnChance, name: "findCharlieSpawnChance");
			findCharlieTeaseDuration = s.Serialize<float>(findCharlieTeaseDuration, name: "findCharlieTeaseDuration");
			findCharlieTeaseCountdownMin = s.Serialize<float>(findCharlieTeaseCountdownMin, name: "findCharlieTeaseCountdownMin");
			findCharlieTeaseCountdownMax = s.Serialize<float>(findCharlieTeaseCountdownMax, name: "findCharlieTeaseCountdownMax");
			RegionGfxConfig = s.SerializeObject<CArrayO<Generic<RLC_RegionGfxConfig>>>(RegionGfxConfig, name: "RegionGfxConfig");
			defaultLineRootPrimitiveParam = s.SerializeObject<GFXPrimitiveParam>(defaultLineRootPrimitiveParam, name: "defaultLineRootPrimitiveParam");
			useNextRegionSelection = s.Serialize<bool>(useNextRegionSelection, name: "useNextRegionSelection");
			nextRegionSelectionConfirmation = s.Serialize<bool>(nextRegionSelectionConfirmation, name: "nextRegionSelectionConfirmation");
			blowOnceIfMultipleRegionsToReval = s.Serialize<bool>(blowOnceIfMultipleRegionsToReval, name: "blowOnceIfMultipleRegionsToReval");
			delayAfterBlowing = s.Serialize<float>(delayAfterBlowing, name: "delayAfterBlowing");
			nextRegionTravelMarkDistMinOldMarks = s.Serialize<float>(nextRegionTravelMarkDistMinOldMarks, name: "nextRegionTravelMarkDistMinOldMarks");
			nextRegionTravelMarkDistMinEggCages = s.Serialize<float>(nextRegionTravelMarkDistMinEggCages, name: "nextRegionTravelMarkDistMinEggCages");
			nextRegionTravelMarkDistMinRegionName = s.Serialize<float>(nextRegionTravelMarkDistMinRegionName, name: "nextRegionTravelMarkDistMinRegionName");
			computeTravelMarkMaxTries = s.Serialize<uint>(computeTravelMarkMaxTries, name: "computeTravelMarkMaxTries");
			checkTravelMarkInsideShape = s.Serialize<bool>(checkTravelMarkInsideShape, name: "checkTravelMarkInsideShape");
			travelMarkFlipChance = s.Serialize<float>(travelMarkFlipChance, name: "travelMarkFlipChance");
			travelMarkRotatePiChance = s.Serialize<float>(travelMarkRotatePiChance, name: "travelMarkRotatePiChance");
			travelMarkRotateAngleMaxDegree = s.Serialize<float>(travelMarkRotateAngleMaxDegree, name: "travelMarkRotateAngleMaxDegree");
			travelMarkMinScaleX = s.Serialize<float>(travelMarkMinScaleX, name: "travelMarkMinScaleX");
			travelMarkMaxScaleX = s.Serialize<float>(travelMarkMaxScaleX, name: "travelMarkMaxScaleX");
			travelMarkMinScaleY = s.Serialize<float>(travelMarkMinScaleY, name: "travelMarkMinScaleY");
			travelMarkMaxScaleY = s.Serialize<float>(travelMarkMaxScaleY, name: "travelMarkMaxScaleY");
			travelMarkMultiplyScaleXtoY = s.Serialize<bool>(travelMarkMultiplyScaleXtoY, name: "travelMarkMultiplyScaleXtoY");
			travelMarksApplyRegionNameColor = s.Serialize<bool>(travelMarksApplyRegionNameColor, name: "travelMarksApplyRegionNameColor");
			travelMarksNbMaxToDisplay = s.Serialize<uint>(travelMarksNbMaxToDisplay, name: "travelMarksNbMaxToDisplay");
			travelMarksNbMaxToDisplayByUnlockedRegionsNb = s.SerializeObject<CListP<uint>>(travelMarksNbMaxToDisplayByUnlockedRegionsNb, name: "travelMarksNbMaxToDisplayByUnlockedRegionsNb");
			travelMarksCountdownNbFade = s.Serialize<uint>(travelMarksCountdownNbFade, name: "travelMarksCountdownNbFade");
			travelMarksPctFade = s.Serialize<float>(travelMarksPctFade, name: "travelMarksPctFade");
			travelMarksAlphaMax = s.Serialize<float>(travelMarksAlphaMax, name: "travelMarksAlphaMax");
			nextRegionEggCageSpawnZ = s.Serialize<float>(nextRegionEggCageSpawnZ, name: "nextRegionEggCageSpawnZ");
			nextRegionEggCageForcedSpawningNb = s.Serialize<uint>(nextRegionEggCageForcedSpawningNb, name: "nextRegionEggCageForcedSpawningNb");
			nextRegionBoatSpawnZ = s.Serialize<float>(nextRegionBoatSpawnZ, name: "nextRegionBoatSpawnZ");
			nextRegionBoatScale = s.Serialize<float>(nextRegionBoatScale, name: "nextRegionBoatScale");
			nextRegionBoatShowDuration = s.Serialize<float>(nextRegionBoatShowDuration, name: "nextRegionBoatShowDuration");
			nextRegionBoatSailingDuration = s.Serialize<float>(nextRegionBoatSailingDuration, name: "nextRegionBoatSailingDuration");
			nextRegionBoatDisappearingDuration = s.Serialize<float>(nextRegionBoatDisappearingDuration, name: "nextRegionBoatDisappearingDuration");
			nextRegionBoatSailingTangentSize = s.Serialize<float>(nextRegionBoatSailingTangentSize, name: "nextRegionBoatSailingTangentSize");
			eggCageAnimSpawnFallEachTime = s.Serialize<bool>(eggCageAnimSpawnFallEachTime, name: "eggCageAnimSpawnFallEachTime");
			eggCageSelectionPath = s.SerializeObject<PathRef>(eggCageSelectionPath, name: "eggCageSelectionPath");
			cameraShowsEggCageSpawning = s.Serialize<bool>(cameraShowsEggCageSpawning, name: "cameraShowsEggCageSpawning");
			cameraShowsEggCageSpawningDelay = s.Serialize<float>(cameraShowsEggCageSpawningDelay, name: "cameraShowsEggCageSpawningDelay");
			cameraShowsEggCageRevealing = s.Serialize<bool>(cameraShowsEggCageRevealing, name: "cameraShowsEggCageRevealing");
			cameraShowsEggCageRevealingDelay = s.Serialize<float>(cameraShowsEggCageRevealingDelay, name: "cameraShowsEggCageRevealingDelay");
			nextRegionChoiceNb = s.SerializeObject<CListP<uint>>(nextRegionChoiceNb, name: "nextRegionChoiceNb");
			NextRegionRandom_NewRegionRevealedForcedEggCageSpawnNb = s.Serialize<uint>(NextRegionRandom_NewRegionRevealedForcedEggCageSpawnNb, name: "NextRegionRandom_NewRegionRevealedForcedEggCageSpawnNb");
			NextRegionRandomWeight_NewRegionRevealed = s.Serialize<float>(NextRegionRandomWeight_NewRegionRevealed, name: "NextRegionRandomWeight_NewRegionRevealed");
			NextRegionRandomWeight_Default = s.Serialize<float>(NextRegionRandomWeight_Default, name: "NextRegionRandomWeight_Default");
			NextRegionRandomWeight_LastAdventureRegion = s.Serialize<float>(NextRegionRandomWeight_LastAdventureRegion, name: "NextRegionRandomWeight_LastAdventureRegion");
			NextRegionRandomWeight_ChosenMultiplier = s.Serialize<float>(NextRegionRandomWeight_ChosenMultiplier, name: "NextRegionRandomWeight_ChosenMultiplier");
			NextRegionEggSameRegionInARowCptToExcludeIt = s.Serialize<uint>(NextRegionEggSameRegionInARowCptToExcludeIt, name: "NextRegionEggSameRegionInARowCptToExcludeIt");
			MagnifyingGlassAppearanceAdventureNb = s.Serialize<uint>(MagnifyingGlassAppearanceAdventureNb, name: "MagnifyingGlassAppearanceAdventureNb");
			MagnifyingGlassTutorialForcedEggCageSpawnNb = s.Serialize<uint>(MagnifyingGlassTutorialForcedEggCageSpawnNb, name: "MagnifyingGlassTutorialForcedEggCageSpawnNb");
			DragTutoHandPath = s.SerializeObject<Path>(DragTutoHandPath, name: "DragTutoHandPath");
			DragTutoEggPath = s.SerializeObject<Path>(DragTutoEggPath, name: "DragTutoEggPath");
			DragTutoCirclePath = s.SerializeObject<Path>(DragTutoCirclePath, name: "DragTutoCirclePath");
			GraphicalFamilyTextLeftIcons = s.SerializeObject<CMap<RLC_GraphicalFamily, Path>>(GraphicalFamilyTextLeftIcons, name: "GraphicalFamilyTextLeftIcons");
			GraphicalFamilyTextRightIcons = s.SerializeObject<CMap<RLC_GraphicalFamily, Path>>(GraphicalFamilyTextRightIcons, name: "GraphicalFamilyTextRightIcons");
			TutoNewElixir3DPath = s.SerializeObject<PathRef>(TutoNewElixir3DPath, name: "TutoNewElixir3DPath");
			TutoIconGemPath = s.SerializeObject<Path>(TutoIconGemPath, name: "TutoIconGemPath");
			SmallTutoIconGemPath = s.SerializeObject<Path>(SmallTutoIconGemPath, name: "SmallTutoIconGemPath");
			TutoIconMapPath = s.SerializeObject<Path>(TutoIconMapPath, name: "TutoIconMapPath");
			TutoIconLevelPath = s.SerializeObject<Path>(TutoIconLevelPath, name: "TutoIconLevelPath");
			TutoIconLevelLumsPath = s.SerializeObject<Path>(TutoIconLevelLumsPath, name: "TutoIconLevelLumsPath");
			TutoIconLevelEnemyPath = s.SerializeObject<Path>(TutoIconLevelEnemyPath, name: "TutoIconLevelEnemyPath");
			TutoIconLevelExploPath = s.SerializeObject<Path>(TutoIconLevelExploPath, name: "TutoIconLevelExploPath");
			TutoIconLevelTimePath = s.SerializeObject<Path>(TutoIconLevelTimePath, name: "TutoIconLevelTimePath");
			TutoIconTreePath = s.SerializeObject<Path>(TutoIconTreePath, name: "TutoIconTreePath");
			TutoIconShopPath = s.SerializeObject<Path>(TutoIconShopPath, name: "TutoIconShopPath");
			TutoIconFoodPath = s.SerializeObject<Path>(TutoIconFoodPath, name: "TutoIconFoodPath");
			TutoIconMagnetPath = s.SerializeObject<Path>(TutoIconMagnetPath, name: "TutoIconMagnetPath");
			TutoIconShieldPath = s.SerializeObject<Path>(TutoIconShieldPath, name: "TutoIconShieldPath");
			TutoIconRadarPath = s.SerializeObject<Path>(TutoIconRadarPath, name: "TutoIconRadarPath");
			TutoIconSandclockPath = s.SerializeObject<Path>(TutoIconSandclockPath, name: "TutoIconSandclockPath");
			TutoIconGameCenterPath = s.SerializeObject<Path>(TutoIconGameCenterPath, name: "TutoIconGameCenterPath");
			TutoIconGameServicesPath = s.SerializeObject<Path>(TutoIconGameServicesPath, name: "TutoIconGameServicesPath");
			TutoIconGameCirclePath = s.SerializeObject<Path>(TutoIconGameCirclePath, name: "TutoIconGameCirclePath");
			TutoIconPlayAppleTVPath = s.SerializeObject<Path>(TutoIconPlayAppleTVPath, name: "TutoIconPlayAppleTVPath");
			TutoIconsForPad = s.SerializeObject<CMap<string, Path>>(TutoIconsForPad, name: "TutoIconsForPad");
			TutoNextSteps = s.SerializeObject<CMap<string, string>>(TutoNextSteps, name: "TutoNextSteps");
			TutoIconFacebookPath = s.SerializeObject<Path>(TutoIconFacebookPath, name: "TutoIconFacebookPath");
			TutoIconFacebookSmallPath = s.SerializeObject<Path>(TutoIconFacebookSmallPath, name: "TutoIconFacebookSmallPath");
			TutoIconSinaweiboPath = s.SerializeObject<Path>(TutoIconSinaweiboPath, name: "TutoIconSinaweiboPath");
			TutoIconSinaWeiboSmallPath = s.SerializeObject<Path>(TutoIconSinaWeiboSmallPath, name: "TutoIconSinaWeiboSmallPath");
			TreeHandOnMapButtonAppearTimer = s.Serialize<float>(TreeHandOnMapButtonAppearTimer, name: "TreeHandOnMapButtonAppearTimer");
			TreeHandOnMapButtonResetTimer = s.Serialize<float>(TreeHandOnMapButtonResetTimer, name: "TreeHandOnMapButtonResetTimer");
			EggVisualConfigs = s.SerializeObject<CListO<RLC_EggVisualConfig>>(EggVisualConfigs, name: "EggVisualConfigs");
			EveryPlayMetaDataKits = s.SerializeObject<CMap<RLC_GraphicalKit, string>>(EveryPlayMetaDataKits, name: "EveryPlayMetaDataKits");
			EveryPlayMetaDataMapTypes = s.SerializeObject<CMap<RLC_MapType, string>>(EveryPlayMetaDataMapTypes, name: "EveryPlayMetaDataMapTypes");
			EveryPlayMetaDataCostumes = s.SerializeObject<CMap<StringID, string>>(EveryPlayMetaDataCostumes, name: "EveryPlayMetaDataCostumes");
			WwiseGUID_NextRegion_Medieval = s.SerializeObject<StringID>(WwiseGUID_NextRegion_Medieval, name: "WwiseGUID_NextRegion_Medieval");
			WwiseGUID_NextRegion_ToadStory = s.SerializeObject<StringID>(WwiseGUID_NextRegion_ToadStory, name: "WwiseGUID_NextRegion_ToadStory");
			WwiseGUID_NextRegion_Greece = s.SerializeObject<StringID>(WwiseGUID_NextRegion_Greece, name: "WwiseGUID_NextRegion_Greece");
			WwiseGUID_NextRegion_UnderWater = s.SerializeObject<StringID>(WwiseGUID_NextRegion_UnderWater, name: "WwiseGUID_NextRegion_UnderWater");
			WwiseGUID_NextRegion_Shaolin = s.SerializeObject<StringID>(WwiseGUID_NextRegion_Shaolin, name: "WwiseGUID_NextRegion_Shaolin");
			WwiseGUID_NextRegion_LandOfTheDead = s.SerializeObject<StringID>(WwiseGUID_NextRegion_LandOfTheDead, name: "WwiseGUID_NextRegion_LandOfTheDead");
			WwiseGUID_NextRegion_Desert = s.SerializeObject<StringID>(WwiseGUID_NextRegion_Desert, name: "WwiseGUID_NextRegion_Desert");
			BoatPath = s.SerializeObject<Path>(BoatPath, name: "BoatPath");
			BoatTeaseCountDownMin = s.Serialize<float>(BoatTeaseCountDownMin, name: "BoatTeaseCountDownMin");
			BoatTeaseCountDownMax = s.Serialize<float>(BoatTeaseCountDownMax, name: "BoatTeaseCountDownMax");
			ForcedGreeceFirstLevelPathRef = s.SerializeObject<PathRef>(ForcedGreeceFirstLevelPathRef, name: "ForcedGreeceFirstLevelPathRef");
			AdventureSequenceOnBoardingFinished = s.Serialize<uint>(AdventureSequenceOnBoardingFinished, name: "AdventureSequenceOnBoardingFinished");
			WwiseGUID_eggCageSpawningRtpc = s.SerializeObject<StringID>(WwiseGUID_eggCageSpawningRtpc, name: "WwiseGUID_eggCageSpawningRtpc");
			eggCageSpawningRtpcMaxValue = s.SerializeObject<StringID>(eggCageSpawningRtpcMaxValue, name: "eggCageSpawningRtpcMaxValue");
			nextRegionCameraSpeedToHideTelescopeButton = s.Serialize<float>(nextRegionCameraSpeedToHideTelescopeButton, name: "nextRegionCameraSpeedToHideTelescopeButton");
			nextRegionCameraDoubleTapZoomOutAllowed = s.Serialize<bool>(nextRegionCameraDoubleTapZoomOutAllowed, name: "nextRegionCameraDoubleTapZoomOutAllowed");
			nextRegionCameraAutoZoomOutEndOfRitual = s.Serialize<bool>(nextRegionCameraAutoZoomOutEndOfRitual, name: "nextRegionCameraAutoZoomOutEndOfRitual");
			nextRegionCameraEggSelectionForceZoomIn = s.Serialize<bool>(nextRegionCameraEggSelectionForceZoomIn, name: "nextRegionCameraEggSelectionForceZoomIn");
			nextRegionCameraEggSelectionCancelledRestoreZoom = s.Serialize<bool>(nextRegionCameraEggSelectionCancelledRestoreZoom, name: "nextRegionCameraEggSelectionCancelledRestoreZoom");
			nextRegionCameraTelescopeRestoreZoom = s.Serialize<bool>(nextRegionCameraTelescopeRestoreZoom, name: "nextRegionCameraTelescopeRestoreZoom");
			nextRegionCaptainAnimStandVariationTimerMin = s.Serialize<float>(nextRegionCaptainAnimStandVariationTimerMin, name: "nextRegionCaptainAnimStandVariationTimerMin");
			nextRegionCaptainAnimStandVariationTimerMax = s.Serialize<float>(nextRegionCaptainAnimStandVariationTimerMax, name: "nextRegionCaptainAnimStandVariationTimerMax");
			pressCaptainToRevealTelescope = s.Serialize<bool>(pressCaptainToRevealTelescope, name: "pressCaptainToRevealTelescope");
		}
		public override uint? ClassCRC => 0xFA1ACAA2;
	}
}

