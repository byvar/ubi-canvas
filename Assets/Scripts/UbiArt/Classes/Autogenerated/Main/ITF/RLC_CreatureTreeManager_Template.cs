using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreatureTreeManager_Template : TemplateObj {
		public CListO<RLC_CreatureTreeTier> TreeTierList;
		public float TreeTopShapeOffset;
		public Path TreeTopPath;
		public Path TreePatchPath;
		public Path HouseCrownPath;
		public Path TreeSignPath;
		public Path FamilySignPath;
		public Path FamilySignMediumPath;
		public Path FamilySignLargePath;
		public Path FamilyInfobuttonPath;
		public Path FamilyPowerupIconPath;
		public Vec3d FamilyInfobuttonOffsetSmallPannel;
		public Vec3d FamilyInfobuttonOffsetMediumPannel;
		public Vec3d FamilyInfobuttonOffsetBigPannel;
		public Vec3d FamilyPowerupIconOffsetSmallPannel;
		public Vec3d FamilyPowerupIconOffsetMediumPannel;
		public Vec3d FamilyPowerupIconOffsetBigPannel;
		public Path EnergyBallPath;
		public Path FlowerPowerPath;
		public Path EnergyBallUncoPath;
		public Path FlowerPowerUncoPath;
		public Path EnergyBallRarePath;
		public Path FlowerPowerRarePath;
		public Path EnergyBallQueenPath;
		public Path FlowerPowerQueenPath;
		public Path GemPath;
		public Path RegionPath;
		public Path CostumePath;
		public float Ritual_SpeedCamera;
		public float Ritual_DelaiShakeBeforeGrowth;
		public float Ritual_DelaiBeforeLaunchRitual;
		public Vec3d Ritual_RewardCreatureOffset;
		public Vec3d Ritual_CreatureOnTopOfTheTreeOffset;
		public Vec3d Ritual_CreatureBeforeRitual;
		public float Ritual_RitualTimeCelebration;
		public float Ritual_DelaiRewardPopupisDisplayed;
		public float StarStepInMeters;
		public uint StarNeededToGrowBranches;
		public uint SmallHouseMaxMember;
		public CMap<int, RLC_TreeRewardList> RewardsList;
		public CListP<uint> LevelXPList;
		public CListO<Path> PropsTrunkMidList;
		public CListO<Path> PropsTrunkBorderList;
		public uint XPSpeed;
		public uint XPMultiplier;
		public float GrabCreatureTouchDuration;
		public float LaunchCreatureMaxSpeed;
		public float TreeTrunckScale;
		public float OffsetByFamilly;
		public PathRef BeatboxTutoIconStart;
		public PathRef BeatboxTutoIconStop;
		public PathRef BeatboxTutoIconSave;
		public StringID WwiseGUID_StartFocus;
		public StringID WwiseGUID_StopFocus;
		public float PreloadDistance;
		public float LoadDistance;
		public Path FX_LeaveCommon;
		public Path FX_LeaveUncommon;
		public Path FX_LeaveRare;
		public Path FX_LeaveQueen;
		public Path FX_LeaveDeath;
		public CListO<RLC_TreeOptimGraph> TreeOptimGraphList;
		public Path FXGiftPath;
		public Path FXGiftRegionPath;
		public Path FXGiftCostumePath;
		public Path FXLevelPath;
		public Path FXLevelExploPath;
		public Path BeatBoxTapFxPath;
		public bool BeatBoxRecDefault;
		public bool BeatBoxDisplayUI;
		public float BeatBoxRecLengthFactor;
		public CMap<string, string> BeatBoxTutoNextSteps;
		public uint BeatboxTutoNbCreaturesToUnlock;
		public uint BeatboxTutoNbCreaturesForReminder;
		public uint TutoLeaderboardMinAdventure;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TreeTierList = s.SerializeObject<CListO<RLC_CreatureTreeTier>>(TreeTierList, name: "TreeTierList");
			TreeTopShapeOffset = s.Serialize<float>(TreeTopShapeOffset, name: "TreeTopShapeOffset");
			TreeTopPath = s.SerializeObject<Path>(TreeTopPath, name: "TreeTopPath");
			TreePatchPath = s.SerializeObject<Path>(TreePatchPath, name: "TreePatchPath");
			HouseCrownPath = s.SerializeObject<Path>(HouseCrownPath, name: "HouseCrownPath");
			TreeSignPath = s.SerializeObject<Path>(TreeSignPath, name: "TreeSignPath");
			FamilySignPath = s.SerializeObject<Path>(FamilySignPath, name: "FamilySignPath");
			FamilySignMediumPath = s.SerializeObject<Path>(FamilySignMediumPath, name: "FamilySignMediumPath");
			FamilySignLargePath = s.SerializeObject<Path>(FamilySignLargePath, name: "FamilySignLargePath");
			FamilyInfobuttonPath = s.SerializeObject<Path>(FamilyInfobuttonPath, name: "FamilyInfobuttonPath");
			FamilyPowerupIconPath = s.SerializeObject<Path>(FamilyPowerupIconPath, name: "FamilyPowerupIconPath");
			FamilyInfobuttonOffsetSmallPannel = s.SerializeObject<Vec3d>(FamilyInfobuttonOffsetSmallPannel, name: "FamilyInfobuttonOffsetSmallPannel");
			FamilyInfobuttonOffsetMediumPannel = s.SerializeObject<Vec3d>(FamilyInfobuttonOffsetMediumPannel, name: "FamilyInfobuttonOffsetMediumPannel");
			FamilyInfobuttonOffsetBigPannel = s.SerializeObject<Vec3d>(FamilyInfobuttonOffsetBigPannel, name: "FamilyInfobuttonOffsetBigPannel");
			FamilyPowerupIconOffsetSmallPannel = s.SerializeObject<Vec3d>(FamilyPowerupIconOffsetSmallPannel, name: "FamilyPowerupIconOffsetSmallPannel");
			FamilyPowerupIconOffsetMediumPannel = s.SerializeObject<Vec3d>(FamilyPowerupIconOffsetMediumPannel, name: "FamilyPowerupIconOffsetMediumPannel");
			FamilyPowerupIconOffsetBigPannel = s.SerializeObject<Vec3d>(FamilyPowerupIconOffsetBigPannel, name: "FamilyPowerupIconOffsetBigPannel");
			EnergyBallPath = s.SerializeObject<Path>(EnergyBallPath, name: "EnergyBallPath");
			FlowerPowerPath = s.SerializeObject<Path>(FlowerPowerPath, name: "FlowerPowerPath");
			EnergyBallUncoPath = s.SerializeObject<Path>(EnergyBallUncoPath, name: "EnergyBallUncoPath");
			FlowerPowerUncoPath = s.SerializeObject<Path>(FlowerPowerUncoPath, name: "FlowerPowerUncoPath");
			EnergyBallRarePath = s.SerializeObject<Path>(EnergyBallRarePath, name: "EnergyBallRarePath");
			FlowerPowerRarePath = s.SerializeObject<Path>(FlowerPowerRarePath, name: "FlowerPowerRarePath");
			EnergyBallQueenPath = s.SerializeObject<Path>(EnergyBallQueenPath, name: "EnergyBallQueenPath");
			FlowerPowerQueenPath = s.SerializeObject<Path>(FlowerPowerQueenPath, name: "FlowerPowerQueenPath");
			GemPath = s.SerializeObject<Path>(GemPath, name: "GemPath");
			RegionPath = s.SerializeObject<Path>(RegionPath, name: "RegionPath");
			CostumePath = s.SerializeObject<Path>(CostumePath, name: "CostumePath");
			Ritual_SpeedCamera = s.Serialize<float>(Ritual_SpeedCamera, name: "Ritual_SpeedCamera");
			Ritual_DelaiShakeBeforeGrowth = s.Serialize<float>(Ritual_DelaiShakeBeforeGrowth, name: "Ritual_DelaiShakeBeforeGrowth");
			Ritual_DelaiBeforeLaunchRitual = s.Serialize<float>(Ritual_DelaiBeforeLaunchRitual, name: "Ritual_DelaiBeforeLaunchRitual");
			Ritual_RewardCreatureOffset = s.SerializeObject<Vec3d>(Ritual_RewardCreatureOffset, name: "Ritual_RewardCreatureOffset");
			Ritual_CreatureOnTopOfTheTreeOffset = s.SerializeObject<Vec3d>(Ritual_CreatureOnTopOfTheTreeOffset, name: "Ritual_CreatureOnTopOfTheTreeOffset");
			Ritual_CreatureBeforeRitual = s.SerializeObject<Vec3d>(Ritual_CreatureBeforeRitual, name: "Ritual_CreatureBeforeRitual");
			Ritual_RitualTimeCelebration = s.Serialize<float>(Ritual_RitualTimeCelebration, name: "Ritual_RitualTimeCelebration");
			Ritual_DelaiRewardPopupisDisplayed = s.Serialize<float>(Ritual_DelaiRewardPopupisDisplayed, name: "Ritual_DelaiRewardPopupisDisplayed");
			StarStepInMeters = s.Serialize<float>(StarStepInMeters, name: "StarStepInMeters");
			StarNeededToGrowBranches = s.Serialize<uint>(StarNeededToGrowBranches, name: "StarNeededToGrowBranches");
			SmallHouseMaxMember = s.Serialize<uint>(SmallHouseMaxMember, name: "SmallHouseMaxMember");
			RewardsList = s.SerializeObject<CMap<int, RLC_TreeRewardList>>(RewardsList, name: "RewardsList");
			LevelXPList = s.SerializeObject<CListP<uint>>(LevelXPList, name: "LevelXPList");
			PropsTrunkMidList = s.SerializeObject<CListO<Path>>(PropsTrunkMidList, name: "PropsTrunkMidList");
			PropsTrunkBorderList = s.SerializeObject<CListO<Path>>(PropsTrunkBorderList, name: "PropsTrunkBorderList");
			XPSpeed = s.Serialize<uint>(XPSpeed, name: "XPSpeed");
			XPMultiplier = s.Serialize<uint>(XPMultiplier, name: "XPMultiplier");
			GrabCreatureTouchDuration = s.Serialize<float>(GrabCreatureTouchDuration, name: "GrabCreatureTouchDuration");
			LaunchCreatureMaxSpeed = s.Serialize<float>(LaunchCreatureMaxSpeed, name: "LaunchCreatureMaxSpeed");
			TreeTrunckScale = s.Serialize<float>(TreeTrunckScale, name: "TreeTrunckScale");
			OffsetByFamilly = s.Serialize<float>(OffsetByFamilly, name: "OffsetByFamilly");
			BeatboxTutoIconStart = s.SerializeObject<PathRef>(BeatboxTutoIconStart, name: "BeatboxTutoIconStart");
			BeatboxTutoIconStop = s.SerializeObject<PathRef>(BeatboxTutoIconStop, name: "BeatboxTutoIconStop");
			BeatboxTutoIconSave = s.SerializeObject<PathRef>(BeatboxTutoIconSave, name: "BeatboxTutoIconSave");
			WwiseGUID_StartFocus = s.SerializeObject<StringID>(WwiseGUID_StartFocus, name: "WwiseGUID_StartFocus");
			WwiseGUID_StopFocus = s.SerializeObject<StringID>(WwiseGUID_StopFocus, name: "WwiseGUID_StopFocus");
			PreloadDistance = s.Serialize<float>(PreloadDistance, name: "PreloadDistance");
			LoadDistance = s.Serialize<float>(LoadDistance, name: "LoadDistance");
			FX_LeaveCommon = s.SerializeObject<Path>(FX_LeaveCommon, name: "FX_LeaveCommon");
			FX_LeaveUncommon = s.SerializeObject<Path>(FX_LeaveUncommon, name: "FX_LeaveUncommon");
			FX_LeaveRare = s.SerializeObject<Path>(FX_LeaveRare, name: "FX_LeaveRare");
			FX_LeaveQueen = s.SerializeObject<Path>(FX_LeaveQueen, name: "FX_LeaveQueen");
			FX_LeaveDeath = s.SerializeObject<Path>(FX_LeaveDeath, name: "FX_LeaveDeath");
			TreeOptimGraphList = s.SerializeObject<CListO<RLC_TreeOptimGraph>>(TreeOptimGraphList, name: "TreeOptimGraphList");
			FXGiftPath = s.SerializeObject<Path>(FXGiftPath, name: "FXGiftPath");
			FXGiftRegionPath = s.SerializeObject<Path>(FXGiftRegionPath, name: "FXGiftRegionPath");
			FXGiftCostumePath = s.SerializeObject<Path>(FXGiftCostumePath, name: "FXGiftCostumePath");
			FXLevelPath = s.SerializeObject<Path>(FXLevelPath, name: "FXLevelPath");
			FXLevelExploPath = s.SerializeObject<Path>(FXLevelExploPath, name: "FXLevelExploPath");
			BeatBoxTapFxPath = s.SerializeObject<Path>(BeatBoxTapFxPath, name: "BeatBoxTapFxPath");
			BeatBoxRecDefault = s.Serialize<bool>(BeatBoxRecDefault, name: "BeatBoxRecDefault");
			BeatBoxDisplayUI = s.Serialize<bool>(BeatBoxDisplayUI, name: "BeatBoxDisplayUI");
			BeatBoxRecLengthFactor = s.Serialize<float>(BeatBoxRecLengthFactor, name: "BeatBoxRecLengthFactor");
			BeatBoxTutoNextSteps = s.SerializeObject<CMap<string, string>>(BeatBoxTutoNextSteps, name: "BeatBoxTutoNextSteps");
			BeatboxTutoNbCreaturesToUnlock = s.Serialize<uint>(BeatboxTutoNbCreaturesToUnlock, name: "BeatboxTutoNbCreaturesToUnlock");
			BeatboxTutoNbCreaturesForReminder = s.Serialize<uint>(BeatboxTutoNbCreaturesForReminder, name: "BeatboxTutoNbCreaturesForReminder");
			TutoLeaderboardMinAdventure = s.Serialize<uint>(TutoLeaderboardMinAdventure, name: "TutoLeaderboardMinAdventure");
		}
		public override uint? ClassCRC => 0x154D6824;
	}
}

