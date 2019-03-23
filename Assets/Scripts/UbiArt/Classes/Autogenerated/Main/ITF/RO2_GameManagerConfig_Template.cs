using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GameManagerConfig_Template : GameManagerConfig_Template {
		[Serialize("playerConfig"                           )] public RO2_PlayerConfig_Template playerConfig;
		[Serialize("gameplayCameraPath"                     )] public Path gameplayCameraPath;
		[Serialize("remoteCameraPath"                       )] public Path remoteCameraPath;
		[Serialize("defaultLoadingPath"                     )] public Path defaultLoadingPath;
		[Serialize("defaultInteractiveLoadingScreenPath"    )] public Path defaultInteractiveLoadingScreenPath;
		[Serialize("movieLoadingScreenPath"                 )] public Path movieLoadingScreenPath;
		[Serialize("fadeWorldPath"                          )] public Path fadeWorldPath;
		[Serialize("baseWorldPath"                          )] public Path baseWorldPath;
		[Serialize("defaultGameplayCameraPath"              )] public Path defaultGameplayCameraPath;
		[Serialize("exploGameplayCameraPath"                )] public Path exploGameplayCameraPath;
		[Serialize("treeCameraPath"                         )] public Path treeCameraPath;
		[Serialize("adventureCameraPath"                    )] public Path adventureCameraPath;
		[Serialize("scrollableCameraPath"                   )] public Path scrollableCameraPath;
		[Serialize("leaderboardCameraPath"                  )] public Path leaderboardCameraPath;
		[Serialize("LuckyTicketLevelPath"                   )] public PathRef LuckyTicketLevelPath;
		[Serialize("GoldenLuckyTicketLevelPath"             )] public PathRef GoldenLuckyTicketLevelPath;
		[Serialize("ChocolateLuckyTicketLevelPath"          )] public PathRef ChocolateLuckyTicketLevelPath;
		[Serialize("ChallengeLuckyTicketLevelPath"          )] public PathRef ChallengeLuckyTicketLevelPath;
		[Serialize("menuMissionDisplayLockDuration"         )] public float menuMissionDisplayLockDuration;
		[Serialize("menuGoLockDuration"                     )] public float menuGoLockDuration;
		[Serialize("RunnerSwipeToStart"                     )] public bool RunnerSwipeToStart;
		[Serialize("CheatButtonNewGame"                     )] public bool CheatButtonNewGame;
		[Serialize("CheatUnlockAdventureMap"                )] public bool CheatUnlockAdventureMap;
		[Serialize("CheatIntroActive"                       )] public bool CheatIntroActive;
		[Serialize("CheatGoToAdventure"                     )] public bool CheatGoToAdventure;
		[Serialize("CheatGoToLeaderboard"                   )] public bool CheatGoToLeaderboard;
		[Serialize("CheatSkipTreeRitual"                    )] public bool CheatSkipTreeRitual;
		[Serialize("CheatInfiniteFood"                      )] public bool CheatInfiniteFood;
		[Serialize("CheatShowMenuTestLoca"                  )] public bool CheatShowMenuTestLoca;
		[Serialize("CheatSkipIntro"                         )] public bool CheatSkipIntro;
		[Serialize("CheatSkipAllIntro"                      )] public bool CheatSkipAllIntro;
		[Serialize("CheatShowForcedCreatureId"              )] public bool CheatShowForcedCreatureId;
		[Serialize("CheatSkipDisclaimer"                    )] public bool CheatSkipDisclaimer;
		[Serialize("CheatPadConnect"                        )] public bool CheatPadConnect;
		[Serialize("CheatFruityBuild"                       )] public bool CheatFruityBuild;
		[Serialize("CheatActiveLeaderboard"                 )] public bool CheatActiveLeaderboard;
		[Serialize("ShareGameplayScreenshotEnabled"         )] public bool ShareGameplayScreenshotEnabled;
		[Serialize("SplineScoreRecapCanvasAppearScale"      )] public Spline SplineScoreRecapCanvasAppearScale;
		[Serialize("wwiseGUID_DefaultErrorSound"            )] public StringID wwiseGUID_DefaultErrorSound;
		[Serialize("minTimeBetweenObservedSessions"         )] public online.TimeInterval minTimeBetweenObservedSessions;
		[Serialize("initialNbSessionsBeforeFacebookProposal")] public uint initialNbSessionsBeforeFacebookProposal;
		[Serialize("nbSessionsBetweenFacebookProposals"     )] public uint nbSessionsBetweenFacebookProposals;
		[Serialize("nbSessionsBeforeMailboxReminder"        )] public uint nbSessionsBeforeMailboxReminder;
		[Serialize("showNewGameButtonDelay"                 )] public float showNewGameButtonDelay;
		[Serialize("PreviewRayman"                          )] public Path PreviewRayman;
		[Serialize("PreviewBarbara"                         )] public Path PreviewBarbara;
		[Serialize("TreeRayman"                             )] public Path TreeRayman;
		[Serialize("TreeBarbara"                            )] public Path TreeBarbara;
		[Serialize("MainMenuStartMusicEvent"                )] public Generic<Event> MainMenuStartMusicEvent;
		[Serialize("restartOnBackgroundDelay"               )] public online.TimeInterval restartOnBackgroundDelay;
		[Serialize("restartOnBackgroundExtendedDelay"       )] public online.TimeInterval restartOnBackgroundExtendedDelay;
		[Serialize("serverTimeTrustDelay"                   )] public online.TimeInterval serverTimeTrustDelay;
		[Serialize("forcedLoadingHintLocId"                 )] public uint forcedLoadingHintLocId;
		[Serialize("SideLumsPath"                           )] public Path SideLumsPath;
		[Serialize("SideTrappedTeensyPath"                  )] public Path SideTrappedTeensyPath;
		[Serialize("SideRocketTeensyPath"                   )] public Path SideRocketTeensyPath;
		[Serialize("SideRocketTeensyFXPath"                 )] public Path SideRocketTeensyFXPath;
		[Serialize("SideJacquouillePath"                    )] public Path SideJacquouillePath;
		[Serialize("SideLumsOffset"                         )] public Vector2 SideLumsOffset;
		[Serialize("SideTrappedTeensyOffset"                )] public Vector2 SideTrappedTeensyOffset;
		[Serialize("SideRocketTeensyOffset"                 )] public Vector2 SideRocketTeensyOffset;
		[Serialize("SideJacquouilleOffset"                  )] public Vector2 SideJacquouilleOffset;
		[Serialize("environmentBrickPath"                   )] public Path environmentBrickPath;
		[Serialize("startBrickPath"                         )] public Path startBrickPath;
		[Serialize("endBrickPath"                           )] public Path endBrickPath;
		[Serialize("firstRightBrickPath"                    )] public Path firstRightBrickPath;
		[Serialize("firstLeftBrickPath"                     )] public Path firstLeftBrickPath;
		[Serialize("defaultDecoBrickPath"                   )] public Path defaultDecoBrickPath;
		[Serialize("costumeEnvironmentBrickPath"            )] public Path costumeEnvironmentBrickPath;
		[Serialize("costumeStartBrickPath"                  )] public Path costumeStartBrickPath;
		[Serialize("costumeEndBrickPath"                    )] public Path costumeEndBrickPath;
		[Serialize("costumeFirstRightBrickPath"             )] public Path costumeFirstRightBrickPath;
		[Serialize("costumeFirstLeftBrickPath"              )] public Path costumeFirstLeftBrickPath;
		[Serialize("additionalCostumesDescription"          )] public CList<RO2_CostumeDescriptor_Template> additionalCostumesDescription;
		[Serialize("teensieCompass"                         )] public Path teensieCompass;
		[Serialize("petRewardSpawnHour"                     )] public uint petRewardSpawnHour;
		[Serialize("homeMapPath"                            )] public Path homeMapPath;
		[Serialize("firstLevelPath"                         )] public Path firstLevelPath;
		[Serialize("benchLevelPath"                         )] public Path benchLevelPath;
		[Serialize("benchLevelPath2"                        )] public Path benchLevelPath2;
		[Serialize("captainPath"                            )] public Path captainPath;
		[Serialize("countdown321GoPath"                     )] public Path countdown321GoPath;
		[Serialize("treeLevelPath"                          )] public Path treeLevelPath;
		[Serialize("firstPlayablePath"                      )] public Path firstPlayablePath;
		[Serialize("firstRitualPath"                        )] public Path firstRitualPath;
		[Serialize("nextRegionMapPath"                      )] public PathRef nextRegionMapPath;
		[Serialize("adversarialSoccerPath"                  )] public PathRef adversarialSoccerPath;
		[Serialize("adversarialSoccerBallPath"              )] public PathRef adversarialSoccerBallPath;
		[Serialize("soccerConfig"                           )] public Path soccerConfig;
		[Serialize("characterSelectionPath"                 )] public Path characterSelectionPath;
		[Serialize("HideNSeekExitManagerPath"               )] public Path HideNSeekExitManagerPath;
		[Serialize("introMoviePath"                         )] public PathRef introMoviePath;
		[Serialize("introMoviePathContainer"                )] public CList<RO2_GameManagerConfig_Template.LocalisedVideo> introMoviePathContainer;
		[Serialize("mainMenuPath"                           )] public Path mainMenuPath;
		[Serialize("creditsPath"                            )] public Path creditsPath;
		[Serialize("endingCreditsPath"                      )] public Path endingCreditsPath;
		[Serialize("logoVideoIntroPath"                     )] public Path logoVideoIntroPath;
		[Serialize("comingSoonVideoPath"                    )] public Path comingSoonVideoPath;
		[Serialize("unlockSaveProgressionPath"              )] public Path unlockSaveProgressionPath;
		[Serialize("costumes"                               )] public CList<RO2_CostumeInfo_Template> costumes;
		[Serialize("scoreRecapPath"                         )] public Path scoreRecapPath;
		[Serialize("duckTransfoSeqMrDarkActorPath"          )] public Path duckTransfoSeqMrDarkActorPath;
		[Serialize("demoTimer"                              )] public float demoTimer;
		[Serialize("demoInactivityTimer"                    )] public float demoInactivityTimer;
		[Serialize("demoEndMenuTimer"                       )] public float demoEndMenuTimer;
		[Serialize("menulookDRCScreenDisplayDuration"       )] public float menulookDRCScreenDisplayDuration;
		[Serialize("menuAutoMurphyScreenDisplayDuration"    )] public float menuAutoMurphyScreenDisplayDuration;
		[Serialize("timeAttackTimerPath"                    )] public Path timeAttackTimerPath;
		[Serialize("timeAttackRetryDelay"                   )] public float timeAttackRetryDelay;
		[Serialize("takePauseScreenshot"                    )] public bool takePauseScreenshot;
		[Serialize("pauseScreenshotWidth"                   )] public uint pauseScreenshotWidth;
		[Serialize("pauseScreenshotHeight"                  )] public uint pauseScreenshotHeight;
		[Serialize("nbDeathBeforeGivingHeart"               )] public uint nbDeathBeforeGivingHeart;
		[Serialize("nbDeathBeforeGivingAnotherHeart"        )] public uint nbDeathBeforeGivingAnotherHeart;
		[Serialize("nbDeathBeforeSkip"                      )] public uint nbDeathBeforeSkip;
		[Serialize("playerInactivityTime"                   )] public float playerInactivityTime;
		[Serialize("playerInactivityBlinkingTime"           )] public float playerInactivityBlinkingTime;
		[Serialize("invasionCountdown"                      )] public Path invasionCountdown;
		[Serialize("levelsInfo"                             )] public CList<RO2_GameManagerConfig_Template.MapConfig> levelsInfo;
		[Serialize("worldsInfo"                             )] public CList<RO2_GameManagerConfig_Template.WorldConfig> worldsInfo;
		[Serialize("invasionsInfo"                          )] public CList<RO2_GameManagerConfig_Template.InvasionConfig> invasionsInfo;
		[Serialize("lockData"                               )] public CList<RO2_GameManagerConfig_Template.LockDataClass> lockData;
		[Serialize("tagText"                                )] public CList<RO2_GameManagerConfig_Template.TagTextClass> tagText;
		[Serialize("luckyTicketUnlockList"                  )] public CList<RO2_GameManagerConfig_Template.LuckyTicketUnlock> luckyTicketUnlockList;
		[Serialize("rewardsPerWorldCompletion"              )] public CList<RO2_GameManagerConfig_Template.RewardPerWorldCompletion> rewardsPerWorldCompletion;
		[Serialize("invasionMusicMenuSuccess"               )] public Generic<Event> invasionMusicMenuSuccess;
		[Serialize("invasionMusicMenuBestScore"             )] public Generic<Event> invasionMusicMenuBestScore;
		[Serialize("invasionMusicMenuLoose"                 )] public Generic<Event> invasionMusicMenuLoose;
		[Serialize("pets"                                   )] public CList<RO2_GameManagerConfig_Template.Pet> pets;
		[Serialize("darkRaymanID"                           )] public StringID darkRaymanID;
		[Serialize("initialBeatbox"                         )] public RLC_BeatboxDataList initialBeatbox;
		[Serialize("TextIcons"                              )] public CMap<string, Path> TextIcons;
		[Serialize("TextMultiIcons"                         )] public CMap<string, MultiplePath> TextMultiIcons;
		[Serialize("saveRegionDefaultPath"                  )] public Path saveRegionDefaultPath;
		[Serialize("loadingCharacterShadowGFX"              )] public GFXPrimitiveParam loadingCharacterShadowGFX;
		[Serialize("loadingCharacterDefaultPath"            )] public Path loadingCharacterDefaultPath;
		[Serialize("versionNumber"                          )] public string versionNumber;
		[Serialize("newsButton_iOS"                         )] public bool newsButton_iOS;
		[Serialize("newsButton_tvOS"                        )] public bool newsButton_tvOS;
		[Serialize("newsButton_android"                     )] public bool newsButton_android;
		[Serialize("packageDirectories"                     )] public CList<Path> packageDirectories;
		[Serialize("environmentBrickPaths"                  )] public CList<Path> environmentBrickPaths;
		[Serialize("costumeEnvironmentBrickPaths"           )] public CList<Path> costumeEnvironmentBrickPaths;
		[Serialize("ps3HddIntroMoviePathContainer"          )] public CList<RO2_GameManagerConfig_Template.LocalisedVideo> ps3HddIntroMoviePathContainer;
		[Serialize("demoTrailerMoviePathContainer"          )] public CList<Path> demoTrailerMoviePathContainer;
		[Serialize("scoreRecapChallengePath"                )] public Path scoreRecapChallengePath;
		[Serialize("catchTheAllMaps"                        )] public CList<Path> catchTheAllMaps;
		[Serialize("debugmapslist"                          )] public CList<Path> debugmapslist;
		[Serialize("packages"                               )] public CList<Path> packages;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(playerConfig));
				SerializeField(s, nameof(gameplayCameraPath));
				SerializeField(s, nameof(remoteCameraPath));
				SerializeField(s, nameof(defaultLoadingPath));
				SerializeField(s, nameof(defaultInteractiveLoadingScreenPath));
				SerializeField(s, nameof(movieLoadingScreenPath));
				SerializeField(s, nameof(fadeWorldPath));
				SerializeField(s, nameof(packageDirectories));
				SerializeField(s, nameof(environmentBrickPath));
				SerializeField(s, nameof(environmentBrickPaths));
				SerializeField(s, nameof(startBrickPath));
				SerializeField(s, nameof(endBrickPath));
				SerializeField(s, nameof(firstRightBrickPath));
				SerializeField(s, nameof(firstLeftBrickPath));
				SerializeField(s, nameof(defaultDecoBrickPath));
				SerializeField(s, nameof(costumeEnvironmentBrickPath));
				SerializeField(s, nameof(costumeEnvironmentBrickPaths));
				SerializeField(s, nameof(costumeStartBrickPath));
				SerializeField(s, nameof(costumeEndBrickPath));
				SerializeField(s, nameof(costumeFirstRightBrickPath));
				SerializeField(s, nameof(costumeFirstLeftBrickPath));
				SerializeField(s, nameof(additionalCostumesDescription));
				SerializeField(s, nameof(petRewardSpawnHour));
				SerializeField(s, nameof(homeMapPath));
				SerializeField(s, nameof(soccerConfig));
				SerializeField(s, nameof(firstLevelPath), type: typeof(PathRef));
				SerializeField(s, nameof(introMoviePath));
				SerializeField(s, nameof(introMoviePathContainer));
				SerializeField(s, nameof(ps3HddIntroMoviePathContainer));
				SerializeField(s, nameof(demoTrailerMoviePathContainer));
				SerializeField(s, nameof(mainMenuPath));
				SerializeField(s, nameof(creditsPath));
				SerializeField(s, nameof(endingCreditsPath));
				SerializeField(s, nameof(logoVideoIntroPath));
				SerializeField(s, nameof(comingSoonVideoPath));
				SerializeField(s, nameof(unlockSaveProgressionPath));
				SerializeField(s, nameof(costumes));
				SerializeField(s, nameof(scoreRecapPath));
				SerializeField(s, nameof(scoreRecapChallengePath));
				SerializeField(s, nameof(duckTransfoSeqMrDarkActorPath));
				SerializeField(s, nameof(catchTheAllMaps));
				SerializeField(s, nameof(demoTimer));
				SerializeField(s, nameof(demoInactivityTimer));
				SerializeField(s, nameof(demoEndMenuTimer));
				SerializeField(s, nameof(debugmapslist));
				SerializeField(s, nameof(menulookDRCScreenDisplayDuration));
				SerializeField(s, nameof(menuAutoMurphyScreenDisplayDuration));
				SerializeField(s, nameof(timeAttackTimerPath));
				SerializeField(s, nameof(takePauseScreenshot));
				SerializeField(s, nameof(pauseScreenshotWidth));
				SerializeField(s, nameof(pauseScreenshotHeight));
				SerializeField(s, nameof(nbDeathBeforeGivingHeart));
				SerializeField(s, nameof(nbDeathBeforeGivingAnotherHeart));
				SerializeField(s, nameof(nbDeathBeforeSkip));
				SerializeField(s, nameof(playerInactivityTime));
				SerializeField(s, nameof(playerInactivityBlinkingTime));
				SerializeField(s, nameof(invasionCountdown));
				SerializeField(s, nameof(packages));
				SerializeField(s, nameof(levelsInfo));
				SerializeField(s, nameof(worldsInfo));
				SerializeField(s, nameof(invasionsInfo));
				SerializeField(s, nameof(lockData));
				SerializeField(s, nameof(tagText));
				SerializeField(s, nameof(luckyTicketUnlockList));
				SerializeField(s, nameof(rewardsPerWorldCompletion));
				SerializeField(s, nameof(invasionMusicMenuSuccess));
				SerializeField(s, nameof(invasionMusicMenuBestScore));
				SerializeField(s, nameof(invasionMusicMenuLoose));
				SerializeField(s, nameof(pets));
				SerializeField(s, nameof(darkRaymanID));
			} else {
				SerializeField(s, nameof(playerConfig));
				SerializeField(s, nameof(gameplayCameraPath));
				SerializeField(s, nameof(remoteCameraPath));
				SerializeField(s, nameof(defaultLoadingPath));
				SerializeField(s, nameof(defaultInteractiveLoadingScreenPath));
				SerializeField(s, nameof(movieLoadingScreenPath));
				SerializeField(s, nameof(fadeWorldPath));
				SerializeField(s, nameof(baseWorldPath));
				SerializeField(s, nameof(defaultGameplayCameraPath));
				SerializeField(s, nameof(exploGameplayCameraPath));
				SerializeField(s, nameof(treeCameraPath));
				SerializeField(s, nameof(adventureCameraPath));
				SerializeField(s, nameof(scrollableCameraPath));
				SerializeField(s, nameof(leaderboardCameraPath));
				SerializeField(s, nameof(LuckyTicketLevelPath));
				SerializeField(s, nameof(GoldenLuckyTicketLevelPath));
				SerializeField(s, nameof(ChocolateLuckyTicketLevelPath));
				SerializeField(s, nameof(ChallengeLuckyTicketLevelPath));
				SerializeField(s, nameof(menuMissionDisplayLockDuration));
				SerializeField(s, nameof(menuGoLockDuration));
				SerializeField(s, nameof(RunnerSwipeToStart));
				SerializeField(s, nameof(CheatButtonNewGame));
				SerializeField(s, nameof(CheatUnlockAdventureMap));
				SerializeField(s, nameof(CheatIntroActive));
				SerializeField(s, nameof(CheatGoToAdventure));
				SerializeField(s, nameof(CheatGoToLeaderboard));
				SerializeField(s, nameof(CheatSkipTreeRitual));
				SerializeField(s, nameof(CheatInfiniteFood));
				SerializeField(s, nameof(CheatShowMenuTestLoca));
				SerializeField(s, nameof(CheatSkipIntro));
				SerializeField(s, nameof(CheatSkipAllIntro));
				SerializeField(s, nameof(CheatShowForcedCreatureId));
				SerializeField(s, nameof(CheatSkipDisclaimer));
				SerializeField(s, nameof(CheatPadConnect));
				SerializeField(s, nameof(CheatFruityBuild));
				SerializeField(s, nameof(CheatActiveLeaderboard));
				SerializeField(s, nameof(ShareGameplayScreenshotEnabled));
				SerializeField(s, nameof(SplineScoreRecapCanvasAppearScale));
				SerializeField(s, nameof(wwiseGUID_DefaultErrorSound));
				SerializeField(s, nameof(minTimeBetweenObservedSessions));
				SerializeField(s, nameof(initialNbSessionsBeforeFacebookProposal));
				SerializeField(s, nameof(nbSessionsBetweenFacebookProposals));
				SerializeField(s, nameof(nbSessionsBeforeMailboxReminder));
				SerializeField(s, nameof(showNewGameButtonDelay));
				SerializeField(s, nameof(PreviewRayman));
				SerializeField(s, nameof(PreviewBarbara));
				SerializeField(s, nameof(TreeRayman));
				SerializeField(s, nameof(TreeBarbara));
				SerializeField(s, nameof(MainMenuStartMusicEvent));
				SerializeField(s, nameof(restartOnBackgroundDelay));
				SerializeField(s, nameof(restartOnBackgroundExtendedDelay));
				SerializeField(s, nameof(serverTimeTrustDelay));
				SerializeField(s, nameof(forcedLoadingHintLocId));
				SerializeField(s, nameof(SideLumsPath));
				SerializeField(s, nameof(SideTrappedTeensyPath));
				SerializeField(s, nameof(SideRocketTeensyPath));
				SerializeField(s, nameof(SideRocketTeensyFXPath));
				SerializeField(s, nameof(SideJacquouillePath));
				SerializeField(s, nameof(SideLumsOffset));
				SerializeField(s, nameof(SideTrappedTeensyOffset));
				SerializeField(s, nameof(SideRocketTeensyOffset));
				SerializeField(s, nameof(SideJacquouilleOffset));
				SerializeField(s, nameof(environmentBrickPath));
				SerializeField(s, nameof(startBrickPath));
				SerializeField(s, nameof(endBrickPath));
				SerializeField(s, nameof(firstRightBrickPath));
				SerializeField(s, nameof(firstLeftBrickPath));
				SerializeField(s, nameof(defaultDecoBrickPath));
				SerializeField(s, nameof(costumeEnvironmentBrickPath));
				SerializeField(s, nameof(costumeStartBrickPath));
				SerializeField(s, nameof(costumeEndBrickPath));
				SerializeField(s, nameof(costumeFirstRightBrickPath));
				SerializeField(s, nameof(costumeFirstLeftBrickPath));
				SerializeField(s, nameof(additionalCostumesDescription));
				SerializeField(s, nameof(teensieCompass));
				SerializeField(s, nameof(petRewardSpawnHour));
				SerializeField(s, nameof(homeMapPath));
				SerializeField(s, nameof(firstLevelPath));
				SerializeField(s, nameof(benchLevelPath));
				SerializeField(s, nameof(benchLevelPath2));
				SerializeField(s, nameof(captainPath));
				SerializeField(s, nameof(countdown321GoPath));
				SerializeField(s, nameof(treeLevelPath));
				SerializeField(s, nameof(firstPlayablePath));
				SerializeField(s, nameof(firstRitualPath));
				SerializeField(s, nameof(nextRegionMapPath));
				SerializeField(s, nameof(adversarialSoccerPath));
				SerializeField(s, nameof(adversarialSoccerBallPath));
				SerializeField(s, nameof(soccerConfig));
				SerializeField(s, nameof(characterSelectionPath));
				SerializeField(s, nameof(HideNSeekExitManagerPath));
				SerializeField(s, nameof(introMoviePath));
				SerializeField(s, nameof(introMoviePathContainer));
				SerializeField(s, nameof(mainMenuPath));
				SerializeField(s, nameof(creditsPath));
				SerializeField(s, nameof(endingCreditsPath));
				SerializeField(s, nameof(logoVideoIntroPath));
				SerializeField(s, nameof(comingSoonVideoPath));
				SerializeField(s, nameof(unlockSaveProgressionPath));
				SerializeField(s, nameof(costumes));
				SerializeField(s, nameof(scoreRecapPath));
				SerializeField(s, nameof(duckTransfoSeqMrDarkActorPath));
				SerializeField(s, nameof(demoTimer));
				SerializeField(s, nameof(demoInactivityTimer));
				SerializeField(s, nameof(demoEndMenuTimer));
				SerializeField(s, nameof(menulookDRCScreenDisplayDuration));
				SerializeField(s, nameof(menuAutoMurphyScreenDisplayDuration));
				SerializeField(s, nameof(timeAttackTimerPath));
				SerializeField(s, nameof(timeAttackRetryDelay));
				SerializeField(s, nameof(takePauseScreenshot));
				SerializeField(s, nameof(pauseScreenshotWidth));
				SerializeField(s, nameof(pauseScreenshotHeight));
				SerializeField(s, nameof(nbDeathBeforeGivingHeart));
				SerializeField(s, nameof(nbDeathBeforeGivingAnotherHeart));
				SerializeField(s, nameof(nbDeathBeforeSkip));
				SerializeField(s, nameof(playerInactivityTime));
				SerializeField(s, nameof(playerInactivityBlinkingTime));
				SerializeField(s, nameof(invasionCountdown));
				SerializeField(s, nameof(levelsInfo));
				SerializeField(s, nameof(worldsInfo));
				SerializeField(s, nameof(invasionsInfo));
				SerializeField(s, nameof(lockData));
				SerializeField(s, nameof(tagText));
				SerializeField(s, nameof(luckyTicketUnlockList));
				SerializeField(s, nameof(rewardsPerWorldCompletion));
				SerializeField(s, nameof(invasionMusicMenuSuccess));
				SerializeField(s, nameof(invasionMusicMenuBestScore));
				SerializeField(s, nameof(invasionMusicMenuLoose));
				SerializeField(s, nameof(pets));
				SerializeField(s, nameof(darkRaymanID));
				SerializeField(s, nameof(initialBeatbox));
				SerializeField(s, nameof(TextIcons));
				SerializeField(s, nameof(TextMultiIcons));
				SerializeField(s, nameof(saveRegionDefaultPath));
				SerializeField(s, nameof(loadingCharacterShadowGFX));
				SerializeField(s, nameof(loadingCharacterDefaultPath));
				SerializeField(s, nameof(versionNumber));
				SerializeField(s, nameof(newsButton_iOS));
				SerializeField(s, nameof(newsButton_tvOS));
				SerializeField(s, nameof(newsButton_android));
			}
		}
		[Games(GameFlags.RA)]
		public partial class LockDataClass : CSerializable {
			[Serialize("tag"         )] public StringID tag;
			[Serialize("lockType"    )] public MapLockType lockType;
			[Serialize("lockCount"   )] public uint lockCount;
			[Serialize("parent"      )] public StringID parent;
			[Serialize("behaviorType")] public NodeBehaviorType behaviorType;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(lockType));
				SerializeField(s, nameof(lockCount));
				SerializeField(s, nameof(parent));
				SerializeField(s, nameof(behaviorType));
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
			[Serialize("visualId"   )] public uint visualId;
			[Serialize("probability")] public uint probability;
			[Serialize("type"       )] public uint type;
			[Serialize("family"     )] public StringID family;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(visualId));
				SerializeField(s, nameof(probability));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(family));
			}
		}
		[Games(GameFlags.RA)]
		public partial class RewardPerWorldCompletion : CSerializable {
			[Serialize("lastMapID"        )] public StringID lastMapID;
			[Serialize("luckyTicketReward")] public uint luckyTicketReward;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(lastMapID));
				SerializeField(s, nameof(luckyTicketReward));
			}
		}
		[Games(GameFlags.RA)]
		public partial class WorldConfig : CSerializable {
			[Serialize("tag"                     )] public StringID tag;
			[Serialize("teensyUnlockCountRetro1" )] public uint teensyUnlockCountRetro1;
			[Serialize("teensyUnlockCountRetro2" )] public uint teensyUnlockCountRetro2;
			[Serialize("teensyUnlockCountCostume")] public uint teensyUnlockCountCostume;
			[Serialize("interactiveLoadingPath"  )] public Path interactiveLoadingPath;
			[Serialize("defaultScoreRecapPath"   )] public Path defaultScoreRecapPath;
			[Serialize("presence"                )] public StringID presence;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(teensyUnlockCountRetro1));
				SerializeField(s, nameof(teensyUnlockCountRetro2));
				SerializeField(s, nameof(teensyUnlockCountCostume));
				SerializeField(s, nameof(interactiveLoadingPath));
				SerializeField(s, nameof(defaultScoreRecapPath));
				SerializeField(s, nameof(presence));
			}
		}
		[Games(GameFlags.RA)]
		public partial class LocalisedVideo : CSerializable {
			[Serialize("language"  )] public Enum_language language;
			[Serialize("video"     )] public Path video;
			[Serialize("audioTrack")] public int audioTrack;
			[Serialize("videoTrack")] public int videoTrack;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(language));
				SerializeField(s, nameof(video));
				SerializeField(s, nameof(audioTrack));
				SerializeField(s, nameof(videoTrack));
			}
			public enum Enum_language {
			}
		}
		[Games(GameFlags.RA)]
		public partial class TagTextClass : CSerializable {
			[Serialize("tag"  )] public StringID tag;
			[Serialize("locID")] public LocalisationId locID;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(locID));
			}
		}
		[Games(GameFlags.RA)]
		public partial class MapConfig : CSerializable {
			[Serialize("tag"              )] public StringID tag;
			[Serialize("worldTag"         )] public StringID worldTag;
			[Serialize("teensyUnlockCount")] public int teensyUnlockCount;
			[Serialize("mapPath"          )] public PathRef mapPath;
			[Serialize("mapPathAM"        )] public PathRef mapPathAM;
			[Serialize("mapNameId"        )] public LocalisationId mapNameId;
			[Serialize("texturePath"      )] public Path texturePath;
			[Serialize("teensyCount"      )] public TeensyCount teensyCount;
			[Serialize("maxLumsCount"     )] public uint maxLumsCount;
			[Serialize("horizontal"       )] public bool horizontal;
			[Serialize("difficulty"       )] public uint difficulty;
			[Serialize("mapLockType"      )] public MapLockType mapLockType;
			[Serialize("scoreRecapPath"   )] public Path scoreRecapPath;
			[Serialize("loading"          )] public Path loading;
			[Serialize("loadingOut"       )] public Path loadingOut;
			[Serialize("startLeft"        )] public bool startLeft;
			[Serialize("mapType"          )] public MAPTYPE mapType;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(worldTag));
				SerializeField(s, nameof(teensyUnlockCount));
				SerializeField(s, nameof(mapPath));
				SerializeField(s, nameof(mapPathAM));
				SerializeField(s, nameof(mapNameId));
				SerializeField(s, nameof(texturePath));
				SerializeField(s, nameof(teensyCount));
				SerializeField(s, nameof(maxLumsCount));
				SerializeField(s, nameof(horizontal));
				SerializeField(s, nameof(difficulty));
				SerializeField(s, nameof(mapLockType));
				SerializeField(s, nameof(scoreRecapPath));
				SerializeField(s, nameof(loading));
				SerializeField(s, nameof(loadingOut));
				SerializeField(s, nameof(startLeft));
				SerializeField(s, nameof(mapType));
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
			[Serialize("mapID")] public uint mapID;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(mapID));
			}
		}
		[Games(GameFlags.RA)]
		public partial class InvasionConfig : CSerializable {
			[Serialize("invadedMapTag"  )] public StringID invadedMapTag;
			[Serialize("invasionMapTag" )] public StringID invasionMapTag;
			[Serialize("invaderMapTag"  )] public StringID invaderMapTag;
			[Serialize("teensyCount"    )] public uint teensyCount;
			[Serialize("misterDarkCount")] public uint misterDarkCount;
			[Serialize("musicModeList"  )] public CArray<Generic<Event>> musicModeList;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(invadedMapTag));
				SerializeField(s, nameof(invasionMapTag));
				SerializeField(s, nameof(invaderMapTag));
				SerializeField(s, nameof(teensyCount));
				SerializeField(s, nameof(misterDarkCount));
				SerializeField(s, nameof(musicModeList));
			}
		}
		public override uint? ClassCRC => 0x8BE3B34A;
	}
}

