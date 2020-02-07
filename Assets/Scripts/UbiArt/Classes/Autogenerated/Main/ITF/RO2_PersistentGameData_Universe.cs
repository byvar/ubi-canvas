using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PersistentGameData_Universe : PersistentGameData_Universe {
		[Serialize("score"                                        )] public RO2_PersistentGameData_Score score;
		[Serialize("bubbleDreamer"                                )] public RO2_PersistentGameData_BubbleDreamerData bubbleDreamer;
		[Serialize("unlockedPets"                                 )] public CArray<int> unlockedPets;
		[Serialize("petsDailyReward"                              )] public CList<RO2_PersistentGameData_Universe.petRewardData> petsDailyReward;
		[Serialize("unlockedCupsForPets"                          )] public CList<RO2_PersistentGameData_Universe.st_petCups> unlockedCupsForPets;
		[Serialize("givenPetCount"                                )] public uint givenPetCount;
		[Serialize("newPetsUnlocked"                              )] public bool newPetsUnlocked;
		[Serialize("firstPetShown"                                )] public bool firstPetShown;
		[Serialize("hasShownMessageAllPet"                        )] public bool hasShownMessageAllPet;
		[Serialize("messagesTotalCount"                           )] public uint messagesTotalCount;
		[Serialize("messages_onlineDate"                          )] public online.DateTime messages_onlineDate;
		[Serialize("messages_localDate"                           )] public online.DateTime messages_localDate;
		[Serialize("messages_readDrcCount"                        )] public uint messages_readDrcCount;
		[Serialize("messages_interactDrcCount"                    )] public uint messages_interactDrcCount;
		[Serialize("messages_lastSeenMessageHandle"               )] public uint messages_lastSeenMessageHandle;
		[Serialize("messages_tutoCount"                           )] public uint messages_tutoCount;
		[Serialize("messages_drcCountSinceLastInteract"           )] public uint messages_drcCountSinceLastInteract;
		[Serialize("playerCard_displayedCount"                    )] public uint playerCard_displayedCount;
		[Serialize("playerCard_tutoSeen"                          )] public bool playerCard_tutoSeen;
		[Serialize("gameCompleted"                                )] public bool gameCompleted;
		[Serialize("timeToCompleteGameInSec"                      )] public uint timeToCompleteGameInSec;
		[Serialize("timeSpendInGameInSec"                         )] public uint timeSpendInGameInSec;
		[Serialize("teensiesBonusCounter"                         )] public uint teensiesBonusCounter;
		[Serialize("luckyTicketsCounter"                          )] public uint luckyTicketsCounter;
		[Serialize("luckyTicketLevelCount"                        )] public uint luckyTicketLevelCount;
		[Serialize("retroMapUnlockedCounter"                      )] public uint retroMapUnlockedCounter;
		[Serialize("catchEmAllIndex"                              )] public uint catchEmAllIndex;
		[Serialize("newUnlockedDoor"                              )] public CList<RO2_PersistentGameData_Universe.UnlockedDoor> newUnlockedDoor;
		[Serialize("luckyTicketRewardList"                        )] public CList<RO2_PersistentGameData_Universe.RO2_LuckyTicketReward> luckyTicketRewardList;
		[Serialize("nodeData"                                     )] public CList<RO2_PersistentGameData_Universe.NodeDataStruct> nodeData;
		[Serialize("luckyTicketsRewardGivenCounter"               )] public uint luckyTicketsRewardGivenCounter;
		[Serialize("consecutiveLuckyTicketCount"                  )] public uint consecutiveLuckyTicketCount;
		[Serialize("ticketReminderMessageCount"                   )] public uint ticketReminderMessageCount;
		[Serialize("displayGhosts"                                )] public uint displayGhosts;
		[Serialize("uplayDoneAction0"                             )] public bool uplayDoneAction0;
		[Serialize("uplayDoneAction1"                             )] public bool uplayDoneAction1;
		[Serialize("uplayDoneAction2"                             )] public bool uplayDoneAction2;
		[Serialize("uplayDoneAction3"                             )] public bool uplayDoneAction3;
		[Serialize("uplayDoneAction4"                             )] public bool uplayDoneAction4;
		[Serialize("uplayDoneReward0"                             )] public bool uplayDoneReward0;
		[Serialize("uplayDoneReward1"                             )] public bool uplayDoneReward1;
		[Serialize("uplayDoneReward2"                             )] public bool uplayDoneReward2;
		[Serialize("uplayDoneReward3"                             )] public bool uplayDoneReward3;
		[Serialize("playedChallenge"                              )] public CList<uint> playedChallenge;
		[Serialize("tvOffOptionEnabledNb"                         )] public uint tvOffOptionEnabledNb;
		[Serialize("tvOffOptionActivatedTime"                     )] public uint tvOffOptionActivatedTime;
		[Serialize("barbaraCostumeUnlockSeen"                     )] public bool barbaraCostumeUnlockSeen;
		[Serialize("retroWorldUnlockMessageSeen"                  )] public bool retroWorldUnlockMessageSeen;
		[Serialize("freedAllTeensiesMessageSeen"                  )] public bool freedAllTeensiesMessageSeen;
		[Serialize("MisterDarkCompletionMessageSeen"              )] public bool MisterDarkCompletionMessageSeen;
		[Serialize("FirstInvasionMessageSeen"                     )] public bool FirstInvasionMessageSeen;
		[Serialize("InvitationTutoSeen"                           )] public bool InvitationTutoSeen;
		[Serialize("MessageSeen8Bit"                              )] public bool MessageSeen8Bit;
		[Serialize("challengeWorldUnlockMessageSeen"              )] public bool challengeWorldUnlockMessageSeen;
		[Serialize("luckyTicketRewardWorldName"                   )] public StringID luckyTicketRewardWorldName;
		[Serialize("isUGCMiiverseWarningSet"                      )] public bool isUGCMiiverseWarningSet;
		[Serialize("unlockPrivilegesData"                         )] public string unlockPrivilegesData;
		[Serialize("prisonerDataDummy"                            )] public PrisonerData prisonerDataDummy;
		[Serialize("persistentGameDataLevelDummy"                 )] public RO2_PersistentGameData_Level persistentGameDataLevelDummy;
		[Serialize("unlockedDoorDummy"                            )] public RO2_PersistentGameData_Universe.UnlockedDoor unlockedDoorDummy;
		[Serialize("bubbleDreamerDataDummy"                       )] public RO2_PersistentGameData_BubbleDreamerData bubbleDreamerDataDummy;
		[Serialize("dummmyNodeData"                               )] public RO2_PersistentGameData_Universe.NodeDataStruct dummmyNodeData;
		[Serialize("adventureNodeDataList"                        )] public CList<RO2_PersistentGameData_Universe.RLC_AdventureNodeData> adventureNodeDataList;
		[Serialize("introCompleted"                               )] public bool introCompleted;
		[Serialize("introCreatureHatched"                         )] public bool introCreatureHatched;
		[Serialize("devTeam"                                      )] public bool devTeam;
		[Serialize("onboardingCompleted"                          )] public bool onboardingCompleted;
		[Serialize("gameStartDateTime"                            )] public online.DateTime gameStartDateTime;
		[Serialize("globalSessionNb"                              )] public uint globalSessionNb;
		[Serialize("isNotificationConfirmationDialogShown"        )] public bool isNotificationConfirmationDialogShown;
		[Serialize("foodAcquiredNbLtd"                            )] public uint foodAcquiredNbLtd;
		[Serialize("foodRefillStartDate"                          )] public online.DateTime foodRefillStartDate;
		[Serialize("gemsAcquiredNbLtd"                            )] public uint gemsAcquiredNbLtd;
		[Serialize("MglassAcquiredNbLtd"                          )] public uint MglassAcquiredNbLtd;
		[Serialize("MGlassBoughtWithGemsNbLtd"                    )] public uint MGlassBoughtWithGemsNbLtd;
		[Serialize("rewardedVideoNbLtd"                           )] public uint rewardedVideoNbLtd;
		[Serialize("everyPlaySharedVideoNbLtd"                    )] public uint everyPlaySharedVideoNbLtd;
		[Serialize("gemsUsedNbLtd"                                )] public uint gemsUsedNbLtd;
		[Serialize("nbMailboxReadLtd"                             )] public uint nbMailboxReadLtd;
		[Serialize("characterSelectionNb"                         )] public uint characterSelectionNb;
		[Serialize("adventureSessionNb"                           )] public uint adventureSessionNb;
		[Serialize("adventureId"                                  )] public uint adventureId;
		[Serialize("skipAdventure"                                )] public bool skipAdventure;
		[Serialize("adventureStartDate"                           )] public online.DateTime adventureStartDate;
		[Serialize("adventureLifeTimeInSec"                       )] public ulong adventureLifeTimeInSec;
		[Serialize("adventureDefaultLifeTimeInSec"                )] public ulong adventureDefaultLifeTimeInSec;
		[Serialize("timeLimitedAdventureTutorialShown"            )] public uint timeLimitedAdventureTutorialShown;
		[Serialize("timeLimitedAdventureCompleteInTime"           )] public uint timeLimitedAdventureCompleteInTime;
		[Serialize("timeLimitedAdventureRewardCredited"           )] public bool timeLimitedAdventureRewardCredited;
		[Serialize("adventureRenderParamIndex"                    )] public uint adventureRenderParamIndex;
		[Serialize("adventureNewGameDone"                         )] public bool adventureNewGameDone;
		[Serialize("adventureGlobalIndex"                         )] public uint adventureGlobalIndex;
		[Serialize("adventurePath"                                )] public Path adventurePath;
		[Serialize("adventureCharlieFound"                        )] public bool adventureCharlieFound;
		[Serialize("totalCharlieFound"                            )] public uint totalCharlieFound;
		[Serialize("tutorialCharlieFound"                         )] public bool tutorialCharlieFound;
		[Serialize("tutorialCharlieOptionalFound"                 )] public bool tutorialCharlieOptionalFound;
		[Serialize("tutorialFeedInGoScreenFound"                  )] public bool tutorialFeedInGoScreenFound;
		[Serialize("newElixirDialogAlreadySeen"                   )] public bool newElixirDialogAlreadySeen;
		[Serialize("adventureFinishedAlreadyDisplayed"            )] public bool adventureFinishedAlreadyDisplayed;
		[Serialize("adventureCompleteAlreadyDisplayed"            )] public bool adventureCompleteAlreadyDisplayed;
		[Serialize("joinDate"                                     )] public online.DateTime joinDate;
		[Serialize("iapScore"                                     )] public uint iapScore;
		[Serialize("originalDeviceId"                             )] public string originalDeviceId;
		[Serialize("spinCount"                                    )] public uint spinCount;
		[Serialize("levelTryCount"                                )] public uint levelTryCount;
		[Serialize("challengeWheelRewardType"                     )] public uint challengeWheelRewardType;
		[Serialize("challengeWheelMapType"                        )] public uint challengeWheelMapType;
		[Serialize("challengeWheelLevelType"                      )] public uint challengeWheelLevelType;
		[Serialize("challengeWheelMapPath"                        )] public PathRef challengeWheelMapPath;
		[Serialize("challengeWheelMapResult"                      )] public uint challengeWheelMapResult;
		[Serialize("challengeWheelCompleteTime"                   )] public ulong challengeWheelCompleteTime;
		[Serialize("challengeWheelIntroPopupShowTimeInSec"        )] public ulong challengeWheelIntroPopupShowTimeInSec;
		[Serialize("needToShowSeasonalEventExclamation"           )] public bool needToShowSeasonalEventExclamation;
		[Serialize("endLessRunnerEventIntroPopupShowTimeInSec"    )] public ulong endLessRunnerEventIntroPopupShowTimeInSec;
		[Serialize("m_FacebookBenefitsShownFoeEventID"            )] public uint m_FacebookBenefitsShownFoeEventID;
		[Serialize("isScratchingFirstLuckyTicket"                 )] public bool isScratchingFirstLuckyTicket;
		[Serialize("isScratchingSecondLuckyTicket"                )] public bool isScratchingSecondLuckyTicket;
		[Serialize("tutoLuckyTicketHasBeenConsumed"               )] public bool tutoLuckyTicketHasBeenConsumed;
		[Serialize("shopAlreadyOpened"                            )] public bool shopAlreadyOpened;
		[Serialize("facebookBenefitsAlreadyProposed"              )] public bool facebookBenefitsAlreadyProposed;
		[Serialize("facebookBenefitsAlreadyOpened"                )] public bool facebookBenefitsAlreadyOpened;
		[Serialize("adventureCharlieCountdown"                    )] public uint adventureCharlieCountdown;
		[Serialize("bonusMapCountDown"                            )] public uint bonusMapCountDown;
		[Serialize("challengeMapCountDown"                        )] public uint challengeMapCountDown;
		[Serialize("playerCostumeSkin"                            )] public StringID playerCostumeSkin;
		[Serialize("dailyObjectiveRefreshDate"                    )] public online.DateTime dailyObjectiveRefreshDate;
		[Serialize("lastTokenRefreshDate"                         )] public online.DateTime lastTokenRefreshDate;
		[Serialize("lastEventBundleUIShownTime"                   )] public ulong lastEventBundleUIShownTime;
		[Serialize("amarCreaturesEndDate"                         )] public online.DateTime amarCreaturesEndDate;
		[Serialize("lastOpenedChallengeSeed"                      )] public uint lastOpenedChallengeSeed;
		[Serialize("lastChallengeSeed"                            )] public uint lastChallengeSeed;
		[Serialize("dailyChallengeBestScore"                      )] public uint dailyChallengeBestScore;
		[Serialize("dailyChallengeBestDistance"                   )] public uint dailyChallengeBestDistance;
		[Serialize("lastChallengeTombs"                           )] public CArray<Vector3> lastChallengeTombs;
		[Serialize("dailyChallengeTicketPiecesState0"             )] public uint dailyChallengeTicketPiecesState0;
		[Serialize("dailyChallengeTicketPiecesState1"             )] public uint dailyChallengeTicketPiecesState1;
		[Serialize("dailyChallengeTicketPiecesState2"             )] public uint dailyChallengeTicketPiecesState2;
		[Serialize("dailyChallengeTicketCollected"                )] public bool dailyChallengeTicketCollected;
		[Serialize("retryPostDailyChallengeScore"                 )] public uint retryPostDailyChallengeScore;
		[Serialize("missionDataList"                              )] public CList<RO2_PersistentGameData_Universe.RLC_MissionData> missionDataList;
		[Serialize("creatureDataList"                             )] public CList<RO2_PersistentGameData_Universe.RLC_CreatureData> creatureDataList;
		[Serialize("currentCreatureData"                          )] public RO2_PersistentGameData_Universe.RLC_CreatureData currentCreatureData;
		[Serialize("nbHatchedEggsSinceLastNewCreature"            )] public uint nbHatchedEggsSinceLastNewCreature;
		[Serialize("awayLongEnoughToHatchNewCreature"             )] public bool awayLongEnoughToHatchNewCreature;
		[Serialize("hatchFailCounter_NewCreature"                 )] public uint hatchFailCounter_NewCreature;
		[Serialize("hatchFailCounter_Queen"                       )] public uint hatchFailCounter_Queen;
		[Serialize("adventureEggData"                             )] public RO2_PersistentGameData_Universe.RLC_EggData adventureEggData;
		[Serialize("mb_needRequestStartNextAdventureParam"        )] public bool mb_needRequestStartNextAdventureParam;
		[Serialize("incubatorEggData"                             )] public RO2_PersistentGameData_Universe.RLC_EggData incubatorEggData;
		[Serialize("incubatorElixirUtilisations"                  )] public CList<RO2_PersistentGameData_Universe.RLC_ElixirUtilisation> incubatorElixirUtilisations;
		[Serialize("incubatorEggAdventureSequence"                )] public uint incubatorEggAdventureSequence;
		[Serialize("eggHatchingComplete"                          )] public bool eggHatchingComplete;
		[Serialize("eggFirstTapComplete"                          )] public bool eggFirstTapComplete;
		[Serialize("lastEggHatchingTimeSkipped"                   )] public bool lastEggHatchingTimeSkipped;
		[Serialize("incubatorDateTimeEggHatchingComplete"         )] public online.DateTime incubatorDateTimeEggHatchingComplete;
		[Serialize("lastSavedGameDateTime"                        )] public online.DateTime lastSavedGameDateTime;
		[Serialize("incubationDuration"                           )] public float incubationDuration;
		[Serialize("StartValuesSet"                               )] public bool StartValuesSet;
		[Serialize("menuOptionSave"                               )] public RO2_PersistentGameData_Universe.RLC_MenuOptionSave menuOptionSave;
		[Serialize("languageArabicPopupDisplayed"                 )] public bool languageArabicPopupDisplayed;
		[Serialize("CostumePlayTime"                              )] public CList<RO2_PersistentGameData_Universe.RLC_CostumePlayTime> CostumePlayTime;
		[Serialize("globalPlayTime"                               )] public float globalPlayTime;
		[Serialize("adventurePlayTime"                            )] public float adventurePlayTime;
		[Serialize("adventureStep"                                )] public uint adventureStep;
		[Serialize("adventureStepPlayTime"                        )] public float adventureStepPlayTime;
		[Serialize("adventureBoatState"                           )] public Enum_adventureBoatState adventureBoatState;
		[Serialize("TreePlayTime"                                 )] public float TreePlayTime;
		[Serialize("BeatBoxPlayTime"                              )] public float BeatBoxPlayTime;
		[Serialize("shopPlayTime"                                 )] public float shopPlayTime;
		[Serialize("shopFoodPlayTime"                             )] public float shopFoodPlayTime;
		[Serialize("shopElixirPlayTime"                           )] public float shopElixirPlayTime;
		[Serialize("shopCostumePlayTime"                          )] public float shopCostumePlayTime;
		[Serialize("shopLuckyTicketPlayTime"                      )] public float shopLuckyTicketPlayTime;
		[Serialize("shopPrimaryPlayTime"                          )] public float shopPrimaryPlayTime;
		[Serialize("nbPrimaryStoreVisits"                         )] public uint nbPrimaryStoreVisits;
		[Serialize("nbLuckyTicketsScratchedLtd"                   )] public uint nbLuckyTicketsScratchedLtd;
		[Serialize("nbGoldenTicketsScratchedLtd"                  )] public uint nbGoldenTicketsScratchedLtd;
		[Serialize("nbClicksOnBuyBeatboxSlots"                    )] public uint nbClicksOnBuyBeatboxSlots;
		[Serialize("BeatBoxUsedCount"                             )] public uint BeatBoxUsedCount;
		[Serialize("BeatBoxNoteCount"                             )] public uint BeatBoxNoteCount;
		[Serialize("eggSequence"                                  )] public uint eggSequence;
		[Serialize("adventureEggSequence"                         )] public uint adventureEggSequence;
		[Serialize("runId"                                        )] public uint runId;
		[Serialize("shopVisitNb"                                  )] public uint shopVisitNb;
		[Serialize("hatchingCountdownRemainingSkipped"            )] public float hatchingCountdownRemainingSkipped;
		[Serialize("TrackingEggAlreadyReached"                    )] public bool TrackingEggAlreadyReached;
		[Serialize("TrackingEggAlreadyPicked"                     )] public bool TrackingEggAlreadyPicked;
		[Serialize("TrackingCptFlurry"                            )] public uint TrackingCptFlurry;
		[Serialize("TrackingCptUbiServices"                       )] public uint TrackingCptUbiServices;
		[Serialize("currentDuplicateStars"                        )] public uint currentDuplicateStars;
		[Serialize("lastShownDuplicateStars"                      )] public uint lastShownDuplicateStars;
		[Serialize("totalSpentDuplicateStars"                     )] public uint totalSpentDuplicateStars;
		[Serialize("lastRefusedDuplicateChoice"                   )] public uint lastRefusedDuplicateChoice;
		[Serialize("nbDuplicateCreaturesLtd"                      )] public uint nbDuplicateCreaturesLtd;
		[Serialize("nbLuckyTicketsNoDuplicate"                    )] public uint nbLuckyTicketsNoDuplicate;
		[Serialize("nbGoldenTicketsNoDuplicate"                   )] public uint nbGoldenTicketsNoDuplicate;
		[Serialize("duplicateChoiceClaimIndex"                    )] public uint duplicateChoiceClaimIndex;
		[Serialize("duplicateChoiceWaitIndex"                     )] public uint duplicateChoiceWaitIndex;
		[Serialize("stoppedDuringDuplicateChoice"                 )] public bool stoppedDuringDuplicateChoice;
		[Serialize("newDailyObjectivesAlreadyPopped"              )] public bool newDailyObjectivesAlreadyPopped;
		[Serialize("dailyObjectiveShuffleAvailable"               )] public bool dailyObjectiveShuffleAvailable;
		[Serialize("dailyObjectiveTicketAvailable"                )] public bool dailyObjectiveTicketAvailable;
		[Serialize("dailyObjective0AlreadyShown"                  )] public bool dailyObjective0AlreadyShown;
		[Serialize("dailyObjective1AlreadyShown"                  )] public bool dailyObjective1AlreadyShown;
		[Serialize("dailyObjective2AlreadyShown"                  )] public bool dailyObjective2AlreadyShown;
		[Serialize("dailyObjectiveTicketPart0Reached"             )] public bool dailyObjectiveTicketPart0Reached;
		[Serialize("dailyObjectiveTicketPart1Reached"             )] public bool dailyObjectiveTicketPart1Reached;
		[Serialize("dailyObjectiveTicketPart2Reached"             )] public bool dailyObjectiveTicketPart2Reached;
		[Serialize("nbDailyObjectiveShuffle"                      )] public uint nbDailyObjectiveShuffle;
		[Serialize("saveRandomBackgroundId"                       )] public uint saveRandomBackgroundId;
		[Serialize("firstShopOpeningDate"                         )] public online.DateTime firstShopOpeningDate;
		[Serialize("alreadyBoughtStarterPacks"                    )] public CList<uint> alreadyBoughtStarterPacks;
		[Serialize("alreadyBoughStoreBundles"                     )] public CList<uint> alreadyBoughStoreBundles;
		[Serialize("alreadySeenCostumeTrades"                     )] public CList<RLC_ShopCostumeVersion> alreadySeenCostumeTrades;
		[Serialize("gppSessionId"                                 )] public uint gppSessionId;
		[Serialize("lastSessionStartTimestamp"                    )] public online.DateTime lastSessionStartTimestamp;
		[Serialize("nbSessionsBeforeFacebookProposal"             )] public uint nbSessionsBeforeFacebookProposal;
		[Serialize("nbSessionsWithMailboxWaiting"                 )] public int nbSessionsWithMailboxWaiting;
		[Serialize("lastStarterPackPopupTimestamp"                )] public online.DateTime lastStarterPackPopupTimestamp;
		[Serialize("automaticPopupSaves"                          )] public CMap<RLC_StoreBundle.Type, RLC_AutomaticPopupSave> automaticPopupSaves;
		[Serialize("specialPackSaves"                             )] public CMap<RLC_StoreBundle.Type, RLC_SpecialPackSave> specialPackSaves;
		[Serialize("lastSentGiftsTimestamps"                      )] public CMap<StringID, online.DateTime> lastSentGiftsTimestamps;
		[Serialize("lastAskForGiftsTimestamps"                    )] public CMap<StringID, online.DateTime> lastAskForGiftsTimestamps;
		[Serialize("inviteFriendsRewardWaiting"                   )] public bool inviteFriendsRewardWaiting;
		[Serialize("showInviteFriendsExclamation"                 )] public bool showInviteFriendsExclamation;
		[Serialize("creatureDoesntNeedFoodDialogShown"            )] public bool creatureDoesntNeedFoodDialogShown;
		[Serialize("radarExhaustDialogShown"                      )] public bool radarExhaustDialogShown;
		[Serialize("shieldActivateDialogShown"                    )] public bool shieldActivateDialogShown;
		[Serialize("magnetActivateDialogShown"                    )] public bool magnetActivateDialogShown;
		[Serialize("beatboxSaveConfirmation"                      )] public bool beatboxSaveConfirmation;
		[Serialize("beatboxTrashConfirmation"                     )] public bool beatboxTrashConfirmation;
		[Serialize("forcedGreeceFirstLevel"                       )] public bool forcedGreeceFirstLevel;
		[Serialize("lastAdventureEggHatched"                      )] public StringID lastAdventureEggHatched;
		[Serialize("lastNewCreatureId"                            )] public StringID lastNewCreatureId;
		[Serialize("tutoLeaderboardDone"                          )] public bool tutoLeaderboardDone;
		[Serialize("tutoMapButtonAlreadyDisplayed"                )] public bool tutoMapButtonAlreadyDisplayed;
		[Serialize("ritualBeforeTutoLeaderboardDone"              )] public bool ritualBeforeTutoLeaderboardDone;
		[Serialize("betweenTwoAdventures"                         )] public bool betweenTwoAdventures;
		[Serialize("legalPopupAlreadySeen"                        )] public bool legalPopupAlreadySeen;
		[Serialize("luckyTicketShopAlreadyEntered"                )] public bool luckyTicketShopAlreadyEntered;
		[Serialize("elixirShopAlreadyEntered"                     )] public bool elixirShopAlreadyEntered;
		[Serialize("beatboxShopAlreadyEntered"                    )] public bool beatboxShopAlreadyEntered;
		[Serialize("nextRegionsChoiceNb"                          )] public uint nextRegionsChoiceNb;
		[Serialize("nextRegionRandomDone"                         )] public bool nextRegionRandomDone;
		[Serialize("revealedRegions"                              )] public CList<RLC_GraphicalFamily> revealedRegions;
		[Serialize("nextRegionTravelMarks"                        )] public CList<RO2_PersistentGameData_Universe.RLC_NextRegionTravelMark> nextRegionTravelMarks;
		[Serialize("nextRegionEggSelectionData"                   )] public CList<RO2_PersistentGameData_Universe.RLC_NextRegionEggSelectionData> nextRegionEggSelectionData;
		[Serialize("nextRegionsCreatureID0"                       )] public StringID nextRegionsCreatureID0;
		[Serialize("nextRegionsCreatureID1"                       )] public StringID nextRegionsCreatureID1;
		[Serialize("nextRegionsCreatureID2"                       )] public StringID nextRegionsCreatureID2;
		[Serialize("nextRegionsCreatureID3"                       )] public StringID nextRegionsCreatureID3;
		[Serialize("nextRegionsCreatureID4"                       )] public StringID nextRegionsCreatureID4;
		[Serialize("forcedIncubatorCreatureID_BeforeElixirs"      )] public StringID forcedIncubatorCreatureID_BeforeElixirs;
		[Serialize("forcedNextRegionCreatureID"                   )] public StringID forcedNextRegionCreatureID;
		[Serialize("forcedIncubatorCreatureID"                    )] public StringID forcedIncubatorCreatureID;
		[Serialize("IncubatorCreatureRegion"                      )] public Enum_IncubatorCreatureRegion IncubatorCreatureRegion;
		[Serialize("nextRegionMagnifyingGlassUsed"                )] public bool nextRegionMagnifyingGlassUsed;
		[Serialize("MagnifyingGlassUsedLtd"                       )] public uint MagnifyingGlassUsedLtd;
		[Serialize("adventureEggRarityRevealed"                   )] public bool adventureEggRarityRevealed;
		[Serialize("treeSeed"                                     )] public uint treeSeed;
		[Serialize("adventureSeed"                                )] public uint adventureSeed;
		[Serialize("RewardDojoRegionUnlocked"                     )] public bool RewardDojoRegionUnlocked;
		[Serialize("saveBranchId"                                 )] public uint saveBranchId;
		[Serialize("fbToken"                                      )] public string fbToken;
		[Serialize("completeAllCreatureValue"                     )] public uint completeAllCreatureValue;
		[Serialize("EndGamePlayersInformedAboutNewFamilies"       )] public bool EndGamePlayersInformedAboutNewFamilies;
		[Serialize("currentTutorialStepString"                    )] public string currentTutorialStepString;
		[Serialize("currentBeatboxTutoStepString"                 )] public string currentBeatboxTutoStepString;
		[Serialize("IncubatorElixirUtilisationsCountLtd0"         )] public uint IncubatorElixirUtilisationsCountLtd0;
		[Serialize("IncubatorElixirUtilisationsCountLtd1"         )] public uint IncubatorElixirUtilisationsCountLtd1;
		[Serialize("IncubatorElixirUtilisationsCountLtd2"         )] public uint IncubatorElixirUtilisationsCountLtd2;
		[Serialize("IncubatorElixirUtilisationsCountLtd3"         )] public uint IncubatorElixirUtilisationsCountLtd3;
		[Serialize("IncubatorElixirUtilisationsCountLtd4"         )] public uint IncubatorElixirUtilisationsCountLtd4;
		[Serialize("IncubatorElixirUtilisationsCountLtd5"         )] public uint IncubatorElixirUtilisationsCountLtd5;
		[Serialize("hatchingRitualInProgressCreatureId"           )] public StringID hatchingRitualInProgressCreatureId;
		[Serialize("hatchingRitualInProgressEggData"              )] public RO2_PersistentGameData_Universe.RLC_EggData hatchingRitualInProgressEggData;
		[Serialize("optionalData"                                 )] public CMap<StringID, string> optionalData;
		[Serialize("additionalDataBufferInt0"                     )] public uint additionalDataBufferInt0;
		[Serialize("additionalDataBufferInt1"                     )] public uint additionalDataBufferInt1;
		[Serialize("additionalDataBufferInt2"                     )] public uint additionalDataBufferInt2;
		[Serialize("additionalDataBufferInt3"                     )] public uint additionalDataBufferInt3;
		[Serialize("additionalDataBufferInt4"                     )] public uint additionalDataBufferInt4;
		[Serialize("additionalDataBufferInt5"                     )] public uint additionalDataBufferInt5;
		[Serialize("additionalDataBufferInt6"                     )] public uint additionalDataBufferInt6;
		[Serialize("additionalDataBufferInt7"                     )] public uint additionalDataBufferInt7;
		[Serialize("additionalDataBufferInt8"                     )] public uint additionalDataBufferInt8;
		[Serialize("additionalDataBufferInt9"                     )] public uint additionalDataBufferInt9;
		[Serialize("additionalDataBufferBool0"                    )] public bool additionalDataBufferBool0;
		[Serialize("additionalDataBufferBool1"                    )] public bool additionalDataBufferBool1;
		[Serialize("additionalDataBufferBool2"                    )] public bool additionalDataBufferBool2;
		[Serialize("additionalDataBufferBool3"                    )] public bool additionalDataBufferBool3;
		[Serialize("additionalDataBufferBool4"                    )] public bool additionalDataBufferBool4;
		[Serialize("additionalDataBufferBool5"                    )] public bool additionalDataBufferBool5;
		[Serialize("additionalDataBufferBool6"                    )] public bool additionalDataBufferBool6;
		[Serialize("additionalDataBufferBool7"                    )] public bool additionalDataBufferBool7;
		[Serialize("additionalDataBufferBool8"                    )] public bool additionalDataBufferBool8;
		[Serialize("additionalDataBufferBool9"                    )] public bool additionalDataBufferBool9;
		[Serialize("additionalDataBufferFloat0"                   )] public float additionalDataBufferFloat0;
		[Serialize("additionalDataBufferFloat1"                   )] public float additionalDataBufferFloat1;
		[Serialize("additionalDataBufferFloat2"                   )] public float additionalDataBufferFloat2;
		[Serialize("additionalDataBufferFloat3"                   )] public float additionalDataBufferFloat3;
		[Serialize("additionalDataBufferFloat4"                   )] public float additionalDataBufferFloat4;
		[Serialize("additionalDataBufferFloat5"                   )] public float additionalDataBufferFloat5;
		[Serialize("additionalDataBufferFloat6"                   )] public float additionalDataBufferFloat6;
		[Serialize("additionalDataBufferFloat7"                   )] public float additionalDataBufferFloat7;
		[Serialize("additionalDataBufferFloat8"                   )] public float additionalDataBufferFloat8;
		[Serialize("additionalDataBufferFloat9"                   )] public float additionalDataBufferFloat9;
		[Serialize("LastAdsSeenDateTime"                          )] public online.DateTime LastAdsSeenDateTime;
		[Serialize("LastContextualAdsSeenDateTime"                )] public online.DateTime LastContextualAdsSeenDateTime;
		[Serialize("MGlassAdsAdventureSequence"                   )] public uint MGlassAdsAdventureSequence;
		[Serialize("ShowFreeElixirAd"                             )] public bool ShowFreeElixirAd;
		[Serialize("maxTokenNb"                                   )] public uint maxTokenNb;
		[Serialize("tokenRefreshCooldown"                         )] public uint tokenRefreshCooldown;
		[Serialize("eggAcquisition"                               )] public uint eggAcquisition;
		[Serialize("maxContinue"                                  )] public uint maxContinue;
		[Serialize("continueCostX"                                )] public uint continueCostX;
		[Serialize("startContinueCost"                            )] public uint startContinueCost;
		[Serialize("maxContinueCost"                              )] public uint maxContinueCost;
		[Serialize("maxContinueWatchAd"                           )] public uint maxContinueWatchAd;
		[Serialize("SeasonalEventLastChanceId"                    )] public int SeasonalEventLastChanceId;
		[Serialize("profileId"                                    )] public string profileId;
		[Serialize("PlayerNameNext"                               )] public string PlayerNameNext;
		[Serialize("askedSlot"                                    )] public uint askedSlot;
		[Serialize("readMailboxElements"                          )] public CList<RLC_MailboxElementLight> readMailboxElements;
		[Serialize("msdkItems"                                    )] public string msdkItems;
		[Serialize("PlayTime_Leaderboard_Global"                  )] public float PlayTime_Leaderboard_Global;
		[Serialize("PlayTime_Leaderboard_Friends"                 )] public float PlayTime_Leaderboard_Friends;
		[Serialize("PlayTime_Leaderboard_Country"                 )] public float PlayTime_Leaderboard_Country;
		[Serialize("PlayTime_Leaderboard_Worldwide"               )] public float PlayTime_Leaderboard_Worldwide;
		[Serialize("PlayTime_Leaderboard_Likes"                   )] public float PlayTime_Leaderboard_Likes;
		[Serialize("Playtime_Leaderboard_VisitingTree"            )] public float Playtime_Leaderboard_VisitingTree;
		[Serialize("Leaderboard_VisitingTreeCount"                )] public uint Leaderboard_VisitingTreeCount;
		[Serialize("Leaderboard_VisitingProfileCount"             )] public uint Leaderboard_VisitingProfileCount;
		[Serialize("TreeEventFamilyMap"                           )] public CMap<uint, Pair<uint, RLC_CreatureTreeTier>> TreeEventFamilyMap;
		[Serialize("seasonalEventCurrencyPoolAdventure"           )] public uint seasonalEventCurrencyPoolAdventure;
		[Serialize("seasonalEventCurrencyPoolTree"                )] public uint seasonalEventCurrencyPoolTree;
		[Serialize("seasonalEventCurrencyPoolLevel"               )] public uint seasonalEventCurrencyPoolLevel;
		[Serialize("seasonalCurrencyFoundInAdventureValueLTD"     )] public uint seasonalCurrencyFoundInAdventureValueLTD;
		[Serialize("seasonalCurrencyFoundInTreeValueLTD"          )] public uint seasonalCurrencyFoundInTreeValueLTD;
		[Serialize("seasonalCurrencyFoundInLevelValueLTD"         )] public uint seasonalCurrencyFoundInLevelValueLTD;
		[Serialize("seasonalCurrencyAcquiredInPrimaryStoreLTD"    )] public uint seasonalCurrencyAcquiredInPrimaryStoreLTD;
		[Serialize("seasonalCurrencyAcquiredInCheatLTD"           )] public uint seasonalCurrencyAcquiredInCheatLTD;
		[Serialize("seasonalCurrencyAcquiredTotalLTD"             )] public uint seasonalCurrencyAcquiredTotalLTD;
		[Serialize("seasonalCurrencyUsedLTD"                      )] public uint seasonalCurrencyUsedLTD;
		[Serialize("legChallengeRunsCount"                        )] public uint legChallengeRunsCount;
		[Serialize("totalChallengeRunsCount"                      )] public uint totalChallengeRunsCount;
		[Serialize("seasonalEventLastTimeCurrencySpawnInAdventure")] public online.DateTime seasonalEventLastTimeCurrencySpawnInAdventure;
		[Serialize("seasonalEventLastTimeCurrencySpawnInTree"     )] public online.DateTime seasonalEventLastTimeCurrencySpawnInTree;
		[Serialize("seasonalEventLastTimeCurrencySpawnInLevel"    )] public online.DateTime seasonalEventLastTimeCurrencySpawnInLevel;
		[Serialize("seasonalEventLastTimeCurrencyFoundInAdventure")] public online.DateTime seasonalEventLastTimeCurrencyFoundInAdventure;
		[Serialize("seasonalEventLastTimeCurrencyFoundInTree"     )] public online.DateTime seasonalEventLastTimeCurrencyFoundInTree;
		[Serialize("seasonalEventLastTimeCurrencyFoundInLevel"    )] public online.DateTime seasonalEventLastTimeCurrencyFoundInLevel;
		[Serialize("seasonalEventFamilyList"                      )] public CMap<uint, RO2_PersistentGameData_Universe.SeasonalEventData> seasonalEventFamilyList;
		[Serialize("currentSeasonalEventId"                       )] public uint currentSeasonalEventId;
		[Serialize("clusterName"                                  )] public string clusterName;
		[Serialize("MagnifyingGlassUsedPerAdventure_LTD"          )] public float MagnifyingGlassUsedPerAdventure_LTD;
		[Serialize("NbLevelUnlocked_LTD"                          )] public uint NbLevelUnlocked_LTD;
		[Serialize("NbLevelVisited_LTD"                           )] public uint NbLevelVisited_LTD;
		[Serialize("NbLevelCompleted_LTD"                         )] public uint NbLevelCompleted_LTD;
		[Serialize("NbLevelBronze_LTD"                            )] public uint NbLevelBronze_LTD;
		[Serialize("NbLevelSilver_LTD"                            )] public uint NbLevelSilver_LTD;
		[Serialize("NbLevelGold_LTD"                              )] public uint NbLevelGold_LTD;
		[Serialize("PropCompletion"                               )] public float PropCompletion;
		[Serialize("PropGold"                                     )] public float PropGold;
		[Serialize("NbElixirSilverUsed_LTD"                       )] public uint NbElixirSilverUsed_LTD;
		[Serialize("NbElixirGoldUsed_LTD"                         )] public uint NbElixirGoldUsed_LTD;
		[Serialize("NbElixirNewCreatureUsed_LTD"                  )] public uint NbElixirNewCreatureUsed_LTD;
		[Serialize("NbElixirSpeedUsed_LTD"                        )] public uint NbElixirSpeedUsed_LTD;
		[Serialize("NbElixirSilverOwned_LTD"                      )] public uint NbElixirSilverOwned_LTD;
		[Serialize("NbElixirGoldOwned_LTD"                        )] public uint NbElixirGoldOwned_LTD;
		[Serialize("NbElixirNewCreatureOwned_LTD"                 )] public uint NbElixirNewCreatureOwned_LTD;
		[Serialize("NbElixirSpeedOwned_LTD"                       )] public uint NbElixirSpeedOwned_LTD;
		[Serialize("PropUsedElixirs"                              )] public float PropUsedElixirs;
		[Serialize("ratingPopupVersionToSkip"                     )] public string ratingPopupVersionToSkip;
		[Serialize("ratingPopupSkipLikePhase"                     )] public bool ratingPopupSkipLikePhase;
		[Serialize("neverShowRatingPopup"                         )] public bool neverShowRatingPopup;
		[Serialize("ratingPopupShownCptLtd"                       )] public uint ratingPopupShownCptLtd;
		[Serialize("newRatingPopupRequestedCount"                 )] public uint newRatingPopupRequestedCount;
		[Serialize("needToShowTimeSavingEndingPopup"              )] public bool needToShowTimeSavingEndingPopup;
		[Serialize("ShopAgeGateCheckDone"                         )] public bool ShopAgeGateCheckDone;
		[Serialize("ShopNonAgressiveMode"                         )] public bool ShopNonAgressiveMode;
		[Serialize("DecoyEggIntroDone"                            )] public bool DecoyEggIntroDone;
		[Serialize("AddingMirroredLevelsDone"                     )] public bool AddingMirroredLevelsDone;
		[Serialize("LuckyTicketAcquiredLtd"                       )] public uint LuckyTicketAcquiredLtd;
		[Serialize("GoldenTicketAcquiredLtd"                      )] public uint GoldenTicketAcquiredLtd;
		[Serialize("SeasonalTicketAcquiredLtd"                    )] public uint SeasonalTicketAcquiredLtd;
		[Serialize("ChallengeTicketAcquiredLtd"                   )] public uint ChallengeTicketAcquiredLtd;
		[Serialize("ChallengeTokenAcquiredLtd"                    )] public uint ChallengeTokenAcquiredLtd;
		[Serialize("BeatBoxSlotAcquiredLtd"                       )] public uint BeatBoxSlotAcquiredLtd;
		[Serialize("SeasonalEggAcquiredLtd"                       )] public uint SeasonalEggAcquiredLtd;
		[Serialize("RemoveAdsPurchased"                           )] public bool RemoveAdsPurchased;
		[Serialize("TimerAdventureStartTimeInSec"                 )] public ulong TimerAdventureStartTimeInSec;
		[Serialize("TimerAdventureEndTimeInSec"                   )] public ulong TimerAdventureEndTimeInSec;
		[Serialize("TimerAdventureGemsExtentions"                 )] public uint TimerAdventureGemsExtentions;
		[Serialize("TimerAdventureAdExtentions"                   )] public uint TimerAdventureAdExtentions;
		[Serialize("IsTimerAdventureEggRescued"                   )] public bool IsTimerAdventureEggRescued;
		[Serialize("CurrentPerkPackActive"                        )] public uint CurrentPerkPackActive;
		[Serialize("TimeLastShownMiniEventExclamation"            )] public online.DateTime TimeLastShownMiniEventExclamation;
		[Serialize("MiniEventsSessionsSinceLastShown"             )] public uint MiniEventsSessionsSinceLastShown;
		[Serialize("profile"                                      )] public Unknown_RL_31371_sub_894F80 profile;
		[Serialize("messages"                                     )] public CList<Message> messages;
		[Serialize("mrDarkUnlockCount"                            )] public CArray<StringID> mrDarkUnlockCount;
		[Serialize("newCostumes"                                  )] public CArray<StringID> newCostumes;
		[Serialize("costumeUnlockSeen"                            )] public CArray<StringID> costumeUnlockSeen;
		[Serialize("retroUnlocks"                                 )] public CArray<StringID> retroUnlocks;
		[Serialize("playedDiamondCupSequence"                     )] public CArray<StringID> playedDiamondCupSequence;
		[Serialize("costumes"                                     )] public CArray<StringID> costumes;
		[Serialize("playedInvasion"                               )] public CArray<StringID> playedInvasion;
		[Serialize("worldUnlockMessagesSeen"                      )] public CArray<StringID> worldUnlockMessagesSeen;
		[Serialize("doorUnlockMessageSeen"                        )] public CArray<StringID> doorUnlockMessageSeen;
		[Serialize("doorUnlockDRCMessageRequired"                 )] public CArray<StringID> doorUnlockDRCMessageRequired;
		[Serialize("reward39Failed"                               )] public int reward39Failed;
		[Serialize("isDemoRewardChecked"                          )] public int isDemoRewardChecked;
		[Serialize("messageDummy"                                 )] public Message messageDummy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(score));
				SerializeField(s, nameof(profile));
				SerializeField(s, nameof(bubbleDreamer));
				SerializeField(s, nameof(unlockedPets));
				SerializeField(s, nameof(petsDailyReward));
				SerializeField(s, nameof(unlockedCupsForPets));
				SerializeField(s, nameof(givenPetCount));
				SerializeField(s, nameof(newPetsUnlocked));
				SerializeField(s, nameof(firstPetShown));
				SerializeField(s, nameof(hasShownMessageAllPet));
				SerializeField(s, nameof(messages));
				SerializeField(s, nameof(messagesTotalCount));
				SerializeField(s, nameof(messages_onlineDate));
				SerializeField(s, nameof(messages_localDate));
				SerializeField(s, nameof(messages_readDrcCount));
				SerializeField(s, nameof(messages_interactDrcCount));
				SerializeField(s, nameof(messages_lastSeenMessageHandle));
				SerializeField(s, nameof(messages_tutoCount));
				SerializeField(s, nameof(messages_drcCountSinceLastInteract));
				SerializeField(s, nameof(playerCard_displayedCount));
				SerializeField(s, nameof(playerCard_tutoSeen));
				SerializeField(s, nameof(gameCompleted));
				SerializeField(s, nameof(timeToCompleteGameInSec));
				SerializeField(s, nameof(timeSpendInGameInSec));
				SerializeField(s, nameof(teensiesBonusCounter));
				SerializeField(s, nameof(luckyTicketsCounter));
				SerializeField(s, nameof(luckyTicketLevelCount));
				SerializeField(s, nameof(retroMapUnlockedCounter));
				SerializeField(s, nameof(mrDarkUnlockCount));
				SerializeField(s, nameof(catchEmAllIndex));
				SerializeField(s, nameof(newCostumes));
				SerializeField(s, nameof(costumeUnlockSeen));
				SerializeField(s, nameof(retroUnlocks));
				SerializeField(s, nameof(newUnlockedDoor));
				SerializeField(s, nameof(luckyTicketRewardList));
				SerializeField(s, nameof(nodeData));
				SerializeField(s, nameof(luckyTicketsRewardGivenCounter));
				SerializeField(s, nameof(consecutiveLuckyTicketCount));
				SerializeField(s, nameof(ticketReminderMessageCount));
				SerializeField(s, nameof(displayGhosts));
				SerializeField(s, nameof(uplayDoneAction0));
				SerializeField(s, nameof(uplayDoneAction1));
				SerializeField(s, nameof(uplayDoneAction2));
				SerializeField(s, nameof(uplayDoneAction3));
				SerializeField(s, nameof(uplayDoneReward0));
				SerializeField(s, nameof(uplayDoneReward1));
				SerializeField(s, nameof(uplayDoneReward2));
				SerializeField(s, nameof(uplayDoneReward3));
				SerializeField(s, nameof(playedDiamondCupSequence));
				SerializeField(s, nameof(costumes));
				SerializeField(s, nameof(playedChallenge));
				SerializeField(s, nameof(playedInvasion));
				SerializeField(s, nameof(tvOffOptionEnabledNb));
				SerializeField(s, nameof(tvOffOptionActivatedTime));
				SerializeField(s, nameof(barbaraCostumeUnlockSeen));
				SerializeField(s, nameof(worldUnlockMessagesSeen));
				SerializeField(s, nameof(retroWorldUnlockMessageSeen));
				SerializeField(s, nameof(freedAllTeensiesMessageSeen));
				SerializeField(s, nameof(MisterDarkCompletionMessageSeen));
				SerializeField(s, nameof(FirstInvasionMessageSeen));
				SerializeField(s, nameof(InvitationTutoSeen));
				SerializeField(s, nameof(MessageSeen8Bit));
				SerializeField(s, nameof(challengeWorldUnlockMessageSeen));
				SerializeField(s, nameof(doorUnlockMessageSeen));
				SerializeField(s, nameof(doorUnlockDRCMessageRequired));
				SerializeField(s, nameof(luckyTicketRewardWorldName));
				SerializeField(s, nameof(isUGCMiiverseWarningSet));
				SerializeField(s, nameof(reward39Failed));
				SerializeField(s, nameof(unlockPrivilegesData));
				SerializeField(s, nameof(isDemoRewardChecked));
				SerializeField(s, nameof(prisonerDataDummy));
				SerializeField(s, nameof(persistentGameDataLevelDummy));
				SerializeField(s, nameof(messageDummy));
				SerializeField(s, nameof(unlockedDoorDummy));
				SerializeField(s, nameof(bubbleDreamerDataDummy));
				SerializeField(s, nameof(dummmyNodeData));
			} else {
				SerializeField(s, nameof(score));
				SerializeField(s, nameof(bubbleDreamer));
				SerializeField(s, nameof(unlockedPets));
				SerializeField(s, nameof(unlockedPets));
				SerializeField(s, nameof(petsDailyReward));
				SerializeField(s, nameof(unlockedCupsForPets));
				SerializeField(s, nameof(givenPetCount));
				SerializeField(s, nameof(newPetsUnlocked));
				SerializeField(s, nameof(firstPetShown));
				SerializeField(s, nameof(hasShownMessageAllPet));
				SerializeField(s, nameof(messagesTotalCount));
				SerializeField(s, nameof(messages_onlineDate));
				SerializeField(s, nameof(messages_localDate));
				SerializeField(s, nameof(messages_readDrcCount));
				SerializeField(s, nameof(messages_interactDrcCount));
				SerializeField(s, nameof(messages_lastSeenMessageHandle));
				SerializeField(s, nameof(messages_tutoCount));
				SerializeField(s, nameof(messages_drcCountSinceLastInteract));
				SerializeField(s, nameof(playerCard_displayedCount));
				SerializeField(s, nameof(playerCard_tutoSeen));
				SerializeField(s, nameof(gameCompleted));
				SerializeField(s, nameof(timeToCompleteGameInSec));
				SerializeField(s, nameof(timeSpendInGameInSec));
				SerializeField(s, nameof(teensiesBonusCounter));
				SerializeField(s, nameof(luckyTicketsCounter));
				SerializeField(s, nameof(luckyTicketLevelCount));
				SerializeField(s, nameof(retroMapUnlockedCounter));
				SerializeField(s, nameof(catchEmAllIndex));
				SerializeField(s, nameof(newUnlockedDoor));
				SerializeField(s, nameof(luckyTicketRewardList));
				SerializeField(s, nameof(nodeData));
				SerializeField(s, nameof(luckyTicketsRewardGivenCounter));
				SerializeField(s, nameof(consecutiveLuckyTicketCount));
				SerializeField(s, nameof(ticketReminderMessageCount));
				SerializeField(s, nameof(displayGhosts));
				SerializeField(s, nameof(uplayDoneAction0));
				SerializeField(s, nameof(uplayDoneAction1));
				SerializeField(s, nameof(uplayDoneAction2));
				SerializeField(s, nameof(uplayDoneAction3));
				SerializeField(s, nameof(uplayDoneAction4));
				SerializeField(s, nameof(uplayDoneReward0));
				SerializeField(s, nameof(uplayDoneReward1));
				SerializeField(s, nameof(uplayDoneReward2));
				SerializeField(s, nameof(uplayDoneReward3));
				SerializeField(s, nameof(uplayDoneReward3));
				SerializeField(s, nameof(playedChallenge));
				SerializeField(s, nameof(tvOffOptionEnabledNb));
				SerializeField(s, nameof(tvOffOptionActivatedTime));
				SerializeField(s, nameof(barbaraCostumeUnlockSeen));
				SerializeField(s, nameof(retroWorldUnlockMessageSeen));
				SerializeField(s, nameof(freedAllTeensiesMessageSeen));
				SerializeField(s, nameof(MisterDarkCompletionMessageSeen));
				SerializeField(s, nameof(FirstInvasionMessageSeen));
				SerializeField(s, nameof(InvitationTutoSeen));
				SerializeField(s, nameof(MessageSeen8Bit));
				SerializeField(s, nameof(challengeWorldUnlockMessageSeen));
				SerializeField(s, nameof(luckyTicketRewardWorldName));
				SerializeField(s, nameof(isUGCMiiverseWarningSet));
				SerializeField(s, nameof(unlockPrivilegesData));
				SerializeField(s, nameof(prisonerDataDummy));
				SerializeField(s, nameof(persistentGameDataLevelDummy));
				SerializeField(s, nameof(unlockedDoorDummy));
				SerializeField(s, nameof(bubbleDreamerDataDummy));
				SerializeField(s, nameof(dummmyNodeData));
				SerializeField(s, nameof(adventureNodeDataList));
				SerializeField(s, nameof(introCompleted));
				SerializeField(s, nameof(introCreatureHatched));
				SerializeField(s, nameof(devTeam));
				SerializeField(s, nameof(onboardingCompleted));
				SerializeField(s, nameof(gameStartDateTime));
				SerializeField(s, nameof(globalSessionNb));
				SerializeField(s, nameof(isNotificationConfirmationDialogShown));
				SerializeField(s, nameof(foodAcquiredNbLtd));
				SerializeField(s, nameof(foodRefillStartDate));
				SerializeField(s, nameof(gemsAcquiredNbLtd));
				SerializeField(s, nameof(MglassAcquiredNbLtd));
				SerializeField(s, nameof(MGlassBoughtWithGemsNbLtd));
				SerializeField(s, nameof(rewardedVideoNbLtd));
				SerializeField(s, nameof(everyPlaySharedVideoNbLtd));
				SerializeField(s, nameof(gemsUsedNbLtd));
				SerializeField(s, nameof(nbMailboxReadLtd));
				SerializeField(s, nameof(characterSelectionNb));
				SerializeField(s, nameof(adventureSessionNb));
				SerializeField(s, nameof(adventureId));
				SerializeField(s, nameof(skipAdventure));
				SerializeField(s, nameof(adventureStartDate));
				SerializeField(s, nameof(adventureLifeTimeInSec));
				SerializeField(s, nameof(adventureDefaultLifeTimeInSec));
				SerializeField(s, nameof(timeLimitedAdventureTutorialShown));
				SerializeField(s, nameof(timeLimitedAdventureCompleteInTime));
				SerializeField(s, nameof(timeLimitedAdventureRewardCredited));
				SerializeField(s, nameof(adventureRenderParamIndex));
				SerializeField(s, nameof(adventureNewGameDone));
				SerializeField(s, nameof(adventureGlobalIndex));
				SerializeField(s, nameof(adventurePath));
				SerializeField(s, nameof(adventureCharlieFound));
				SerializeField(s, nameof(totalCharlieFound));
				SerializeField(s, nameof(tutorialCharlieFound));
				SerializeField(s, nameof(tutorialCharlieOptionalFound));
				SerializeField(s, nameof(tutorialFeedInGoScreenFound));
				SerializeField(s, nameof(newElixirDialogAlreadySeen));
				SerializeField(s, nameof(adventureFinishedAlreadyDisplayed));
				SerializeField(s, nameof(adventureCompleteAlreadyDisplayed));
				SerializeField(s, nameof(joinDate));
				SerializeField(s, nameof(iapScore));
				SerializeField(s, nameof(originalDeviceId));
				SerializeField(s, nameof(spinCount));
				SerializeField(s, nameof(levelTryCount));
				SerializeField(s, nameof(challengeWheelRewardType));
				SerializeField(s, nameof(challengeWheelMapType));
				SerializeField(s, nameof(challengeWheelLevelType));
				SerializeField(s, nameof(challengeWheelMapPath));
				SerializeField(s, nameof(challengeWheelMapResult));
				SerializeField(s, nameof(challengeWheelCompleteTime));
				SerializeField(s, nameof(challengeWheelIntroPopupShowTimeInSec));
				SerializeField(s, nameof(needToShowSeasonalEventExclamation));
				SerializeField(s, nameof(endLessRunnerEventIntroPopupShowTimeInSec));
				SerializeField(s, nameof(m_FacebookBenefitsShownFoeEventID));
				SerializeField(s, nameof(isScratchingFirstLuckyTicket));
				SerializeField(s, nameof(isScratchingSecondLuckyTicket));
				SerializeField(s, nameof(tutoLuckyTicketHasBeenConsumed));
				SerializeField(s, nameof(shopAlreadyOpened));
				SerializeField(s, nameof(facebookBenefitsAlreadyProposed));
				SerializeField(s, nameof(facebookBenefitsAlreadyOpened));
				SerializeField(s, nameof(adventureCharlieCountdown));
				SerializeField(s, nameof(bonusMapCountDown));
				SerializeField(s, nameof(challengeMapCountDown));
				SerializeField(s, nameof(playerCostumeSkin));
				SerializeField(s, nameof(dailyObjectiveRefreshDate));
				SerializeField(s, nameof(lastTokenRefreshDate));
				SerializeField(s, nameof(lastEventBundleUIShownTime));
				SerializeField(s, nameof(amarCreaturesEndDate));
				SerializeField(s, nameof(lastOpenedChallengeSeed));
				SerializeField(s, nameof(lastChallengeSeed));
				SerializeField(s, nameof(dailyChallengeBestScore));
				SerializeField(s, nameof(dailyChallengeBestDistance));
				SerializeField(s, nameof(lastChallengeTombs));
				SerializeField(s, nameof(lastChallengeTombs));
				SerializeField(s, nameof(dailyChallengeTicketPiecesState0));
				SerializeField(s, nameof(dailyChallengeTicketPiecesState1));
				SerializeField(s, nameof(dailyChallengeTicketPiecesState2));
				SerializeField(s, nameof(dailyChallengeTicketCollected));
				SerializeField(s, nameof(retryPostDailyChallengeScore));
				SerializeField(s, nameof(missionDataList));
				SerializeField(s, nameof(creatureDataList));
				SerializeField(s, nameof(currentCreatureData));
				SerializeField(s, nameof(nbHatchedEggsSinceLastNewCreature));
				SerializeField(s, nameof(awayLongEnoughToHatchNewCreature));
				SerializeField(s, nameof(hatchFailCounter_NewCreature));
				SerializeField(s, nameof(hatchFailCounter_Queen));
				SerializeField(s, nameof(adventureEggData));
				SerializeField(s, nameof(mb_needRequestStartNextAdventureParam));
				SerializeField(s, nameof(incubatorEggData));
				SerializeField(s, nameof(incubatorElixirUtilisations));
				SerializeField(s, nameof(incubatorEggAdventureSequence));
				SerializeField(s, nameof(eggHatchingComplete));
				SerializeField(s, nameof(eggFirstTapComplete));
				SerializeField(s, nameof(lastEggHatchingTimeSkipped));
				SerializeField(s, nameof(incubatorDateTimeEggHatchingComplete));
				SerializeField(s, nameof(lastSavedGameDateTime));
				SerializeField(s, nameof(incubationDuration));
				SerializeField(s, nameof(StartValuesSet));
				SerializeField(s, nameof(menuOptionSave));
				SerializeField(s, nameof(languageArabicPopupDisplayed));
				SerializeField(s, nameof(CostumePlayTime));
				SerializeField(s, nameof(globalPlayTime));
				SerializeField(s, nameof(adventurePlayTime));
				SerializeField(s, nameof(adventureStep));
				SerializeField(s, nameof(adventureStepPlayTime));
				SerializeField(s, nameof(adventureBoatState));
				SerializeField(s, nameof(TreePlayTime));
				SerializeField(s, nameof(BeatBoxPlayTime));
				SerializeField(s, nameof(shopPlayTime));
				SerializeField(s, nameof(shopFoodPlayTime));
				SerializeField(s, nameof(shopElixirPlayTime));
				SerializeField(s, nameof(shopCostumePlayTime));
				SerializeField(s, nameof(shopLuckyTicketPlayTime));
				SerializeField(s, nameof(shopPrimaryPlayTime));
				SerializeField(s, nameof(nbPrimaryStoreVisits));
				SerializeField(s, nameof(nbLuckyTicketsScratchedLtd));
				SerializeField(s, nameof(nbGoldenTicketsScratchedLtd));
				SerializeField(s, nameof(nbClicksOnBuyBeatboxSlots));
				SerializeField(s, nameof(BeatBoxUsedCount));
				SerializeField(s, nameof(BeatBoxNoteCount));
				SerializeField(s, nameof(eggSequence));
				SerializeField(s, nameof(adventureEggSequence));
				SerializeField(s, nameof(runId));
				SerializeField(s, nameof(shopVisitNb));
				SerializeField(s, nameof(hatchingCountdownRemainingSkipped));
				SerializeField(s, nameof(TrackingEggAlreadyReached));
				SerializeField(s, nameof(TrackingEggAlreadyPicked));
				SerializeField(s, nameof(TrackingCptFlurry));
				SerializeField(s, nameof(TrackingCptUbiServices));
				SerializeField(s, nameof(currentDuplicateStars));
				SerializeField(s, nameof(lastShownDuplicateStars));
				SerializeField(s, nameof(totalSpentDuplicateStars));
				SerializeField(s, nameof(lastRefusedDuplicateChoice));
				SerializeField(s, nameof(nbDuplicateCreaturesLtd));
				SerializeField(s, nameof(nbLuckyTicketsNoDuplicate));
				SerializeField(s, nameof(nbGoldenTicketsNoDuplicate));
				SerializeField(s, nameof(duplicateChoiceClaimIndex));
				SerializeField(s, nameof(duplicateChoiceWaitIndex));
				SerializeField(s, nameof(stoppedDuringDuplicateChoice));
				SerializeField(s, nameof(newDailyObjectivesAlreadyPopped));
				SerializeField(s, nameof(dailyObjectiveShuffleAvailable));
				SerializeField(s, nameof(dailyObjectiveTicketAvailable));
				SerializeField(s, nameof(dailyObjective0AlreadyShown));
				SerializeField(s, nameof(dailyObjective1AlreadyShown));
				SerializeField(s, nameof(dailyObjective2AlreadyShown));
				SerializeField(s, nameof(dailyObjectiveTicketPart0Reached));
				SerializeField(s, nameof(dailyObjectiveTicketPart1Reached));
				SerializeField(s, nameof(dailyObjectiveTicketPart2Reached));
				SerializeField(s, nameof(nbDailyObjectiveShuffle));
				SerializeField(s, nameof(saveRandomBackgroundId));
				SerializeField(s, nameof(firstShopOpeningDate));
				SerializeField(s, nameof(alreadyBoughtStarterPacks));
				SerializeField(s, nameof(alreadyBoughStoreBundles));
				SerializeField(s, nameof(alreadySeenCostumeTrades));
				SerializeField(s, nameof(gppSessionId));
				SerializeField(s, nameof(lastSessionStartTimestamp));
				SerializeField(s, nameof(nbSessionsBeforeFacebookProposal));
				SerializeField(s, nameof(nbSessionsWithMailboxWaiting));
				SerializeField(s, nameof(lastStarterPackPopupTimestamp));
				SerializeField(s, nameof(automaticPopupSaves));
				SerializeField(s, nameof(specialPackSaves));
				SerializeField(s, nameof(lastSentGiftsTimestamps));
				SerializeField(s, nameof(lastAskForGiftsTimestamps));
				SerializeField(s, nameof(inviteFriendsRewardWaiting));
				SerializeField(s, nameof(showInviteFriendsExclamation));
				SerializeField(s, nameof(creatureDoesntNeedFoodDialogShown));
				SerializeField(s, nameof(radarExhaustDialogShown));
				SerializeField(s, nameof(shieldActivateDialogShown));
				SerializeField(s, nameof(magnetActivateDialogShown));
				SerializeField(s, nameof(beatboxSaveConfirmation));
				SerializeField(s, nameof(beatboxTrashConfirmation));
				SerializeField(s, nameof(forcedGreeceFirstLevel));
				SerializeField(s, nameof(lastAdventureEggHatched));
				SerializeField(s, nameof(lastNewCreatureId));
				SerializeField(s, nameof(tutoLeaderboardDone));
				SerializeField(s, nameof(tutoMapButtonAlreadyDisplayed));
				SerializeField(s, nameof(ritualBeforeTutoLeaderboardDone));
				SerializeField(s, nameof(betweenTwoAdventures));
				SerializeField(s, nameof(legalPopupAlreadySeen));
				SerializeField(s, nameof(luckyTicketShopAlreadyEntered));
				SerializeField(s, nameof(elixirShopAlreadyEntered));
				SerializeField(s, nameof(beatboxShopAlreadyEntered));
				SerializeField(s, nameof(nextRegionsChoiceNb));
				SerializeField(s, nameof(nextRegionRandomDone));
				SerializeField(s, nameof(revealedRegions));
				SerializeField(s, nameof(nextRegionTravelMarks));
				SerializeField(s, nameof(nextRegionEggSelectionData));
				SerializeField(s, nameof(nextRegionsCreatureID0));
				SerializeField(s, nameof(nextRegionsCreatureID1));
				SerializeField(s, nameof(nextRegionsCreatureID2));
				SerializeField(s, nameof(nextRegionsCreatureID3));
				SerializeField(s, nameof(nextRegionsCreatureID4));
				SerializeField(s, nameof(forcedIncubatorCreatureID_BeforeElixirs));
				SerializeField(s, nameof(forcedNextRegionCreatureID));
				SerializeField(s, nameof(forcedIncubatorCreatureID));
				SerializeField(s, nameof(IncubatorCreatureRegion));
				SerializeField(s, nameof(nextRegionMagnifyingGlassUsed));
				SerializeField(s, nameof(MagnifyingGlassUsedLtd));
				SerializeField(s, nameof(adventureEggRarityRevealed));
				SerializeField(s, nameof(treeSeed));
				SerializeField(s, nameof(adventureSeed));
				SerializeField(s, nameof(RewardDojoRegionUnlocked));
				SerializeField(s, nameof(saveBranchId));
				SerializeField(s, nameof(fbToken));
				SerializeField(s, nameof(completeAllCreatureValue));
				SerializeField(s, nameof(EndGamePlayersInformedAboutNewFamilies));
				SerializeField(s, nameof(currentTutorialStepString));
				SerializeField(s, nameof(currentBeatboxTutoStepString));
				SerializeField(s, nameof(IncubatorElixirUtilisationsCountLtd0));
				SerializeField(s, nameof(IncubatorElixirUtilisationsCountLtd1));
				SerializeField(s, nameof(IncubatorElixirUtilisationsCountLtd2));
				SerializeField(s, nameof(IncubatorElixirUtilisationsCountLtd3));
				SerializeField(s, nameof(IncubatorElixirUtilisationsCountLtd4));
				SerializeField(s, nameof(IncubatorElixirUtilisationsCountLtd5));
				SerializeField(s, nameof(hatchingRitualInProgressCreatureId));
				SerializeField(s, nameof(hatchingRitualInProgressEggData));
				SerializeField(s, nameof(optionalData));
				SerializeField(s, nameof(additionalDataBufferInt0));
				SerializeField(s, nameof(additionalDataBufferInt1));
				SerializeField(s, nameof(additionalDataBufferInt2));
				SerializeField(s, nameof(additionalDataBufferInt3));
				SerializeField(s, nameof(additionalDataBufferInt4));
				SerializeField(s, nameof(additionalDataBufferInt5));
				SerializeField(s, nameof(additionalDataBufferInt6));
				SerializeField(s, nameof(additionalDataBufferInt7));
				SerializeField(s, nameof(additionalDataBufferInt8));
				SerializeField(s, nameof(additionalDataBufferInt9));
				SerializeField(s, nameof(additionalDataBufferBool0));
				SerializeField(s, nameof(additionalDataBufferBool1));
				SerializeField(s, nameof(additionalDataBufferBool2));
				SerializeField(s, nameof(additionalDataBufferBool3));
				SerializeField(s, nameof(additionalDataBufferBool4));
				SerializeField(s, nameof(additionalDataBufferBool5));
				SerializeField(s, nameof(additionalDataBufferBool6));
				SerializeField(s, nameof(additionalDataBufferBool7));
				SerializeField(s, nameof(additionalDataBufferBool8));
				SerializeField(s, nameof(additionalDataBufferBool9));
				SerializeField(s, nameof(additionalDataBufferFloat0));
				SerializeField(s, nameof(additionalDataBufferFloat1));
				SerializeField(s, nameof(additionalDataBufferFloat2));
				SerializeField(s, nameof(additionalDataBufferFloat3));
				SerializeField(s, nameof(additionalDataBufferFloat4));
				SerializeField(s, nameof(additionalDataBufferFloat5));
				SerializeField(s, nameof(additionalDataBufferFloat6));
				SerializeField(s, nameof(additionalDataBufferFloat7));
				SerializeField(s, nameof(additionalDataBufferFloat8));
				SerializeField(s, nameof(additionalDataBufferFloat9));
				SerializeField(s, nameof(LastAdsSeenDateTime));
				SerializeField(s, nameof(LastContextualAdsSeenDateTime));
				SerializeField(s, nameof(MGlassAdsAdventureSequence));
				SerializeField(s, nameof(ShowFreeElixirAd));
				SerializeField(s, nameof(maxTokenNb));
				SerializeField(s, nameof(tokenRefreshCooldown));
				SerializeField(s, nameof(eggAcquisition));
				SerializeField(s, nameof(maxContinue));
				SerializeField(s, nameof(continueCostX));
				SerializeField(s, nameof(startContinueCost));
				SerializeField(s, nameof(maxContinueCost));
				SerializeField(s, nameof(maxContinueWatchAd));
				SerializeField(s, nameof(SeasonalEventLastChanceId));
				SerializeField(s, nameof(profileId));
				SerializeField(s, nameof(PlayerNameNext));
				SerializeField(s, nameof(askedSlot));
				SerializeField(s, nameof(readMailboxElements));
				SerializeField(s, nameof(msdkItems));
				SerializeField(s, nameof(PlayTime_Leaderboard_Global));
				SerializeField(s, nameof(PlayTime_Leaderboard_Friends));
				SerializeField(s, nameof(PlayTime_Leaderboard_Country));
				SerializeField(s, nameof(PlayTime_Leaderboard_Worldwide));
				SerializeField(s, nameof(PlayTime_Leaderboard_Likes));
				SerializeField(s, nameof(Playtime_Leaderboard_VisitingTree));
				SerializeField(s, nameof(Leaderboard_VisitingTreeCount));
				SerializeField(s, nameof(Leaderboard_VisitingProfileCount));
				SerializeField(s, nameof(TreeEventFamilyMap));
				SerializeField(s, nameof(seasonalEventCurrencyPoolAdventure));
				SerializeField(s, nameof(seasonalEventCurrencyPoolTree));
				SerializeField(s, nameof(seasonalEventCurrencyPoolLevel));
				SerializeField(s, nameof(seasonalCurrencyFoundInAdventureValueLTD));
				SerializeField(s, nameof(seasonalCurrencyFoundInTreeValueLTD));
				SerializeField(s, nameof(seasonalCurrencyFoundInLevelValueLTD));
				SerializeField(s, nameof(seasonalCurrencyAcquiredInPrimaryStoreLTD));
				SerializeField(s, nameof(seasonalCurrencyAcquiredInCheatLTD));
				SerializeField(s, nameof(seasonalCurrencyAcquiredTotalLTD));
				SerializeField(s, nameof(seasonalCurrencyUsedLTD));
				SerializeField(s, nameof(legChallengeRunsCount));
				SerializeField(s, nameof(totalChallengeRunsCount));
				SerializeField(s, nameof(seasonalEventLastTimeCurrencySpawnInAdventure));
				SerializeField(s, nameof(seasonalEventLastTimeCurrencySpawnInTree));
				SerializeField(s, nameof(seasonalEventLastTimeCurrencySpawnInLevel));
				SerializeField(s, nameof(seasonalEventLastTimeCurrencyFoundInAdventure));
				SerializeField(s, nameof(seasonalEventLastTimeCurrencyFoundInTree));
				SerializeField(s, nameof(seasonalEventLastTimeCurrencyFoundInLevel));
				SerializeField(s, nameof(seasonalEventFamilyList));
				SerializeField(s, nameof(currentSeasonalEventId));
				SerializeField(s, nameof(clusterName));
				SerializeField(s, nameof(MagnifyingGlassUsedPerAdventure_LTD));
				SerializeField(s, nameof(NbLevelUnlocked_LTD));
				SerializeField(s, nameof(NbLevelVisited_LTD));
				SerializeField(s, nameof(NbLevelCompleted_LTD));
				SerializeField(s, nameof(NbLevelBronze_LTD));
				SerializeField(s, nameof(NbLevelSilver_LTD));
				SerializeField(s, nameof(NbLevelGold_LTD));
				SerializeField(s, nameof(PropCompletion));
				SerializeField(s, nameof(PropGold));
				SerializeField(s, nameof(NbElixirSilverUsed_LTD));
				SerializeField(s, nameof(NbElixirGoldUsed_LTD));
				SerializeField(s, nameof(NbElixirNewCreatureUsed_LTD));
				SerializeField(s, nameof(NbElixirSpeedUsed_LTD));
				SerializeField(s, nameof(NbElixirSilverOwned_LTD));
				SerializeField(s, nameof(NbElixirGoldOwned_LTD));
				SerializeField(s, nameof(NbElixirNewCreatureOwned_LTD));
				SerializeField(s, nameof(NbElixirSpeedOwned_LTD));
				SerializeField(s, nameof(PropUsedElixirs));
				SerializeField(s, nameof(ratingPopupVersionToSkip));
				SerializeField(s, nameof(ratingPopupSkipLikePhase));
				SerializeField(s, nameof(neverShowRatingPopup));
				SerializeField(s, nameof(ratingPopupShownCptLtd));
				SerializeField(s, nameof(newRatingPopupRequestedCount));
				SerializeField(s, nameof(needToShowTimeSavingEndingPopup));
				SerializeField(s, nameof(ShopAgeGateCheckDone));
				SerializeField(s, nameof(ShopNonAgressiveMode));
				SerializeField(s, nameof(DecoyEggIntroDone));
				SerializeField(s, nameof(AddingMirroredLevelsDone));
				SerializeField(s, nameof(LuckyTicketAcquiredLtd));
				SerializeField(s, nameof(GoldenTicketAcquiredLtd));
				SerializeField(s, nameof(SeasonalTicketAcquiredLtd));
				SerializeField(s, nameof(ChallengeTicketAcquiredLtd));
				SerializeField(s, nameof(ChallengeTokenAcquiredLtd));
				SerializeField(s, nameof(BeatBoxSlotAcquiredLtd));
				SerializeField(s, nameof(SeasonalEggAcquiredLtd));
				SerializeField(s, nameof(RemoveAdsPurchased));
				SerializeField(s, nameof(TimerAdventureStartTimeInSec));
				SerializeField(s, nameof(TimerAdventureEndTimeInSec));
				SerializeField(s, nameof(TimerAdventureGemsExtentions));
				SerializeField(s, nameof(TimerAdventureAdExtentions));
				SerializeField(s, nameof(IsTimerAdventureEggRescued));
				SerializeField(s, nameof(CurrentPerkPackActive));
				SerializeField(s, nameof(TimeLastShownMiniEventExclamation));
				SerializeField(s, nameof(MiniEventsSessionsSinceLastShown));
			}
		}
		[Games(GameFlags.RA)]
		public partial class RO2_LuckyTicketReward : CSerializable {
			[Serialize("id"  )] public uint id;
			[Serialize("type")] public uint type;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(type));
			}
		}
		[Games(GameFlags.RA)]
		public partial class petRewardData : CSerializable {
			[Serialize("lastSpawnDay"    )] public uint lastSpawnDay;
			[Serialize("maxRewardNb"     )] public uint maxRewardNb;
			[Serialize("remainingRewards")] public uint remainingRewards;
			[Serialize("rewardType"      )] public uint rewardType;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(lastSpawnDay));
				SerializeField(s, nameof(maxRewardNb));
				SerializeField(s, nameof(remainingRewards));
				SerializeField(s, nameof(rewardType));
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_MenuOptionSave : CSerializable {
			[Serialize("musicVolume"          )] public float musicVolume;
			[Serialize("sfxVolume"            )] public float sfxVolume;
			[Serialize("language"             )] public uint language;
			[Serialize("Is3GDownloadEnabled"  )] public bool Is3GDownloadEnabled;
			[Serialize("Is3GCacheVideoEnabled")] public bool Is3GCacheVideoEnabled;
			[Serialize("notificationsEnabled" )] public bool notificationsEnabled;
			[Serialize("everyplayEnabled"     )] public bool everyplayEnabled;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(musicVolume));
				SerializeField(s, nameof(sfxVolume));
				SerializeField(s, nameof(language));
				SerializeField(s, nameof(Is3GDownloadEnabled));
				SerializeField(s, nameof(Is3GCacheVideoEnabled));
				SerializeField(s, nameof(notificationsEnabled));
				SerializeField(s, nameof(everyplayEnabled));
			}
		}
		[Games(GameFlags.RA)]
		public partial class UnlockedDoor : CSerializable {
			[Serialize("worldTag")] public StringID worldTag;
			[Serialize("type"    )] public uint type;
			[Serialize("isNew"   )] public bool isNew;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(worldTag));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(isNew));
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_MissionData : CSerializable {
			[Serialize("missionId"             )] public StringID missionId;
			[Serialize("status"                )] public uint status;
			[Serialize("hitCount"              )] public uint hitCount;
			[Serialize("activeTime"            )] public ulong activeTime;
			[Serialize("rewardAlreadyCollected")] public bool rewardAlreadyCollected;
			[Serialize("requiredHitCount"      )] public uint requiredHitCount;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(missionId));
				SerializeField(s, nameof(status));
				SerializeField(s, nameof(hitCount));
				SerializeField(s, nameof(activeTime));
				SerializeField(s, nameof(rewardAlreadyCollected));
				SerializeField(s, nameof(requiredHitCount));
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_CreatureData : CSerializable {
			[Serialize("creatureId")] public StringID creatureId;
			[Serialize("count"     )] public uint count;
			[Serialize("favorite"  )] public bool favorite;
			[Serialize("exhausted" )] public bool exhausted;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(creatureId));
				SerializeField(s, nameof(count));
				SerializeField(s, nameof(favorite));
				SerializeField(s, nameof(exhausted));
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_CostumePlayTime : CSerializable {
			[Serialize("costumeID")] public StringID costumeID;
			[Serialize("playtime" )] public float playtime;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(costumeID));
				SerializeField(s, nameof(playtime));
			}
		}
		[Games(GameFlags.RA)]
		public partial class NodeDataStruct : CSerializable {
			[Serialize("tag"              )] public StringID tag;
			[Serialize("unteaseSeen"      )] public bool unteaseSeen;
			[Serialize("unlockSeend"      )] public bool unlockSeend;
			[Serialize("sentUnlockMessage")] public bool sentUnlockMessage;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(unteaseSeen));
				SerializeField(s, nameof(unlockSeend));
				SerializeField(s, nameof(sentUnlockMessage));
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_AdventureNodeData : CSerializable {
			[Serialize("nodeType"                       )] public Enum_nodeType nodeType;
			[Serialize("nodeIndex"                      )] public uint nodeIndex;
			[Serialize("mapPath"                        )] public Path mapPath;
			[Serialize("mapType"                        )] public Enum_mapType mapType;
			[Serialize("mapKit"                         )] public Enum_mapKit mapKit;
			[Serialize("difficulty"                     )] public uint difficulty;
			[Serialize("unlocked"                       )] public bool unlocked;
			[Serialize("completed"                      )] public bool completed;
			[Serialize("spawned"                        )] public bool spawned;
			[Serialize("baseSpawned"                    )] public bool baseSpawned;
			[Serialize("childrenPathApparitionCompleted")] public bool childrenPathApparitionCompleted;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(nodeType));
				SerializeField(s, nameof(nodeIndex));
				SerializeField(s, nameof(mapPath));
				SerializeField(s, nameof(mapType));
				SerializeField(s, nameof(mapKit));
				SerializeField(s, nameof(difficulty));
				SerializeField(s, nameof(unlocked));
				SerializeField(s, nameof(completed));
				SerializeField(s, nameof(spawned));
				SerializeField(s, nameof(baseSpawned));
				SerializeField(s, nameof(childrenPathApparitionCompleted));
			}
			public enum Enum_nodeType {
				[Serialize("_unknown")] _unknown = 0,
				[Serialize("Start"   )] Start = 1,
				[Serialize("Map"     )] Map = 2,
				[Serialize("Egg"     )] Egg = 3,
				[Serialize("Exit"    )] Exit = 4,
				[Serialize("Shop"    )] Shop = 5,
			}
			public enum Enum_mapType {
				[Serialize("_unknown"         )] _unknown = 0,
				[Serialize("Lums"             )] Lums = 1,
				[Serialize("Enemies"          )] Enemies = 2,
				[Serialize("Exploration"      )] Exploration = 3,
				[Serialize("TimeTrial"        )] TimeTrial = 4,
				[Serialize("Puzzle"           )] Puzzle = 5,
				[Serialize("HideNSeek"        )] HideNSeek = 6,
				[Serialize("Soccer"           )] Soccer = 7,
				[Serialize("AdversarialSoccer")] AdversarialSoccer = 8,
			}
			public enum Enum_mapKit {
				[Serialize("_unknown"                   )] _unknown = 0,
				[Serialize("Dojo"                       )] Dojo = 1,
				[Serialize("SnowyMountain"              )] SnowyMountain = 2,
				[Serialize("BabelTower"                 )] BabelTower = 3,
				[Serialize("LandOfTheDead"              )] LandOfTheDead = 4,
				[Serialize("CastleInterior"             )] CastleInterior = 5,
				[Serialize("CastleExterior"             )] CastleExterior = 6,
				[Serialize("Swamp"                      )] Swamp = 7,
				[Serialize("EnchantedForest"            )] EnchantedForest = 8,
				[Serialize("BeanStalk"                  )] BeanStalk = 9,
				[Serialize("Avatar"                     )] Avatar = 10,
				[Serialize("_deprecated_OvergrownTemple")] _deprecated_OvergrownTemple = 11,
				[Serialize("MexicanParty"               )] MexicanParty = 12,
				[Serialize("_deprecated_CakeParty"      )] _deprecated_CakeParty = 13,
				[Serialize("_deprecated_Garbage"        )] _deprecated_Garbage = 14,
				[Serialize("Hangar"                     )] Hangar = 15,
				[Serialize("Nemo"                       )] Nemo = 16,
				[Serialize("Olympus"                    )] Olympus = 17,
				[Serialize("_deprecated_Palace"         )] _deprecated_Palace = 18,
				[Serialize("Hades"                      )] Hades = 19,
				[Serialize("Maze"                       )] Maze = 20,
				[Serialize("Intro"                      )] Intro = 21,
				[Serialize("HauntedCastle"              )] HauntedCastle = 22,
				[Serialize("DemoMix"                    )] DemoMix = 23,
				[Serialize("Temple"                     )] Temple = 24,
				[Serialize("OpenOcean"                  )] OpenOcean = 25,
				[Serialize("AncientRuins"               )] AncientRuins = 26,
				[Serialize("Urban"                      )] Urban = 27,
				[Serialize("Rural"                      )] Rural = 28,
			}
		}
		[Games(GameFlags.RA)]
		public partial class st_petCups : CSerializable {
			[Serialize("family")] public int family;
			[Serialize("cups"  )] public uint cups;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(family));
				SerializeField(s, nameof(cups));
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_ElixirUtilisation : CSerializable {
			[Serialize("elixirType"   )] public Enum_elixirType elixirType;
			[Serialize("nbElixirs"    )] public uint nbElixirs;
			[Serialize("remainingTime")] public float remainingTime;
			[Serialize("dateTime"     )] public online.DateTime dateTime;
			[Serialize("gemsCost"     )] public uint gemsCost;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(elixirType));
				SerializeField(s, nameof(nbElixirs));
				SerializeField(s, nameof(remainingTime));
				SerializeField(s, nameof(dateTime));
				SerializeField(s, nameof(gemsCost));
			}
			public enum Enum_elixirType {
				[Serialize("_unknown"         )] _unknown = 0,
				[Serialize("SpeedHatching"    )] SpeedHatching = 1,
				[Serialize("UpgradeToUncommon")] UpgradeToUncommon = 2,
				[Serialize("UpgradeToRare"    )] UpgradeToRare = 3,
				[Serialize("ForceNewCreature" )] ForceNewCreature = 4,
				[Serialize("HatchNow"         )] HatchNow = 5,
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_NextRegionTravelMark : CSerializable {
			[Serialize("pos"                               )] public Vector3 pos;
			[Serialize("adventureSequence"                 )] public uint adventureSequence;
			[Serialize("adventureStartDate"                )] public online.DateTime adventureStartDate;
			[Serialize("adventureLifeTimeInSec"            )] public ulong adventureLifeTimeInSec;
			[Serialize("adventureDefaultLifeTimeInSec"     )] public ulong adventureDefaultLifeTimeInSec;
			[Serialize("timeLimitedAdventureTutorialShown" )] public uint timeLimitedAdventureTutorialShown;
			[Serialize("timeLimitedAdventureCompleteInTime")] public uint timeLimitedAdventureCompleteInTime;
			[Serialize("timeLimitedAdventureRewardCredited")] public bool timeLimitedAdventureRewardCredited;
			[Serialize("region"                            )] public Enum_region region;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(adventureSequence));
				SerializeField(s, nameof(adventureStartDate));
				SerializeField(s, nameof(adventureLifeTimeInSec));
				SerializeField(s, nameof(adventureDefaultLifeTimeInSec));
				SerializeField(s, nameof(timeLimitedAdventureTutorialShown));
				SerializeField(s, nameof(timeLimitedAdventureCompleteInTime));
				SerializeField(s, nameof(timeLimitedAdventureRewardCredited));
				SerializeField(s, nameof(region));
			}
			public enum Enum_region {
				[Serialize("_unknown"     )] _unknown = 0,
				[Serialize("Shaolin"      )] Shaolin = 1,
				[Serialize("Medieval"     )] Medieval = 2,
				[Serialize("ToadStory"    )] ToadStory = 3,
				[Serialize("Desert"       )] Desert = 4,
				[Serialize("UnderWater"   )] UnderWater = 5,
				[Serialize("Greece"       )] Greece = 6,
				[Serialize("LandOfTheDead")] LandOfTheDead = 7,
				[Serialize("Intro"        )] Intro = 8,
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_EggData : CSerializable {
			[Serialize("creatureId" )] public StringID creatureId;
			[Serialize("rewardType" )] public Enum_rewardType rewardType;
			[Serialize("decoyReward")] public RLC_LuckyTicketReward decoyReward;
			[Serialize("region"     )] public Enum_region region;
			[Serialize("rarity"     )] public Creature_Rarity rarity;
			[Serialize("spyGlass"   )] public bool spyGlass;
			[Serialize("version"    )] public uint version;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(creatureId));
				SerializeField(s, nameof(rewardType));
				SerializeField(s, nameof(decoyReward));
				SerializeField(s, nameof(region));
				SerializeField(s, nameof(rarity));
				SerializeField(s, nameof(spyGlass));
				SerializeField(s, nameof(version));
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
			public enum Enum_region {
				[Serialize("_unknown"     )] _unknown = 0,
				[Serialize("Shaolin"      )] Shaolin = 1,
				[Serialize("Medieval"     )] Medieval = 2,
				[Serialize("ToadStory"    )] ToadStory = 3,
				[Serialize("Desert"       )] Desert = 4,
				[Serialize("UnderWater"   )] UnderWater = 5,
				[Serialize("Greece"       )] Greece = 6,
				[Serialize("LandOfTheDead")] LandOfTheDead = 7,
				[Serialize("Intro"        )] Intro = 8,
			}
			public enum Creature_Rarity {
				[Serialize("Creature_Rarity::common"   )] common = 0,
				[Serialize("Creature_Rarity::unCommon" )] unCommon = 1,
				[Serialize("Creature_Rarity::rare"     )] rare = 2,
				[Serialize("Creature_Rarity::epic"     )] epic = 3,
				[Serialize("Creature_Rarity::legendary")] legendary = 4,
				[Serialize("Creature_Rarity::queen"    )] queen = 5,
				[Serialize("Creature_Rarity::unknown"  )] unknown = 6,
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_NextRegionEggSelectionData : CSerializable {
			[Serialize("pos"                               )] public Vector3 pos;
			[Serialize("adventureSequence"                 )] public uint adventureSequence;
			[Serialize("adventureStartDate"                )] public online.DateTime adventureStartDate;
			[Serialize("adventureLifeTimeInSec"            )] public ulong adventureLifeTimeInSec;
			[Serialize("adventureDefaultLifeTimeInSec"     )] public ulong adventureDefaultLifeTimeInSec;
			[Serialize("timeLimitedAdventureTutorialShown" )] public uint timeLimitedAdventureTutorialShown;
			[Serialize("timeLimitedAdventureCompleteInTime")] public uint timeLimitedAdventureCompleteInTime;
			[Serialize("timeLimitedAdventureRewardCredited")] public bool timeLimitedAdventureRewardCredited;
			[Serialize("region"                            )] public Enum_region region;
			[Serialize("creatureId"                        )] public StringID creatureId;
			[Serialize("rarity"                            )] public Creature_Rarity rarity;
			[Serialize("eggData"                           )] public RO2_PersistentGameData_Universe.RLC_EggData eggData;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(adventureSequence));
				SerializeField(s, nameof(adventureStartDate));
				SerializeField(s, nameof(adventureLifeTimeInSec));
				SerializeField(s, nameof(adventureDefaultLifeTimeInSec));
				SerializeField(s, nameof(timeLimitedAdventureTutorialShown));
				SerializeField(s, nameof(timeLimitedAdventureCompleteInTime));
				SerializeField(s, nameof(timeLimitedAdventureRewardCredited));
				SerializeField(s, nameof(region));
				SerializeField(s, nameof(creatureId));
				SerializeField(s, nameof(rarity));
				SerializeField(s, nameof(eggData));
			}
			public enum Enum_region {
				[Serialize("_unknown"     )] _unknown = 0,
				[Serialize("Shaolin"      )] Shaolin = 1,
				[Serialize("Medieval"     )] Medieval = 2,
				[Serialize("ToadStory"    )] ToadStory = 3,
				[Serialize("Desert"       )] Desert = 4,
				[Serialize("UnderWater"   )] UnderWater = 5,
				[Serialize("Greece"       )] Greece = 6,
				[Serialize("LandOfTheDead")] LandOfTheDead = 7,
				[Serialize("Intro"        )] Intro = 8,
			}
			public enum Creature_Rarity {
				[Serialize("Creature_Rarity::common"   )] common = 0,
				[Serialize("Creature_Rarity::unCommon" )] unCommon = 1,
				[Serialize("Creature_Rarity::rare"     )] rare = 2,
				[Serialize("Creature_Rarity::epic"     )] epic = 3,
				[Serialize("Creature_Rarity::legendary")] legendary = 4,
				[Serialize("Creature_Rarity::queen"    )] queen = 5,
				[Serialize("Creature_Rarity::unknown"  )] unknown = 6,
			}
		}
		[Games(GameFlags.RA)]
		public partial class SeasonalEventData : CSerializable {
			[Serialize("unlocked")] public bool unlocked;
			[Serialize("finished")] public bool finished;
			[Serialize("familyId")] public CList<uint> familyId;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(unlocked));
				SerializeField(s, nameof(finished));
				SerializeField(s, nameof(familyId));
			}
		}
		public enum Enum_adventureBoatState {
			[Serialize("none"               )] none = 0,
			[Serialize("Start_Spawn"        )] Start_Spawn = 1,
			[Serialize("Start_Wait"         )] Start_Wait = 2,
			[Serialize("Start_Leave"        )] Start_Leave = 4,
			[Serialize("Exit_Spawn"         )] Exit_Spawn = 8,
			[Serialize("Exit_Wait"          )] Exit_Wait = 9,
			[Serialize("Exit_Leave"         )] Exit_Leave = 11,
			[Serialize("Before_Start"       )] Before_Start = 15,
			[Serialize("AdventureInProgress")] AdventureInProgress = 16,
		}
		public enum Enum_IncubatorCreatureRegion {
			[Serialize("_unknown"     )] _unknown = 0,
			[Serialize("Shaolin"      )] Shaolin = 1,
			[Serialize("Medieval"     )] Medieval = 2,
			[Serialize("ToadStory"    )] ToadStory = 3,
			[Serialize("Desert"       )] Desert = 4,
			[Serialize("UnderWater"   )] UnderWater = 5,
			[Serialize("Greece"       )] Greece = 6,
			[Serialize("LandOfTheDead")] LandOfTheDead = 7,
			[Serialize("Intro"        )] Intro = 8,
		}
		public enum RLC_GraphicalFamily {
			[Serialize("RLC_GraphicalFamily_Unknown"      )] Unknown = 0,
			[Serialize("RLC_GraphicalFamily_Shaolin"      )] Shaolin = 1,
			[Serialize("RLC_GraphicalFamily_Medieval"     )] Medieval = 2,
			[Serialize("RLC_GraphicalFamily_ToadStory"    )] ToadStory = 3,
			[Serialize("RLC_GraphicalFamily_Desert"       )] Desert = 4,
			[Serialize("RLC_GraphicalFamily_UnderWater"   )] UnderWater = 5,
			[Serialize("RLC_GraphicalFamily_Greece"       )] Greece = 6,
			[Serialize("RLC_GraphicalFamily_LandOfTheDead")] LandOfTheDead = 7,
			[Serialize("RLC_GraphicalFamily_Intro"        )] Intro = 8,
			[Serialize("RLC_GraphicalFamily_Count"        )] Count = 9,
		}
		public override uint? ClassCRC => 0xBAA85A3F;
	}
}

