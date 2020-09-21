using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GameManagerConfig_Template : GameManagerConfig_Template {
		public RO2_PlayerConfig_Template playerConfig;
		public Path gameplayCameraPath;
		public Path remoteCameraPath;
		public Path defaultLoadingPath;
		public Path defaultInteractiveLoadingScreenPath;
		public Path movieLoadingScreenPath;
		public Path fadeWorldPath;
		public Path baseWorldPath;
		public Path defaultGameplayCameraPath;
		public Path exploGameplayCameraPath;
		public Path treeCameraPath;
		public Path adventureCameraPath;
		public Path scrollableCameraPath;
		public Path leaderboardCameraPath;
		public PathRef LuckyTicketLevelPath;
		public PathRef GoldenLuckyTicketLevelPath;
		public PathRef ChocolateLuckyTicketLevelPath;
		public PathRef ChallengeLuckyTicketLevelPath;
		public float menuMissionDisplayLockDuration;
		public float menuGoLockDuration;
		public bool RunnerSwipeToStart;
		public bool CheatButtonNewGame;
		public bool CheatUnlockAdventureMap;
		public bool CheatIntroActive;
		public bool CheatGoToAdventure;
		public bool CheatGoToLeaderboard;
		public bool CheatSkipTreeRitual;
		public bool CheatInfiniteFood;
		public bool CheatShowMenuTestLoca;
		public bool CheatSkipIntro;
		public bool CheatSkipAllIntro;
		public bool CheatShowForcedCreatureId;
		public bool CheatSkipDisclaimer;
		public bool CheatPadConnect;
		public bool CheatFruityBuild;
		public bool CheatActiveLeaderboard;
		public bool ShareGameplayScreenshotEnabled;
		public Spline SplineScoreRecapCanvasAppearScale;
		public StringID wwiseGUID_DefaultErrorSound;
		public online.TimeInterval minTimeBetweenObservedSessions;
		public uint initialNbSessionsBeforeFacebookProposal;
		public uint nbSessionsBetweenFacebookProposals;
		public uint nbSessionsBeforeMailboxReminder;
		public float showNewGameButtonDelay;
		public Path PreviewRayman;
		public Path PreviewBarbara;
		public Path TreeRayman;
		public Path TreeBarbara;
		public Generic<Event> MainMenuStartMusicEvent;
		public online.TimeInterval restartOnBackgroundDelay;
		public online.TimeInterval restartOnBackgroundExtendedDelay;
		public online.TimeInterval serverTimeTrustDelay;
		public uint forcedLoadingHintLocId;
		public Path SideLumsPath;
		public Path SideTrappedTeensyPath;
		public Path SideRocketTeensyPath;
		public Path SideRocketTeensyFXPath;
		public Path SideJacquouillePath;
		public Vec2d SideLumsOffset;
		public Vec2d SideTrappedTeensyOffset;
		public Vec2d SideRocketTeensyOffset;
		public Vec2d SideJacquouilleOffset;
		public Path environmentBrickPath;
		public Path startBrickPath;
		public Path endBrickPath;
		public Path firstRightBrickPath;
		public Path firstLeftBrickPath;
		public Path defaultDecoBrickPath;
		public Path costumeEnvironmentBrickPath;
		public Path costumeStartBrickPath;
		public Path costumeEndBrickPath;
		public Path costumeFirstRightBrickPath;
		public Path costumeFirstLeftBrickPath;
		public CListO<RO2_CostumeDescriptor_Template> additionalCostumesDescription;
		public Path teensieCompass;
		public uint petRewardSpawnHour;
		public Path homeMapPath;
		public Path firstLevelPath;
		public Path benchLevelPath;
		public Path benchLevelPath2;
		public Path captainPath;
		public Path countdown321GoPath;
		public Path treeLevelPath;
		public Path firstPlayablePath;
		public Path firstRitualPath;
		public PathRef nextRegionMapPath;
		public PathRef adversarialSoccerPath;
		public PathRef adversarialSoccerBallPath;
		public Path soccerConfig;
		public Path characterSelectionPath;
		public Path HideNSeekExitManagerPath;
		public CListO<Path> HideNSeekIntroCutScenePath;
		public PathRef introMoviePath;
		public CListO<RO2_GameManagerConfig_Template.LocalisedVideo> introMoviePathContainer;
		public Path mainMenuPath;
		public Path creditsPath;
		public Path endingCreditsPath;
		public Path logoVideoIntroPath;
		public Path comingSoonVideoPath;
		public Path unlockSaveProgressionPath;
		public CListO<RO2_CostumeInfo_Template> costumes;
		public Path scoreRecapPath;
		public Path duckTransfoSeqMrDarkActorPath;
		public float demoTimer;
		public float demoInactivityTimer;
		public float demoEndMenuTimer;
		public float menulookDRCScreenDisplayDuration;
		public float menuAutoMurphyScreenDisplayDuration;
		public Path timeAttackTimerPath;
		public float timeAttackRetryDelay;
		public bool takePauseScreenshot;
		public uint pauseScreenshotWidth;
		public uint pauseScreenshotHeight;
		public uint nbDeathBeforeGivingHeart;
		public uint nbDeathBeforeGivingAnotherHeart;
		public uint nbDeathBeforeSkip;
		public float playerInactivityTime;
		public float playerInactivityBlinkingTime;
		public Path invasionCountdown;
		public CListO<RO2_GameManagerConfig_Template.MapConfig> levelsInfo;
		public CListO<RO2_GameManagerConfig_Template.WorldConfig> worldsInfo;
		public CListO<RO2_GameManagerConfig_Template.InvasionConfig> invasionsInfo;
		public CListO<RO2_GameManagerConfig_Template.LockDataClass> lockData;
		public CListO<RO2_GameManagerConfig_Template.TagTextClass> tagText;
		public CListO<RO2_GameManagerConfig_Template.LuckyTicketUnlock> luckyTicketUnlockList;
		public CListO<RO2_GameManagerConfig_Template.RewardPerWorldCompletion> rewardsPerWorldCompletion;
		public Generic<Event> invasionMusicMenuSuccess;
		public Generic<Event> invasionMusicMenuBestScore;
		public Generic<Event> invasionMusicMenuLoose;
		public CListO<RO2_GameManagerConfig_Template.Pet> pets;
		public StringID darkRaymanID;
		public RLC_BeatboxDataList initialBeatbox;
		public CMap<string, Path> TextIcons;
		public CMap<string, MultiplePath> TextMultiIcons;
		public Path saveRegionDefaultPath;
		public GFXPrimitiveParam loadingCharacterShadowGFX;
		public Path loadingCharacterDefaultPath;
		public string versionNumber;
		public bool newsButton_iOS;
		public bool newsButton_tvOS;
		public bool newsButton_android;
		public CListO<Path> packageDirectories;
		public CListO<Path> environmentBrickPaths;
		public CListO<Path> costumeEnvironmentBrickPaths;
		public CListO<RO2_GameManagerConfig_Template.LocalisedVideo> ps3HddIntroMoviePathContainer;
		public CListO<Path> demoTrailerMoviePathContainer;
		public Path scoreRecapChallengePath;
		public CListO<Path> catchTheAllMaps;
		public CListO<Path> debugmapslist;
		public CListO<Path> packages;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				playerConfig = s.SerializeObject<RO2_PlayerConfig_Template>(playerConfig, name: "playerConfig");
				gameplayCameraPath = s.SerializeObject<Path>(gameplayCameraPath, name: "gameplayCameraPath");
				remoteCameraPath = s.SerializeObject<Path>(remoteCameraPath, name: "remoteCameraPath");
				defaultLoadingPath = s.SerializeObject<Path>(defaultLoadingPath, name: "defaultLoadingPath");
				defaultInteractiveLoadingScreenPath = s.SerializeObject<Path>(defaultInteractiveLoadingScreenPath, name: "defaultInteractiveLoadingScreenPath");
				movieLoadingScreenPath = s.SerializeObject<Path>(movieLoadingScreenPath, name: "movieLoadingScreenPath");
				fadeWorldPath = s.SerializeObject<Path>(fadeWorldPath, name: "fadeWorldPath");
				packageDirectories = s.SerializeObject<CListO<Path>>(packageDirectories, name: "packageDirectories");
				environmentBrickPath = s.SerializeObject<Path>(environmentBrickPath, name: "environmentBrickPath");
				environmentBrickPaths = s.SerializeObject<CListO<Path>>(environmentBrickPaths, name: "environmentBrickPaths");
				startBrickPath = s.SerializeObject<Path>(startBrickPath, name: "startBrickPath");
				endBrickPath = s.SerializeObject<Path>(endBrickPath, name: "endBrickPath");
				firstRightBrickPath = s.SerializeObject<Path>(firstRightBrickPath, name: "firstRightBrickPath");
				firstLeftBrickPath = s.SerializeObject<Path>(firstLeftBrickPath, name: "firstLeftBrickPath");
				defaultDecoBrickPath = s.SerializeObject<Path>(defaultDecoBrickPath, name: "defaultDecoBrickPath");
				costumeEnvironmentBrickPath = s.SerializeObject<Path>(costumeEnvironmentBrickPath, name: "costumeEnvironmentBrickPath");
				costumeEnvironmentBrickPaths = s.SerializeObject<CListO<Path>>(costumeEnvironmentBrickPaths, name: "costumeEnvironmentBrickPaths");
				costumeStartBrickPath = s.SerializeObject<Path>(costumeStartBrickPath, name: "costumeStartBrickPath");
				costumeEndBrickPath = s.SerializeObject<Path>(costumeEndBrickPath, name: "costumeEndBrickPath");
				costumeFirstRightBrickPath = s.SerializeObject<Path>(costumeFirstRightBrickPath, name: "costumeFirstRightBrickPath");
				costumeFirstLeftBrickPath = s.SerializeObject<Path>(costumeFirstLeftBrickPath, name: "costumeFirstLeftBrickPath");
				additionalCostumesDescription = s.SerializeObject<CListO<RO2_CostumeDescriptor_Template>>(additionalCostumesDescription, name: "additionalCostumesDescription");
				petRewardSpawnHour = s.Serialize<uint>(petRewardSpawnHour, name: "petRewardSpawnHour");
				homeMapPath = s.SerializeObject<Path>(homeMapPath, name: "homeMapPath");
				soccerConfig = s.SerializeObject<Path>(soccerConfig, name: "soccerConfig");
				firstLevelPath = (Path)s.SerializeObject<PathRef>((PathRef)firstLevelPath, name: "firstLevelPath");
				introMoviePath = s.SerializeObject<PathRef>(introMoviePath, name: "introMoviePath");
				introMoviePathContainer = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.LocalisedVideo>>(introMoviePathContainer, name: "introMoviePathContainer");
				ps3HddIntroMoviePathContainer = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.LocalisedVideo>>(ps3HddIntroMoviePathContainer, name: "ps3HddIntroMoviePathContainer");
				demoTrailerMoviePathContainer = s.SerializeObject<CListO<Path>>(demoTrailerMoviePathContainer, name: "demoTrailerMoviePathContainer");
				mainMenuPath = s.SerializeObject<Path>(mainMenuPath, name: "mainMenuPath");
				creditsPath = s.SerializeObject<Path>(creditsPath, name: "creditsPath");
				endingCreditsPath = s.SerializeObject<Path>(endingCreditsPath, name: "endingCreditsPath");
				logoVideoIntroPath = s.SerializeObject<Path>(logoVideoIntroPath, name: "logoVideoIntroPath");
				comingSoonVideoPath = s.SerializeObject<Path>(comingSoonVideoPath, name: "comingSoonVideoPath");
				unlockSaveProgressionPath = s.SerializeObject<Path>(unlockSaveProgressionPath, name: "unlockSaveProgressionPath");
				costumes = s.SerializeObject<CListO<RO2_CostumeInfo_Template>>(costumes, name: "costumes");
				scoreRecapPath = s.SerializeObject<Path>(scoreRecapPath, name: "scoreRecapPath");
				scoreRecapChallengePath = s.SerializeObject<Path>(scoreRecapChallengePath, name: "scoreRecapChallengePath");
				duckTransfoSeqMrDarkActorPath = s.SerializeObject<Path>(duckTransfoSeqMrDarkActorPath, name: "duckTransfoSeqMrDarkActorPath");
				catchTheAllMaps = s.SerializeObject<CListO<Path>>(catchTheAllMaps, name: "catchTheAllMaps");
				demoTimer = s.Serialize<float>(demoTimer, name: "demoTimer");
				demoInactivityTimer = s.Serialize<float>(demoInactivityTimer, name: "demoInactivityTimer");
				demoEndMenuTimer = s.Serialize<float>(demoEndMenuTimer, name: "demoEndMenuTimer");
				debugmapslist = s.SerializeObject<CListO<Path>>(debugmapslist, name: "debugmapslist");
				menulookDRCScreenDisplayDuration = s.Serialize<float>(menulookDRCScreenDisplayDuration, name: "menulookDRCScreenDisplayDuration");
				menuAutoMurphyScreenDisplayDuration = s.Serialize<float>(menuAutoMurphyScreenDisplayDuration, name: "menuAutoMurphyScreenDisplayDuration");
				timeAttackTimerPath = s.SerializeObject<Path>(timeAttackTimerPath, name: "timeAttackTimerPath");
				takePauseScreenshot = s.Serialize<bool>(takePauseScreenshot, name: "takePauseScreenshot");
				pauseScreenshotWidth = s.Serialize<uint>(pauseScreenshotWidth, name: "pauseScreenshotWidth");
				pauseScreenshotHeight = s.Serialize<uint>(pauseScreenshotHeight, name: "pauseScreenshotHeight");
				nbDeathBeforeGivingHeart = s.Serialize<uint>(nbDeathBeforeGivingHeart, name: "nbDeathBeforeGivingHeart");
				nbDeathBeforeGivingAnotherHeart = s.Serialize<uint>(nbDeathBeforeGivingAnotherHeart, name: "nbDeathBeforeGivingAnotherHeart");
				nbDeathBeforeSkip = s.Serialize<uint>(nbDeathBeforeSkip, name: "nbDeathBeforeSkip");
				playerInactivityTime = s.Serialize<float>(playerInactivityTime, name: "playerInactivityTime");
				playerInactivityBlinkingTime = s.Serialize<float>(playerInactivityBlinkingTime, name: "playerInactivityBlinkingTime");
				invasionCountdown = s.SerializeObject<Path>(invasionCountdown, name: "invasionCountdown");
				packages = s.SerializeObject<CListO<Path>>(packages, name: "packages");
				levelsInfo = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.MapConfig>>(levelsInfo, name: "levelsInfo");
				worldsInfo = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.WorldConfig>>(worldsInfo, name: "worldsInfo");
				invasionsInfo = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.InvasionConfig>>(invasionsInfo, name: "invasionsInfo");
				lockData = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.LockDataClass>>(lockData, name: "lockData");
				tagText = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.TagTextClass>>(tagText, name: "tagText");
				luckyTicketUnlockList = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.LuckyTicketUnlock>>(luckyTicketUnlockList, name: "luckyTicketUnlockList");
				rewardsPerWorldCompletion = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.RewardPerWorldCompletion>>(rewardsPerWorldCompletion, name: "rewardsPerWorldCompletion");
				invasionMusicMenuSuccess = s.SerializeObject<Generic<Event>>(invasionMusicMenuSuccess, name: "invasionMusicMenuSuccess");
				invasionMusicMenuBestScore = s.SerializeObject<Generic<Event>>(invasionMusicMenuBestScore, name: "invasionMusicMenuBestScore");
				invasionMusicMenuLoose = s.SerializeObject<Generic<Event>>(invasionMusicMenuLoose, name: "invasionMusicMenuLoose");
				pets = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.Pet>>(pets, name: "pets");
				darkRaymanID = s.SerializeObject<StringID>(darkRaymanID, name: "darkRaymanID");
			} else {
				playerConfig = s.SerializeObject<RO2_PlayerConfig_Template>(playerConfig, name: "playerConfig");
				gameplayCameraPath = s.SerializeObject<Path>(gameplayCameraPath, name: "gameplayCameraPath");
				remoteCameraPath = s.SerializeObject<Path>(remoteCameraPath, name: "remoteCameraPath");
				defaultLoadingPath = s.SerializeObject<Path>(defaultLoadingPath, name: "defaultLoadingPath");
				defaultInteractiveLoadingScreenPath = s.SerializeObject<Path>(defaultInteractiveLoadingScreenPath, name: "defaultInteractiveLoadingScreenPath");
				movieLoadingScreenPath = s.SerializeObject<Path>(movieLoadingScreenPath, name: "movieLoadingScreenPath");
				fadeWorldPath = s.SerializeObject<Path>(fadeWorldPath, name: "fadeWorldPath");
				baseWorldPath = s.SerializeObject<Path>(baseWorldPath, name: "baseWorldPath");
				packageDirectories = s.SerializeObject<CListO<Path>>(packageDirectories, name: "packageDirectories");
				defaultGameplayCameraPath = s.SerializeObject<Path>(defaultGameplayCameraPath, name: "defaultGameplayCameraPath");
				exploGameplayCameraPath = s.SerializeObject<Path>(exploGameplayCameraPath, name: "exploGameplayCameraPath");
				treeCameraPath = s.SerializeObject<Path>(treeCameraPath, name: "treeCameraPath");
				adventureCameraPath = s.SerializeObject<Path>(adventureCameraPath, name: "adventureCameraPath");
				scrollableCameraPath = s.SerializeObject<Path>(scrollableCameraPath, name: "scrollableCameraPath");
				leaderboardCameraPath = s.SerializeObject<Path>(leaderboardCameraPath, name: "leaderboardCameraPath");
				LuckyTicketLevelPath = s.SerializeObject<PathRef>(LuckyTicketLevelPath, name: "LuckyTicketLevelPath");
				GoldenLuckyTicketLevelPath = s.SerializeObject<PathRef>(GoldenLuckyTicketLevelPath, name: "GoldenLuckyTicketLevelPath");
				ChocolateLuckyTicketLevelPath = s.SerializeObject<PathRef>(ChocolateLuckyTicketLevelPath, name: "ChocolateLuckyTicketLevelPath");
				ChallengeLuckyTicketLevelPath = s.SerializeObject<PathRef>(ChallengeLuckyTicketLevelPath, name: "ChallengeLuckyTicketLevelPath");
				menuMissionDisplayLockDuration = s.Serialize<float>(menuMissionDisplayLockDuration, name: "menuMissionDisplayLockDuration");
				menuGoLockDuration = s.Serialize<float>(menuGoLockDuration, name: "menuGoLockDuration");
				RunnerSwipeToStart = s.Serialize<bool>(RunnerSwipeToStart, name: "RunnerSwipeToStart");
				CheatButtonNewGame = s.Serialize<bool>(CheatButtonNewGame, name: "CheatButtonNewGame");
				CheatUnlockAdventureMap = s.Serialize<bool>(CheatUnlockAdventureMap, name: "CheatUnlockAdventureMap");
				CheatIntroActive = s.Serialize<bool>(CheatIntroActive, name: "CheatIntroActive");
				CheatGoToAdventure = s.Serialize<bool>(CheatGoToAdventure, name: "CheatGoToAdventure");
				CheatGoToLeaderboard = s.Serialize<bool>(CheatGoToLeaderboard, name: "CheatGoToLeaderboard");
				CheatSkipTreeRitual = s.Serialize<bool>(CheatSkipTreeRitual, name: "CheatSkipTreeRitual");
				CheatInfiniteFood = s.Serialize<bool>(CheatInfiniteFood, name: "CheatInfiniteFood");
				CheatShowMenuTestLoca = s.Serialize<bool>(CheatShowMenuTestLoca, name: "CheatShowMenuTestLoca");
				CheatSkipIntro = s.Serialize<bool>(CheatSkipIntro, name: "CheatSkipIntro");
				CheatSkipAllIntro = s.Serialize<bool>(CheatSkipAllIntro, name: "CheatSkipAllIntro");
				CheatShowForcedCreatureId = s.Serialize<bool>(CheatShowForcedCreatureId, name: "CheatShowForcedCreatureId");
				CheatSkipDisclaimer = s.Serialize<bool>(CheatSkipDisclaimer, name: "CheatSkipDisclaimer");
				CheatPadConnect = s.Serialize<bool>(CheatPadConnect, name: "CheatPadConnect");
				CheatFruityBuild = s.Serialize<bool>(CheatFruityBuild, name: "CheatFruityBuild");
				CheatActiveLeaderboard = s.Serialize<bool>(CheatActiveLeaderboard, name: "CheatActiveLeaderboard");
				ShareGameplayScreenshotEnabled = s.Serialize<bool>(ShareGameplayScreenshotEnabled, name: "ShareGameplayScreenshotEnabled");
				SplineScoreRecapCanvasAppearScale = s.SerializeObject<Spline>(SplineScoreRecapCanvasAppearScale, name: "SplineScoreRecapCanvasAppearScale");
				wwiseGUID_DefaultErrorSound = s.SerializeObject<StringID>(wwiseGUID_DefaultErrorSound, name: "wwiseGUID_DefaultErrorSound");
				minTimeBetweenObservedSessions = s.SerializeObject<online.TimeInterval>(minTimeBetweenObservedSessions, name: "minTimeBetweenObservedSessions");
				initialNbSessionsBeforeFacebookProposal = s.Serialize<uint>(initialNbSessionsBeforeFacebookProposal, name: "initialNbSessionsBeforeFacebookProposal");
				nbSessionsBetweenFacebookProposals = s.Serialize<uint>(nbSessionsBetweenFacebookProposals, name: "nbSessionsBetweenFacebookProposals");
				nbSessionsBeforeMailboxReminder = s.Serialize<uint>(nbSessionsBeforeMailboxReminder, name: "nbSessionsBeforeMailboxReminder");
				showNewGameButtonDelay = s.Serialize<float>(showNewGameButtonDelay, name: "showNewGameButtonDelay");
				PreviewRayman = s.SerializeObject<Path>(PreviewRayman, name: "PreviewRayman");
				PreviewBarbara = s.SerializeObject<Path>(PreviewBarbara, name: "PreviewBarbara");
				TreeRayman = s.SerializeObject<Path>(TreeRayman, name: "TreeRayman");
				TreeBarbara = s.SerializeObject<Path>(TreeBarbara, name: "TreeBarbara");
				MainMenuStartMusicEvent = s.SerializeObject<Generic<Event>>(MainMenuStartMusicEvent, name: "MainMenuStartMusicEvent");
				restartOnBackgroundDelay = s.SerializeObject<online.TimeInterval>(restartOnBackgroundDelay, name: "restartOnBackgroundDelay");
				restartOnBackgroundExtendedDelay = s.SerializeObject<online.TimeInterval>(restartOnBackgroundExtendedDelay, name: "restartOnBackgroundExtendedDelay");
				serverTimeTrustDelay = s.SerializeObject<online.TimeInterval>(serverTimeTrustDelay, name: "serverTimeTrustDelay");
				forcedLoadingHintLocId = s.Serialize<uint>(forcedLoadingHintLocId, name: "forcedLoadingHintLocId");
				SideLumsPath = s.SerializeObject<Path>(SideLumsPath, name: "SideLumsPath");
				SideTrappedTeensyPath = s.SerializeObject<Path>(SideTrappedTeensyPath, name: "SideTrappedTeensyPath");
				SideRocketTeensyPath = s.SerializeObject<Path>(SideRocketTeensyPath, name: "SideRocketTeensyPath");
				SideRocketTeensyFXPath = s.SerializeObject<Path>(SideRocketTeensyFXPath, name: "SideRocketTeensyFXPath");
				SideJacquouillePath = s.SerializeObject<Path>(SideJacquouillePath, name: "SideJacquouillePath");
				SideLumsOffset = s.SerializeObject<Vec2d>(SideLumsOffset, name: "SideLumsOffset");
				SideTrappedTeensyOffset = s.SerializeObject<Vec2d>(SideTrappedTeensyOffset, name: "SideTrappedTeensyOffset");
				SideRocketTeensyOffset = s.SerializeObject<Vec2d>(SideRocketTeensyOffset, name: "SideRocketTeensyOffset");
				SideJacquouilleOffset = s.SerializeObject<Vec2d>(SideJacquouilleOffset, name: "SideJacquouilleOffset");
				environmentBrickPath = s.SerializeObject<Path>(environmentBrickPath, name: "environmentBrickPath");
				environmentBrickPaths = s.SerializeObject<CListO<Path>>(environmentBrickPaths, name: "environmentBrickPaths");
				startBrickPath = s.SerializeObject<Path>(startBrickPath, name: "startBrickPath");
				endBrickPath = s.SerializeObject<Path>(endBrickPath, name: "endBrickPath");
				firstRightBrickPath = s.SerializeObject<Path>(firstRightBrickPath, name: "firstRightBrickPath");
				firstLeftBrickPath = s.SerializeObject<Path>(firstLeftBrickPath, name: "firstLeftBrickPath");
				defaultDecoBrickPath = s.SerializeObject<Path>(defaultDecoBrickPath, name: "defaultDecoBrickPath");
				costumeEnvironmentBrickPath = s.SerializeObject<Path>(costumeEnvironmentBrickPath, name: "costumeEnvironmentBrickPath");
				costumeEnvironmentBrickPaths = s.SerializeObject<CListO<Path>>(costumeEnvironmentBrickPaths, name: "costumeEnvironmentBrickPaths");
				costumeStartBrickPath = s.SerializeObject<Path>(costumeStartBrickPath, name: "costumeStartBrickPath");
				costumeEndBrickPath = s.SerializeObject<Path>(costumeEndBrickPath, name: "costumeEndBrickPath");
				costumeFirstRightBrickPath = s.SerializeObject<Path>(costumeFirstRightBrickPath, name: "costumeFirstRightBrickPath");
				costumeFirstLeftBrickPath = s.SerializeObject<Path>(costumeFirstLeftBrickPath, name: "costumeFirstLeftBrickPath");
				additionalCostumesDescription = s.SerializeObject<CListO<RO2_CostumeDescriptor_Template>>(additionalCostumesDescription, name: "additionalCostumesDescription");
				teensieCompass = s.SerializeObject<Path>(teensieCompass, name: "teensieCompass");
				petRewardSpawnHour = s.Serialize<uint>(petRewardSpawnHour, name: "petRewardSpawnHour");
				homeMapPath = s.SerializeObject<Path>(homeMapPath, name: "homeMapPath");
				firstLevelPath = s.SerializeObject<Path>(firstLevelPath, name: "firstLevelPath");
				benchLevelPath = s.SerializeObject<Path>(benchLevelPath, name: "benchLevelPath");
				benchLevelPath2 = s.SerializeObject<Path>(benchLevelPath2, name: "benchLevelPath2");
				captainPath = s.SerializeObject<Path>(captainPath, name: "captainPath");
				countdown321GoPath = s.SerializeObject<Path>(countdown321GoPath, name: "countdown321GoPath");
				treeLevelPath = s.SerializeObject<Path>(treeLevelPath, name: "treeLevelPath");
				firstPlayablePath = s.SerializeObject<Path>(firstPlayablePath, name: "firstPlayablePath");
				firstRitualPath = s.SerializeObject<Path>(firstRitualPath, name: "firstRitualPath");
				nextRegionMapPath = s.SerializeObject<PathRef>(nextRegionMapPath, name: "nextRegionMapPath");
				adversarialSoccerPath = s.SerializeObject<PathRef>(adversarialSoccerPath, name: "adversarialSoccerPath");
				adversarialSoccerBallPath = s.SerializeObject<PathRef>(adversarialSoccerBallPath, name: "adversarialSoccerBallPath");
				soccerConfig = s.SerializeObject<Path>(soccerConfig, name: "soccerConfig");
				characterSelectionPath = s.SerializeObject<Path>(characterSelectionPath, name: "characterSelectionPath");
				HideNSeekExitManagerPath = s.SerializeObject<Path>(HideNSeekExitManagerPath, name: "HideNSeekExitManagerPath");
				HideNSeekIntroCutScenePath = s.SerializeObject<CListO<Path>>(HideNSeekIntroCutScenePath, name: "HideNSeekIntroCutScenePath");
				introMoviePath = s.SerializeObject<PathRef>(introMoviePath, name: "introMoviePath");
				introMoviePathContainer = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.LocalisedVideo>>(introMoviePathContainer, name: "introMoviePathContainer");
				mainMenuPath = s.SerializeObject<Path>(mainMenuPath, name: "mainMenuPath");
				creditsPath = s.SerializeObject<Path>(creditsPath, name: "creditsPath");
				endingCreditsPath = s.SerializeObject<Path>(endingCreditsPath, name: "endingCreditsPath");
				logoVideoIntroPath = s.SerializeObject<Path>(logoVideoIntroPath, name: "logoVideoIntroPath");
				comingSoonVideoPath = s.SerializeObject<Path>(comingSoonVideoPath, name: "comingSoonVideoPath");
				unlockSaveProgressionPath = s.SerializeObject<Path>(unlockSaveProgressionPath, name: "unlockSaveProgressionPath");
				costumes = s.SerializeObject<CListO<RO2_CostumeInfo_Template>>(costumes, name: "costumes");
				scoreRecapPath = s.SerializeObject<Path>(scoreRecapPath, name: "scoreRecapPath");
				duckTransfoSeqMrDarkActorPath = s.SerializeObject<Path>(duckTransfoSeqMrDarkActorPath, name: "duckTransfoSeqMrDarkActorPath");
				catchTheAllMaps = s.SerializeObject<CListO<Path>>(catchTheAllMaps, name: "catchTheAllMaps");
				demoTimer = s.Serialize<float>(demoTimer, name: "demoTimer");
				demoInactivityTimer = s.Serialize<float>(demoInactivityTimer, name: "demoInactivityTimer");
				demoEndMenuTimer = s.Serialize<float>(demoEndMenuTimer, name: "demoEndMenuTimer");
				debugmapslist = s.SerializeObject<CListO<Path>>(debugmapslist, name: "debugmapslist");
				menulookDRCScreenDisplayDuration = s.Serialize<float>(menulookDRCScreenDisplayDuration, name: "menulookDRCScreenDisplayDuration");
				menuAutoMurphyScreenDisplayDuration = s.Serialize<float>(menuAutoMurphyScreenDisplayDuration, name: "menuAutoMurphyScreenDisplayDuration");
				timeAttackTimerPath = s.SerializeObject<Path>(timeAttackTimerPath, name: "timeAttackTimerPath");
				timeAttackRetryDelay = s.Serialize<float>(timeAttackRetryDelay, name: "timeAttackRetryDelay");
				takePauseScreenshot = s.Serialize<bool>(takePauseScreenshot, name: "takePauseScreenshot");
				pauseScreenshotWidth = s.Serialize<uint>(pauseScreenshotWidth, name: "pauseScreenshotWidth");
				pauseScreenshotHeight = s.Serialize<uint>(pauseScreenshotHeight, name: "pauseScreenshotHeight");
				nbDeathBeforeGivingHeart = s.Serialize<uint>(nbDeathBeforeGivingHeart, name: "nbDeathBeforeGivingHeart");
				nbDeathBeforeGivingAnotherHeart = s.Serialize<uint>(nbDeathBeforeGivingAnotherHeart, name: "nbDeathBeforeGivingAnotherHeart");
				nbDeathBeforeSkip = s.Serialize<uint>(nbDeathBeforeSkip, name: "nbDeathBeforeSkip");
				playerInactivityTime = s.Serialize<float>(playerInactivityTime, name: "playerInactivityTime");
				playerInactivityBlinkingTime = s.Serialize<float>(playerInactivityBlinkingTime, name: "playerInactivityBlinkingTime");
				invasionCountdown = s.SerializeObject<Path>(invasionCountdown, name: "invasionCountdown");
				packages = s.SerializeObject<CListO<Path>>(packages, name: "packages");
				levelsInfo = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.MapConfig>>(levelsInfo, name: "levelsInfo");
				worldsInfo = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.WorldConfig>>(worldsInfo, name: "worldsInfo");
				invasionsInfo = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.InvasionConfig>>(invasionsInfo, name: "invasionsInfo");
				lockData = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.LockDataClass>>(lockData, name: "lockData");
				tagText = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.TagTextClass>>(tagText, name: "tagText");
				luckyTicketUnlockList = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.LuckyTicketUnlock>>(luckyTicketUnlockList, name: "luckyTicketUnlockList");
				rewardsPerWorldCompletion = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.RewardPerWorldCompletion>>(rewardsPerWorldCompletion, name: "rewardsPerWorldCompletion");
				invasionMusicMenuSuccess = s.SerializeObject<Generic<Event>>(invasionMusicMenuSuccess, name: "invasionMusicMenuSuccess");
				invasionMusicMenuBestScore = s.SerializeObject<Generic<Event>>(invasionMusicMenuBestScore, name: "invasionMusicMenuBestScore");
				invasionMusicMenuLoose = s.SerializeObject<Generic<Event>>(invasionMusicMenuLoose, name: "invasionMusicMenuLoose");
				pets = s.SerializeObject<CListO<RO2_GameManagerConfig_Template.Pet>>(pets, name: "pets");
				darkRaymanID = s.SerializeObject<StringID>(darkRaymanID, name: "darkRaymanID");
				initialBeatbox = s.SerializeObject<RLC_BeatboxDataList>(initialBeatbox, name: "initialBeatbox");
				TextIcons = s.SerializeObject<CMap<string, Path>>(TextIcons, name: "TextIcons");
				TextMultiIcons = s.SerializeObject<CMap<string, MultiplePath>>(TextMultiIcons, name: "TextMultiIcons");
				saveRegionDefaultPath = s.SerializeObject<Path>(saveRegionDefaultPath, name: "saveRegionDefaultPath");
				loadingCharacterShadowGFX = s.SerializeObject<GFXPrimitiveParam>(loadingCharacterShadowGFX, name: "loadingCharacterShadowGFX");
				loadingCharacterDefaultPath = s.SerializeObject<Path>(loadingCharacterDefaultPath, name: "loadingCharacterDefaultPath");
				versionNumber = s.Serialize<string>(versionNumber, name: "versionNumber");
				newsButton_iOS = s.Serialize<bool>(newsButton_iOS, name: "newsButton_iOS");
				newsButton_tvOS = s.Serialize<bool>(newsButton_tvOS, name: "newsButton_tvOS");
				newsButton_android = s.Serialize<bool>(newsButton_android, name: "newsButton_android");
			}
		}
		[Games(GameFlags.RA | GameFlags.RL)]
		public partial class LockDataClass : CSerializable {
			public StringID tag;
			public MapLockType lockType;
			public uint lockCount;
			public StringID parent;
			public NodeBehaviorType behaviorType;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				lockType = s.Serialize<MapLockType>(lockType, name: "lockType");
				lockCount = s.Serialize<uint>(lockCount, name: "lockCount");
				parent = s.SerializeObject<StringID>(parent, name: "parent");
				behaviorType = s.Serialize<NodeBehaviorType>(behaviorType, name: "behaviorType");
			}
			public enum MapLockType {
				[Serialize("MapLockType_None"  )] None = 0,
				[Serialize("MapLockType_Cup"   )] Cup = 1,
				[Serialize("MapLockType_Teensy")] Teensy = 2,
				[Serialize("MapLockType_Lum"   )] Lum = 3,
				[Serialize("MapLockType_Star"  )] Star = 4,
				[Serialize("MapLockType_Ticket")] Ticket = 5,
			}
			public enum NodeBehaviorType {
				[Serialize("NodeBehaviorType_None"             )] None = 0,
				[Serialize("NodeBehaviorType_Level"            )] Level = 1,
				[Serialize("NodeBehaviorType_World"            )] World = 2,
				[Serialize("NodeBehaviorType_Hub"              )] Hub = 3,
				[Serialize("NodeBehaviorType_CostumeFrame"     )] CostumeFrame = 4,
				[Serialize("NodeBehaviorType_Challenge"        )] Challenge = 5,
				[Serialize("NodeBehaviorType_ChallengeStandard")] ChallengeStandard = 6,
				[Serialize("NodeBehaviorType_ChallengeExpert"  )] ChallengeExpert = 7,
				[Serialize("NodeBehaviorType_Pet"              )] Pet = 8,
				[Serialize("NodeBehaviorType_PetStand"         )] PetStand = 9,
				[Serialize("NodeBehaviorType_Door"             )] Door = 10,
			}
		}
		[Games(GameFlags.RA)]
		public partial class Pet : CSerializable {
			public uint visualId;
			public uint probability;
			public uint type;
			public StringID family;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				visualId = s.Serialize<uint>(visualId, name: "visualId");
				probability = s.Serialize<uint>(probability, name: "probability");
				type = s.Serialize<uint>(type, name: "type");
				family = s.SerializeObject<StringID>(family, name: "family");
			}
		}
		[Games(GameFlags.RA)]
		public partial class RewardPerWorldCompletion : CSerializable {
			public StringID lastMapID;
			public uint luckyTicketReward;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				lastMapID = s.SerializeObject<StringID>(lastMapID, name: "lastMapID");
				luckyTicketReward = s.Serialize<uint>(luckyTicketReward, name: "luckyTicketReward");
			}
		}
		[Games(GameFlags.RA)]
		public partial class WorldConfig : CSerializable {
			public StringID tag;
			public uint teensyUnlockCountRetro1;
			public uint teensyUnlockCountRetro2;
			public uint teensyUnlockCountCostume;
			public Path interactiveLoadingPath;
			public Path defaultScoreRecapPath;
			public StringID presence;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				teensyUnlockCountRetro1 = s.Serialize<uint>(teensyUnlockCountRetro1, name: "teensyUnlockCountRetro1");
				teensyUnlockCountRetro2 = s.Serialize<uint>(teensyUnlockCountRetro2, name: "teensyUnlockCountRetro2");
				teensyUnlockCountCostume = s.Serialize<uint>(teensyUnlockCountCostume, name: "teensyUnlockCountCostume");
				interactiveLoadingPath = s.SerializeObject<Path>(interactiveLoadingPath, name: "interactiveLoadingPath");
				defaultScoreRecapPath = s.SerializeObject<Path>(defaultScoreRecapPath, name: "defaultScoreRecapPath");
				presence = s.SerializeObject<StringID>(presence, name: "presence");
			}
		}
		[Games(GameFlags.RA)]
		public partial class LocalisedVideo : CSerializable {
			public Enum_language language;
			public Path video;
			public int audioTrack;
			public int videoTrack;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				language = s.Serialize<Enum_language>(language, name: "language");
				video = s.SerializeObject<Path>(video, name: "video");
				audioTrack = s.Serialize<int>(audioTrack, name: "audioTrack");
				videoTrack = s.Serialize<int>(videoTrack, name: "videoTrack");
			}
			public enum Enum_language {
			}
		}
		[Games(GameFlags.RA)]
		public partial class TagTextClass : CSerializable {
			public StringID tag;
			public LocalisationId locID;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				locID = s.SerializeObject<LocalisationId>(locID, name: "locID");
			}
		}
		[Games(GameFlags.RA)]
		public partial class MapConfig : CSerializable {
			public StringID tag;
			public StringID worldTag;
			public int teensyUnlockCount;
			public CListO<StringID> mapDependencies;
			public PathRef mapPath;
			public PathRef mapPathAM;
			public LocalisationId mapNameId;
			public Path texturePath;
			public TeensyCount teensyCount;
			public uint maxLumsCount;
			public bool horizontal;
			public uint difficulty;
			public MapLockType mapLockType;
			public Path scoreRecapPath;
			public Path loading;
			public Path loadingOut;
			public bool startLeft;
			public MAPTYPE mapType;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				worldTag = s.SerializeObject<StringID>(worldTag, name: "worldTag");
				teensyUnlockCount = s.Serialize<int>(teensyUnlockCount, name: "teensyUnlockCount");
				mapDependencies = s.SerializeObject<CListO<StringID>>(mapDependencies, name: "mapDependencies");
				mapPath = s.SerializeObject<PathRef>(mapPath, name: "mapPath");
				mapPathAM = s.SerializeObject<PathRef>(mapPathAM, name: "mapPathAM");
				mapNameId = s.SerializeObject<LocalisationId>(mapNameId, name: "mapNameId");
				texturePath = s.SerializeObject<Path>(texturePath, name: "texturePath");
				teensyCount = s.Serialize<TeensyCount>(teensyCount, name: "teensyCount");
				maxLumsCount = s.Serialize<uint>(maxLumsCount, name: "maxLumsCount");
				horizontal = s.Serialize<bool>(horizontal, name: "horizontal");
				difficulty = s.Serialize<uint>(difficulty, name: "difficulty");
				mapLockType = s.Serialize<MapLockType>(mapLockType, name: "mapLockType");
				scoreRecapPath = s.SerializeObject<Path>(scoreRecapPath, name: "scoreRecapPath");
				loading = s.SerializeObject<Path>(loading, name: "loading");
				loadingOut = s.SerializeObject<Path>(loadingOut, name: "loadingOut");
				startLeft = s.Serialize<bool>(startLeft, name: "startLeft");
				mapType = s.Serialize<MAPTYPE>(mapType, name: "mapType");
			}
			public enum TeensyCount {
				[Serialize("TeensyCount_None")] None = 0,
				[Serialize("TeensyCount_10"  )] _10 = 1,
				[Serialize("TeensyCount_3"   )] _3 = 2,
			}
			public enum MapLockType {
				[Serialize("MapLockType_None"  )] None = 0,
				[Serialize("MapLockType_Cup"   )] Cup = 1,
				[Serialize("MapLockType_Teensy")] Teensy = 2,
				[Serialize("MapLockType_Lum"   )] Lum = 3,
				[Serialize("MapLockType_Star"  )] Star = 4,
				[Serialize("MapLockType_Ticket")] Ticket = 5,
			}
			public enum MAPTYPE {
				[Serialize("MAPTYPE_NORMAL" )] NORMAL = 0,
				[Serialize("MAPTYPE_MUSICAL")] MUSICAL = 1,
			}
		}
		[Games(GameFlags.RA)]
		public partial class LuckyTicketUnlock : CSerializable {
			public uint mapID;
			public CListO<StringID> maps;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				mapID = s.Serialize<uint>(mapID, name: "mapID");
				maps = s.SerializeObject<CListO<StringID>>(maps, name: "maps");
			}
		}
		[Games(GameFlags.RA)]
		public partial class InvasionConfig : CSerializable {
			public StringID invadedMapTag;
			public StringID invasionMapTag;
			public StringID invaderMapTag;
			public uint teensyCount;
			public uint misterDarkCount;
			public CListO<Path> teensies2D;
			public CListO<Path> enemies2D;
			public CArrayO<Generic<Event>> musicModeList;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				invadedMapTag = s.SerializeObject<StringID>(invadedMapTag, name: "invadedMapTag");
				invasionMapTag = s.SerializeObject<StringID>(invasionMapTag, name: "invasionMapTag");
				invaderMapTag = s.SerializeObject<StringID>(invaderMapTag, name: "invaderMapTag");
				teensyCount = s.Serialize<uint>(teensyCount, name: "teensyCount");
				misterDarkCount = s.Serialize<uint>(misterDarkCount, name: "misterDarkCount");
				teensies2D = s.SerializeObject<CListO<Path>>(teensies2D, name: "teensies2D");
				enemies2D = s.SerializeObject<CListO<Path>>(enemies2D, name: "enemies2D");
				musicModeList = s.SerializeObject<CArrayO<Generic<Event>>>(musicModeList, name: "musicModeList");
			}
		}
		public override uint? ClassCRC => 0x8BE3B34A;
	}
}

