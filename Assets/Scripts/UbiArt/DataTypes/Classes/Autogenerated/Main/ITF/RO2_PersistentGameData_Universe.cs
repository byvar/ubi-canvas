namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PersistentGameData_Universe : PersistentGameData_Universe {
		public RO2_PersistentGameData_Score score;
		public RO2_PersistentGameData_BubbleDreamerData bubbleDreamer;
		public CArrayP<int> unlockedPets;
		public CListO<RO2_PersistentGameData_Universe.petRewardData> petsDailyReward;
		public CListO<RO2_PersistentGameData_Universe.st_petCups> unlockedCupsForPets;
		public uint givenPetCount;
		public bool newPetsUnlocked;
		public bool firstPetShown;
		public bool hasShownMessageAllPet;
		public uint messagesTotalCount;
		public online.DateTime messages_onlineDate;
		public online.DateTime messages_localDate;
		public uint messages_readDrcCount;
		public uint messages_interactDrcCount;
		public uint messages_lastSeenMessageHandle;
		public uint messages_tutoCount;
		public uint messages_drcCountSinceLastInteract;
		public uint playerCard_displayedCount;
		public bool playerCard_tutoSeen;
		public bool gameCompleted;
		public uint timeToCompleteGameInSec;
		public uint timeSpendInGameInSec;
		public uint teensiesBonusCounter;
		public uint luckyTicketsCounter;
		public uint luckyTicketLevelCount;
		public uint retroMapUnlockedCounter;
		public uint catchEmAllIndex;
		public CListO<RO2_PersistentGameData_Universe.UnlockedDoor> newUnlockedDoor;
		public CListO<RO2_PersistentGameData_Universe.RO2_LuckyTicketReward> luckyTicketRewardList;
		public CListO<RO2_PersistentGameData_Universe.NodeDataStruct> nodeData;
		public uint luckyTicketsRewardGivenCounter;
		public uint consecutiveLuckyTicketCount;
		public uint ticketReminderMessageCount;
		public uint displayGhosts;
		public bool uplayDoneAction0;
		public bool uplayDoneAction1;
		public bool uplayDoneAction2;
		public bool uplayDoneAction3;
		public bool uplayDoneAction4;
		public bool uplayDoneReward0;
		public bool uplayDoneReward1;
		public bool uplayDoneReward2;
		public bool uplayDoneReward3;
		public CListP<uint> playedChallenge;
		public uint tvOffOptionEnabledNb;
		public uint tvOffOptionActivatedTime;
		public bool barbaraCostumeUnlockSeen;
		public bool retroWorldUnlockMessageSeen;
		public bool freedAllTeensiesMessageSeen;
		public bool MisterDarkCompletionMessageSeen;
		public bool FirstInvasionMessageSeen;
		public bool InvitationTutoSeen;
		public bool MessageSeen8Bit;
		public bool challengeWorldUnlockMessageSeen;
		public StringID luckyTicketRewardWorldName;
		public bool isUGCMiiverseWarningSet;
		public string unlockPrivilegesData;
		public PrisonerData prisonerDataDummy;
		public RO2_PersistentGameData_Level persistentGameDataLevelDummy;
		public RO2_PersistentGameData_Universe.UnlockedDoor unlockedDoorDummy;
		public RO2_PersistentGameData_BubbleDreamerData bubbleDreamerDataDummy;
		public RO2_PersistentGameData_Universe.NodeDataStruct dummmyNodeData;
		public CListO<RO2_PersistentGameData_Universe.RLC_AdventureNodeData> adventureNodeDataList;
		public bool introCompleted;
		public bool introCreatureHatched;
		public bool devTeam;
		public bool onboardingCompleted;
		public online.DateTime gameStartDateTime;
		public uint globalSessionNb;
		public bool isNotificationConfirmationDialogShown;
		public uint foodAcquiredNbLtd;
		public online.DateTime foodRefillStartDate;
		public uint gemsAcquiredNbLtd;
		public uint MglassAcquiredNbLtd;
		public uint MGlassBoughtWithGemsNbLtd;
		public uint rewardedVideoNbLtd;
		public uint everyPlaySharedVideoNbLtd;
		public uint gemsUsedNbLtd;
		public uint nbMailboxReadLtd;
		public uint characterSelectionNb;
		public uint adventureSessionNb;
		public uint adventureId;
		public bool skipAdventure;
		public online.DateTime adventureStartDate;
		public ulong adventureLifeTimeInSec;
		public ulong adventureDefaultLifeTimeInSec;
		public uint timeLimitedAdventureTutorialShown;
		public uint timeLimitedAdventureCompleteInTime;
		public bool timeLimitedAdventureRewardCredited;
		public uint adventureRenderParamIndex;
		public bool adventureNewGameDone;
		public uint adventureGlobalIndex;
		public Path adventurePath;
		public bool adventureCharlieFound;
		public uint totalCharlieFound;
		public bool tutorialCharlieFound;
		public bool tutorialCharlieOptionalFound;
		public bool tutorialFeedInGoScreenFound;
		public bool newElixirDialogAlreadySeen;
		public bool adventureFinishedAlreadyDisplayed;
		public bool adventureCompleteAlreadyDisplayed;
		public online.DateTime joinDate;
		public uint iapScore;
		public string originalDeviceId;
		public uint spinCount;
		public uint levelTryCount;
		public uint challengeWheelRewardType;
		public uint challengeWheelMapType;
		public uint challengeWheelLevelType;
		public PathRef challengeWheelMapPath;
		public uint challengeWheelMapResult;
		public ulong challengeWheelCompleteTime;
		public ulong challengeWheelIntroPopupShowTimeInSec;
		public bool needToShowSeasonalEventExclamation;
		public ulong endLessRunnerEventIntroPopupShowTimeInSec;
		public uint m_FacebookBenefitsShownFoeEventID;
		public bool isScratchingFirstLuckyTicket;
		public bool isScratchingSecondLuckyTicket;
		public bool tutoLuckyTicketHasBeenConsumed;
		public bool shopAlreadyOpened;
		public bool facebookBenefitsAlreadyProposed;
		public bool facebookBenefitsAlreadyOpened;
		public uint adventureCharlieCountdown;
		public uint bonusMapCountDown;
		public uint challengeMapCountDown;
		public StringID playerCostumeSkin;
		public online.DateTime dailyObjectiveRefreshDate;
		public online.DateTime lastTokenRefreshDate;
		public ulong lastEventBundleUIShownTime;
		public online.DateTime amarCreaturesEndDate;
		public uint lastOpenedChallengeSeed;
		public uint lastChallengeSeed;
		public uint dailyChallengeBestScore;
		public uint dailyChallengeBestDistance;
		public CArrayO<Vec3d> lastChallengeTombs;
		public uint dailyChallengeTicketPiecesState0;
		public uint dailyChallengeTicketPiecesState1;
		public uint dailyChallengeTicketPiecesState2;
		public bool dailyChallengeTicketCollected;
		public uint retryPostDailyChallengeScore;
		public CListO<RO2_PersistentGameData_Universe.RLC_MissionData> missionDataList;
		public CListO<RO2_PersistentGameData_Universe.RLC_CreatureData> creatureDataList;
		public RO2_PersistentGameData_Universe.RLC_CreatureData currentCreatureData;
		public uint nbHatchedEggsSinceLastNewCreature;
		public bool awayLongEnoughToHatchNewCreature;
		public uint hatchFailCounter_NewCreature;
		public uint hatchFailCounter_Queen;
		public RO2_PersistentGameData_Universe.RLC_EggData adventureEggData;
		public bool mb_needRequestStartNextAdventureParam;
		public RO2_PersistentGameData_Universe.RLC_EggData incubatorEggData;
		public CListO<RO2_PersistentGameData_Universe.RLC_ElixirUtilisation> incubatorElixirUtilisations;
		public uint incubatorEggAdventureSequence;
		public bool eggHatchingComplete;
		public bool eggFirstTapComplete;
		public bool lastEggHatchingTimeSkipped;
		public online.DateTime incubatorDateTimeEggHatchingComplete;
		public online.DateTime lastSavedGameDateTime;
		public float incubationDuration;
		public bool StartValuesSet;
		public RO2_PersistentGameData_Universe.RLC_MenuOptionSave menuOptionSave;
		public bool languageArabicPopupDisplayed;
		public CListO<RO2_PersistentGameData_Universe.RLC_CostumePlayTime> CostumePlayTime;
		public float globalPlayTime;
		public float adventurePlayTime;
		public uint adventureStep;
		public float adventureStepPlayTime;
		public Enum_adventureBoatState adventureBoatState;
		public float TreePlayTime;
		public float BeatBoxPlayTime;
		public float shopPlayTime;
		public float shopFoodPlayTime;
		public float shopElixirPlayTime;
		public float shopCostumePlayTime;
		public float shopLuckyTicketPlayTime;
		public float shopPrimaryPlayTime;
		public uint nbPrimaryStoreVisits;
		public uint nbLuckyTicketsScratchedLtd;
		public uint nbGoldenTicketsScratchedLtd;
		public uint nbClicksOnBuyBeatboxSlots;
		public uint BeatBoxUsedCount;
		public uint BeatBoxNoteCount;
		public uint eggSequence;
		public uint adventureEggSequence;
		public uint runId;
		public uint shopVisitNb;
		public float hatchingCountdownRemainingSkipped;
		public bool TrackingEggAlreadyReached;
		public bool TrackingEggAlreadyPicked;
		public uint TrackingCptFlurry;
		public uint TrackingCptUbiServices;
		public uint currentDuplicateStars;
		public uint lastShownDuplicateStars;
		public uint totalSpentDuplicateStars;
		public uint lastRefusedDuplicateChoice;
		public uint nbDuplicateCreaturesLtd;
		public uint nbLuckyTicketsNoDuplicate;
		public uint nbGoldenTicketsNoDuplicate;
		public uint duplicateChoiceClaimIndex;
		public uint duplicateChoiceWaitIndex;
		public bool stoppedDuringDuplicateChoice;
		public bool newDailyObjectivesAlreadyPopped;
		public bool dailyObjectiveShuffleAvailable;
		public bool dailyObjectiveTicketAvailable;
		public bool dailyObjective0AlreadyShown;
		public bool dailyObjective1AlreadyShown;
		public bool dailyObjective2AlreadyShown;
		public bool dailyObjectiveTicketPart0Reached;
		public bool dailyObjectiveTicketPart1Reached;
		public bool dailyObjectiveTicketPart2Reached;
		public uint nbDailyObjectiveShuffle;
		public uint saveRandomBackgroundId;
		public online.DateTime firstShopOpeningDate;
		public CListP<uint> alreadyBoughtStarterPacks;
		public CListP<uint> alreadyBoughStoreBundles;
		public CListP<string> alreadyBoughtDynamicPacks;
		public CListO<StringID> unlockedCostumesNotSeenYet;
		public CListO<RLC_ShopCostumeVersion> alreadySeenCostumeTrades;
		public uint gppSessionId;
		public online.DateTime lastSessionStartTimestamp;
		public uint nbSessionsBeforeFacebookProposal;
		public int nbSessionsWithMailboxWaiting;
		public online.DateTime lastStarterPackPopupTimestamp;
		public CMap<RLC_StoreBundle.Type, RLC_AutomaticPopupSave> automaticPopupSaves;
		public CMap<RLC_StoreBundle.Type, RLC_SpecialPackSave> specialPackSaves;
		public CMap<StringID, online.DateTime> lastSentGiftsTimestamps;
		public CMap<StringID, online.DateTime> lastAskForGiftsTimestamps;
		public bool inviteFriendsRewardWaiting;
		public bool showInviteFriendsExclamation;
		public bool creatureDoesntNeedFoodDialogShown;
		public bool radarExhaustDialogShown;
		public bool shieldActivateDialogShown;
		public bool magnetActivateDialogShown;
		public bool beatboxSaveConfirmation;
		public bool beatboxTrashConfirmation;
		public bool forcedGreeceFirstLevel;
		public StringID lastAdventureEggHatched;
		public StringID lastNewCreatureId;
		public bool tutoLeaderboardDone;
		public bool tutoMapButtonAlreadyDisplayed;
		public bool ritualBeforeTutoLeaderboardDone;
		public bool betweenTwoAdventures;
		public bool legalPopupAlreadySeen;
		public bool luckyTicketShopAlreadyEntered;
		public bool elixirShopAlreadyEntered;
		public bool beatboxShopAlreadyEntered;
		public RLC_GraphicalFamily lastAdventureRegion;
		public RLC_GraphicalFamily nextRegion0;
		public RLC_GraphicalFamily nextRegion1;
		public RLC_GraphicalFamily nextRegion2;
		public RLC_GraphicalFamily nextRegion3;
		public RLC_GraphicalFamily nextRegion4;
		public RLC_GraphicalFamily forcedNextRegion;
		public uint nextRegionsChoiceNb;
		public bool nextRegionRandomDone;
		public CListP<RLC_GraphicalFamily> revealedRegions;
		public CListO<RO2_PersistentGameData_Universe.RLC_NextRegionTravelMark> nextRegionTravelMarks;
		public CListO<RO2_PersistentGameData_Universe.RLC_NextRegionEggSelectionData> nextRegionEggSelectionData;
		public StringID nextRegionsCreatureID0;
		public StringID nextRegionsCreatureID1;
		public StringID nextRegionsCreatureID2;
		public StringID nextRegionsCreatureID3;
		public StringID nextRegionsCreatureID4;
		public StringID forcedIncubatorCreatureID_BeforeElixirs;
		public StringID forcedNextRegionCreatureID;
		public StringID forcedIncubatorCreatureID;
		public Enum_IncubatorCreatureRegion IncubatorCreatureRegion;
		public bool nextRegionMagnifyingGlassUsed;
		public uint MagnifyingGlassUsedLtd;
		public bool adventureEggRarityRevealed;
		public uint treeSeed;
		public uint adventureSeed;
		public CListO<StringID> treeRewardFamilyComplete;
		public bool RewardDojoRegionUnlocked;
		public uint saveBranchId;
		public string fbToken;
		public uint completeAllCreatureValue;
		public bool EndGamePlayersInformedAboutNewFamilies;
		public string currentTutorialStepString;
		public string currentBeatboxTutoStepString;
		public uint IncubatorElixirUtilisationsCountLtd0;
		public uint IncubatorElixirUtilisationsCountLtd1;
		public uint IncubatorElixirUtilisationsCountLtd2;
		public uint IncubatorElixirUtilisationsCountLtd3;
		public uint IncubatorElixirUtilisationsCountLtd4;
		public uint IncubatorElixirUtilisationsCountLtd5;
		public StringID hatchingRitualInProgressCreatureId;
		public RLC_CreatureAcquisition hatchingRitualInProgressAcquisitionSource;
		public RO2_PersistentGameData_Universe.RLC_EggData hatchingRitualInProgressEggData;
		public CMap<StringID, string> optionalData;
		public uint additionalDataBufferInt0;
		public uint additionalDataBufferInt1;
		public uint additionalDataBufferInt2;
		public uint additionalDataBufferInt3;
		public uint additionalDataBufferInt4;
		public uint additionalDataBufferInt5;
		public uint additionalDataBufferInt6;
		public uint additionalDataBufferInt7;
		public uint additionalDataBufferInt8;
		public uint additionalDataBufferInt9;
		public bool additionalDataBufferBool0;
		public bool additionalDataBufferBool1;
		public bool additionalDataBufferBool2;
		public bool additionalDataBufferBool3;
		public bool additionalDataBufferBool4;
		public bool additionalDataBufferBool5;
		public bool additionalDataBufferBool6;
		public bool additionalDataBufferBool7;
		public bool additionalDataBufferBool8;
		public bool additionalDataBufferBool9;
		public float additionalDataBufferFloat0;
		public float additionalDataBufferFloat1;
		public float additionalDataBufferFloat2;
		public float additionalDataBufferFloat3;
		public float additionalDataBufferFloat4;
		public float additionalDataBufferFloat5;
		public float additionalDataBufferFloat6;
		public float additionalDataBufferFloat7;
		public float additionalDataBufferFloat8;
		public float additionalDataBufferFloat9;
		public online.DateTime LastAdsSeenDateTime;
		public online.DateTime LastContextualAdsSeenDateTime;
		public uint MGlassAdsAdventureSequence;
		public bool ShowFreeElixirAd;
		public uint maxTokenNb;
		public uint tokenRefreshCooldown;
		public uint eggAcquisition;
		public uint maxContinue;
		public uint continueCostX;
		public uint startContinueCost;
		public uint maxContinueCost;
		public uint maxContinueWatchAd;
		public int SeasonalEventLastChanceId;
		public CListO<RLC_BeatboxDataList> BeatboxCreatureList;
		public string profileId;
		public string PlayerNameNext;
		public uint askedSlot;
		public CListO<RLC_MailboxElementLight> readMailboxElements;
		public string msdkItems;
		public float PlayTime_Leaderboard_Global;
		public float PlayTime_Leaderboard_Friends;
		public float PlayTime_Leaderboard_Country;
		public float PlayTime_Leaderboard_Worldwide;
		public float PlayTime_Leaderboard_Likes;
		public float Playtime_Leaderboard_VisitingTree;
		public uint Leaderboard_VisitingTreeCount;
		public uint Leaderboard_VisitingProfileCount;
		public CMap<uint, pair<uint, RLC_CreatureTreeTier>> TreeEventFamilyMap;
		public uint seasonalEventCurrencyPoolAdventure;
		public uint seasonalEventCurrencyPoolTree;
		public uint seasonalEventCurrencyPoolLevel;
		public uint seasonalCurrencyFoundInAdventureValueLTD;
		public uint seasonalCurrencyFoundInTreeValueLTD;
		public uint seasonalCurrencyFoundInLevelValueLTD;
		public uint seasonalCurrencyAcquiredInPrimaryStoreLTD;
		public uint seasonalCurrencyAcquiredInCheatLTD;
		public uint seasonalCurrencyAcquiredTotalLTD;
		public uint seasonalCurrencyUsedLTD;
		public uint legChallengeRunsCount;
		public uint totalChallengeRunsCount;
		public online.DateTime seasonalEventLastTimeCurrencySpawnInAdventure;
		public online.DateTime seasonalEventLastTimeCurrencySpawnInTree;
		public online.DateTime seasonalEventLastTimeCurrencySpawnInLevel;
		public online.DateTime seasonalEventLastTimeCurrencyFoundInAdventure;
		public online.DateTime seasonalEventLastTimeCurrencyFoundInTree;
		public online.DateTime seasonalEventLastTimeCurrencyFoundInLevel;
		public CMap<uint, RO2_PersistentGameData_Universe.SeasonalEventData> seasonalEventFamilyList;
		public uint currentSeasonalEventId;
		public string clusterName;
		public float MagnifyingGlassUsedPerAdventure_LTD;
		public uint NbLevelUnlocked_LTD;
		public uint NbLevelVisited_LTD;
		public uint NbLevelCompleted_LTD;
		public uint NbLevelBronze_LTD;
		public uint NbLevelSilver_LTD;
		public uint NbLevelGold_LTD;
		public float PropCompletion;
		public float PropGold;
		public uint NbElixirSilverUsed_LTD;
		public uint NbElixirGoldUsed_LTD;
		public uint NbElixirNewCreatureUsed_LTD;
		public uint NbElixirSpeedUsed_LTD;
		public uint NbElixirSilverOwned_LTD;
		public uint NbElixirGoldOwned_LTD;
		public uint NbElixirNewCreatureOwned_LTD;
		public uint NbElixirSpeedOwned_LTD;
		public float PropUsedElixirs;
		public string ratingPopupVersionToSkip;
		public bool ratingPopupSkipLikePhase;
		public bool neverShowRatingPopup;
		public uint ratingPopupShownCptLtd;
		public uint newRatingPopupRequestedCount;
		public CListP<string> playedGameVersions;
		public bool needToShowTimeSavingEndingPopup;
		public bool ShopAgeGateCheckDone;
		public bool ShopNonAgressiveMode;
		public bool DecoyEggIntroDone;
		public bool AddingMirroredLevelsDone;
		public uint LuckyTicketAcquiredLtd;
		public uint GoldenTicketAcquiredLtd;
		public uint SeasonalTicketAcquiredLtd;
		public uint ChallengeTicketAcquiredLtd;
		public uint ChallengeTokenAcquiredLtd;
		public uint BeatBoxSlotAcquiredLtd;
		public uint SeasonalEggAcquiredLtd;
		public bool RemoveAdsPurchased;
		public ulong TimerAdventureStartTimeInSec;
		public ulong TimerAdventureEndTimeInSec;
		public uint TimerAdventureGemsExtentions;
		public uint TimerAdventureAdExtentions;
		public bool IsTimerAdventureEggRescued;
		public uint CurrentPerkPackActive;
		public online.DateTime TimeLastShownMiniEventExclamation;
		public uint MiniEventsSessionsSinceLastShown;
		public RichProfile profile;
		public CListO<Message> messages;
		public CArrayO<StringID> mrDarkUnlockCount;
		public CArrayO<StringID> newCostumes;
		public CArrayO<StringID> costumeUnlockSeen;
		public CArrayO<StringID> retroUnlocks;
		public CArrayO<StringID> playedDiamondCupSequence;
		public CArrayO<StringID> costumes;
		public CArrayO<StringID> playedInvasion;
		public CArrayO<StringID> worldUnlockMessagesSeen;
		public CArrayO<StringID> doorUnlockMessageSeen;
		public CArrayO<StringID> doorUnlockDRCMessageRequired;
		public int reward39Failed;
		public int isDemoRewardChecked;
		public Message messageDummy;
		public RO2_PersistentGameData_IAP iap;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				score = s.SerializeObject<RO2_PersistentGameData_Score>(score, name: "score");
				profile = s.SerializeObject<RichProfile>(profile, name: "profile");
				bubbleDreamer = s.SerializeObject<RO2_PersistentGameData_BubbleDreamerData>(bubbleDreamer, name: "bubbleDreamer");
				unlockedPets = s.SerializeObject<CArrayP<int>>(unlockedPets, name: "unlockedPets");
				petsDailyReward = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.petRewardData>>(petsDailyReward, name: "petsDailyReward");
				unlockedCupsForPets = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.st_petCups>>(unlockedCupsForPets, name: "unlockedCupsForPets");
				givenPetCount = s.Serialize<uint>(givenPetCount, name: "givenPetCount");
				newPetsUnlocked = s.Serialize<bool>(newPetsUnlocked, name: "newPetsUnlocked");
				firstPetShown = s.Serialize<bool>(firstPetShown, name: "firstPetShown");
				hasShownMessageAllPet = s.Serialize<bool>(hasShownMessageAllPet, name: "hasShownMessageAllPet");
				messages = s.SerializeObject<CListO<Message>>(messages, name: "messages");
				messagesTotalCount = s.Serialize<uint>(messagesTotalCount, name: "messagesTotalCount");
				messages_onlineDate = s.SerializeObject<online.DateTime>(messages_onlineDate, name: "messages_onlineDate");
				messages_localDate = s.SerializeObject<online.DateTime>(messages_localDate, name: "messages_localDate");
				messages_readDrcCount = s.Serialize<uint>(messages_readDrcCount, name: "messages_readDrcCount");
				messages_interactDrcCount = s.Serialize<uint>(messages_interactDrcCount, name: "messages_interactDrcCount");
				messages_lastSeenMessageHandle = s.Serialize<uint>(messages_lastSeenMessageHandle, name: "messages_lastSeenMessageHandle");
				messages_tutoCount = s.Serialize<uint>(messages_tutoCount, name: "messages_tutoCount");
				messages_drcCountSinceLastInteract = s.Serialize<uint>(messages_drcCountSinceLastInteract, name: "messages_drcCountSinceLastInteract");
				playerCard_displayedCount = s.Serialize<uint>(playerCard_displayedCount, name: "playerCard_displayedCount");
				playerCard_tutoSeen = s.Serialize<bool>(playerCard_tutoSeen, name: "playerCard_tutoSeen");
				gameCompleted = s.Serialize<bool>(gameCompleted, name: "gameCompleted");
				timeToCompleteGameInSec = s.Serialize<uint>(timeToCompleteGameInSec, name: "timeToCompleteGameInSec");
				timeSpendInGameInSec = s.Serialize<uint>(timeSpendInGameInSec, name: "timeSpendInGameInSec");
				teensiesBonusCounter = s.Serialize<uint>(teensiesBonusCounter, name: "teensiesBonusCounter");
				luckyTicketsCounter = s.Serialize<uint>(luckyTicketsCounter, name: "luckyTicketsCounter");
				luckyTicketLevelCount = s.Serialize<uint>(luckyTicketLevelCount, name: "luckyTicketLevelCount");
				retroMapUnlockedCounter = s.Serialize<uint>(retroMapUnlockedCounter, name: "retroMapUnlockedCounter");
				mrDarkUnlockCount = s.SerializeObject<CArrayO<StringID>>(mrDarkUnlockCount, name: "mrDarkUnlockCount");
				catchEmAllIndex = s.Serialize<uint>(catchEmAllIndex, name: "catchEmAllIndex");
				newCostumes = s.SerializeObject<CArrayO<StringID>>(newCostumes, name: "newCostumes");
				costumeUnlockSeen = s.SerializeObject<CArrayO<StringID>>(costumeUnlockSeen, name: "costumeUnlockSeen");
				retroUnlocks = s.SerializeObject<CArrayO<StringID>>(retroUnlocks, name: "retroUnlocks");
				newUnlockedDoor = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.UnlockedDoor>>(newUnlockedDoor, name: "newUnlockedDoor");
				luckyTicketRewardList = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RO2_LuckyTicketReward>>(luckyTicketRewardList, name: "luckyTicketRewardList");
				nodeData = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.NodeDataStruct>>(nodeData, name: "nodeData");
				luckyTicketsRewardGivenCounter = s.Serialize<uint>(luckyTicketsRewardGivenCounter, name: "luckyTicketsRewardGivenCounter");
				consecutiveLuckyTicketCount = s.Serialize<uint>(consecutiveLuckyTicketCount, name: "consecutiveLuckyTicketCount");
				ticketReminderMessageCount = s.Serialize<uint>(ticketReminderMessageCount, name: "ticketReminderMessageCount");
				displayGhosts = s.Serialize<uint>(displayGhosts, name: "displayGhosts");
				uplayDoneAction0 = s.Serialize<bool>(uplayDoneAction0, name: "uplayDoneAction0");
				uplayDoneAction1 = s.Serialize<bool>(uplayDoneAction1, name: "uplayDoneAction1");
				uplayDoneAction2 = s.Serialize<bool>(uplayDoneAction2, name: "uplayDoneAction2");
				uplayDoneAction3 = s.Serialize<bool>(uplayDoneAction3, name: "uplayDoneAction3");
				uplayDoneReward0 = s.Serialize<bool>(uplayDoneReward0, name: "uplayDoneReward0");
				uplayDoneReward1 = s.Serialize<bool>(uplayDoneReward1, name: "uplayDoneReward1");
				uplayDoneReward2 = s.Serialize<bool>(uplayDoneReward2, name: "uplayDoneReward2");
				uplayDoneReward3 = s.Serialize<bool>(uplayDoneReward3, name: "uplayDoneReward3");
				playedDiamondCupSequence = s.SerializeObject<CArrayO<StringID>>(playedDiamondCupSequence, name: "playedDiamondCupSequence");
				costumes = s.SerializeObject<CArrayO<StringID>>(costumes, name: "costumes");
				playedChallenge = s.SerializeObject<CListP<uint>>(playedChallenge, name: "playedChallenge");
				playedInvasion = s.SerializeObject<CArrayO<StringID>>(playedInvasion, name: "playedInvasion");
				tvOffOptionEnabledNb = s.Serialize<uint>(tvOffOptionEnabledNb, name: "tvOffOptionEnabledNb");
				tvOffOptionActivatedTime = s.Serialize<uint>(tvOffOptionActivatedTime, name: "tvOffOptionActivatedTime");
				barbaraCostumeUnlockSeen = s.Serialize<bool>(barbaraCostumeUnlockSeen, name: "barbaraCostumeUnlockSeen");
				worldUnlockMessagesSeen = s.SerializeObject<CArrayO<StringID>>(worldUnlockMessagesSeen, name: "worldUnlockMessagesSeen");
				retroWorldUnlockMessageSeen = s.Serialize<bool>(retroWorldUnlockMessageSeen, name: "retroWorldUnlockMessageSeen");
				freedAllTeensiesMessageSeen = s.Serialize<bool>(freedAllTeensiesMessageSeen, name: "freedAllTeensiesMessageSeen");
				MisterDarkCompletionMessageSeen = s.Serialize<bool>(MisterDarkCompletionMessageSeen, name: "MisterDarkCompletionMessageSeen");
				FirstInvasionMessageSeen = s.Serialize<bool>(FirstInvasionMessageSeen, name: "FirstInvasionMessageSeen");
				InvitationTutoSeen = s.Serialize<bool>(InvitationTutoSeen, name: "InvitationTutoSeen");
				MessageSeen8Bit = s.Serialize<bool>(MessageSeen8Bit, name: "MessageSeen8Bit");
				challengeWorldUnlockMessageSeen = s.Serialize<bool>(challengeWorldUnlockMessageSeen, name: "challengeWorldUnlockMessageSeen");
				doorUnlockMessageSeen = s.SerializeObject<CArrayO<StringID>>(doorUnlockMessageSeen, name: "doorUnlockMessageSeen");
				doorUnlockDRCMessageRequired = s.SerializeObject<CArrayO<StringID>>(doorUnlockDRCMessageRequired, name: "doorUnlockDRCMessageRequired");
				luckyTicketRewardWorldName = s.SerializeObject<StringID>(luckyTicketRewardWorldName, name: "luckyTicketRewardWorldName");
				isUGCMiiverseWarningSet = s.Serialize<bool>(isUGCMiiverseWarningSet, name: "isUGCMiiverseWarningSet");
				reward39Failed = s.Serialize<int>(reward39Failed, name: "reward39Failed");
				unlockPrivilegesData = s.Serialize<string>(unlockPrivilegesData, name: "unlockPrivilegesData");
				isDemoRewardChecked = s.Serialize<int>(isDemoRewardChecked, name: "isDemoRewardChecked");
				prisonerDataDummy = s.SerializeObject<PrisonerData>(prisonerDataDummy, name: "prisonerDataDummy");
				persistentGameDataLevelDummy = s.SerializeObject<RO2_PersistentGameData_Level>(persistentGameDataLevelDummy, name: "persistentGameDataLevelDummy");
				messageDummy = s.SerializeObject<Message>(messageDummy, name: "messageDummy");
				unlockedDoorDummy = s.SerializeObject<RO2_PersistentGameData_Universe.UnlockedDoor>(unlockedDoorDummy, name: "unlockedDoorDummy");
				bubbleDreamerDataDummy = s.SerializeObject<RO2_PersistentGameData_BubbleDreamerData>(bubbleDreamerDataDummy, name: "bubbleDreamerDataDummy");
				dummmyNodeData = s.SerializeObject<RO2_PersistentGameData_Universe.NodeDataStruct>(dummmyNodeData, name: "dummmyNodeData");
			} else {
				score = s.SerializeObject<RO2_PersistentGameData_Score>(score, name: "score");
				iap = s.SerializeObject<RO2_PersistentGameData_IAP>(iap, name: "iap");
				bubbleDreamer = s.SerializeObject<RO2_PersistentGameData_BubbleDreamerData>(bubbleDreamer, name: "bubbleDreamer");
				unlockedPets = s.SerializeObject<CArrayP<int>>(unlockedPets, name: "unlockedPets");
				petsDailyReward = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.petRewardData>>(petsDailyReward, name: "petsDailyReward");
				unlockedCupsForPets = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.st_petCups>>(unlockedCupsForPets, name: "unlockedCupsForPets");
				givenPetCount = s.Serialize<uint>(givenPetCount, name: "givenPetCount");
				newPetsUnlocked = s.Serialize<bool>(newPetsUnlocked, name: "newPetsUnlocked");
				firstPetShown = s.Serialize<bool>(firstPetShown, name: "firstPetShown");
				hasShownMessageAllPet = s.Serialize<bool>(hasShownMessageAllPet, name: "hasShownMessageAllPet");
				messagesTotalCount = s.Serialize<uint>(messagesTotalCount, name: "messagesTotalCount");
				messages_onlineDate = s.SerializeObject<online.DateTime>(messages_onlineDate, name: "messages_onlineDate");
				messages_localDate = s.SerializeObject<online.DateTime>(messages_localDate, name: "messages_localDate");
				messages_readDrcCount = s.Serialize<uint>(messages_readDrcCount, name: "messages_readDrcCount");
				messages_interactDrcCount = s.Serialize<uint>(messages_interactDrcCount, name: "messages_interactDrcCount");
				messages_lastSeenMessageHandle = s.Serialize<uint>(messages_lastSeenMessageHandle, name: "messages_lastSeenMessageHandle");
				messages_tutoCount = s.Serialize<uint>(messages_tutoCount, name: "messages_tutoCount");
				messages_drcCountSinceLastInteract = s.Serialize<uint>(messages_drcCountSinceLastInteract, name: "messages_drcCountSinceLastInteract");
				playerCard_displayedCount = s.Serialize<uint>(playerCard_displayedCount, name: "playerCard_displayedCount");
				playerCard_tutoSeen = s.Serialize<bool>(playerCard_tutoSeen, name: "playerCard_tutoSeen");
				gameCompleted = s.Serialize<bool>(gameCompleted, name: "gameCompleted");
				timeToCompleteGameInSec = s.Serialize<uint>(timeToCompleteGameInSec, name: "timeToCompleteGameInSec");
				timeSpendInGameInSec = s.Serialize<uint>(timeSpendInGameInSec, name: "timeSpendInGameInSec");
				teensiesBonusCounter = s.Serialize<uint>(teensiesBonusCounter, name: "teensiesBonusCounter");
				luckyTicketsCounter = s.Serialize<uint>(luckyTicketsCounter, name: "luckyTicketsCounter");
				luckyTicketLevelCount = s.Serialize<uint>(luckyTicketLevelCount, name: "luckyTicketLevelCount");
				retroMapUnlockedCounter = s.Serialize<uint>(retroMapUnlockedCounter, name: "retroMapUnlockedCounter");
				mrDarkUnlockCount = s.SerializeObject<CArrayO<StringID>>(mrDarkUnlockCount, name: "mrDarkUnlockCount");
				catchEmAllIndex = s.Serialize<uint>(catchEmAllIndex, name: "catchEmAllIndex");
				newCostumes = s.SerializeObject<CArrayO<StringID>>(newCostumes, name: "newCostumes");
				costumeUnlockSeen = s.SerializeObject<CArrayO<StringID>>(costumeUnlockSeen, name: "costumeUnlockSeen");
				retroUnlocks = s.SerializeObject<CArrayO<StringID>>(retroUnlocks, name: "retroUnlocks");
				newUnlockedDoor = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.UnlockedDoor>>(newUnlockedDoor, name: "newUnlockedDoor");
				luckyTicketRewardList = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RO2_LuckyTicketReward>>(luckyTicketRewardList, name: "luckyTicketRewardList");
				nodeData = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.NodeDataStruct>>(nodeData, name: "nodeData");
				luckyTicketsRewardGivenCounter = s.Serialize<uint>(luckyTicketsRewardGivenCounter, name: "luckyTicketsRewardGivenCounter");
				consecutiveLuckyTicketCount = s.Serialize<uint>(consecutiveLuckyTicketCount, name: "consecutiveLuckyTicketCount");
				ticketReminderMessageCount = s.Serialize<uint>(ticketReminderMessageCount, name: "ticketReminderMessageCount");
				displayGhosts = s.Serialize<uint>(displayGhosts, name: "displayGhosts");
				uplayDoneAction0 = s.Serialize<bool>(uplayDoneAction0, name: "uplayDoneAction0");
				uplayDoneAction1 = s.Serialize<bool>(uplayDoneAction1, name: "uplayDoneAction1");
				uplayDoneAction2 = s.Serialize<bool>(uplayDoneAction2, name: "uplayDoneAction2");
				uplayDoneAction3 = s.Serialize<bool>(uplayDoneAction3, name: "uplayDoneAction3");
				uplayDoneAction4 = s.Serialize<bool>(uplayDoneAction4, name: "uplayDoneAction4");
				uplayDoneReward0 = s.Serialize<bool>(uplayDoneReward0, name: "uplayDoneReward0");
				uplayDoneReward1 = s.Serialize<bool>(uplayDoneReward1, name: "uplayDoneReward1");
				uplayDoneReward2 = s.Serialize<bool>(uplayDoneReward2, name: "uplayDoneReward2");
				uplayDoneReward3 = s.Serialize<bool>(uplayDoneReward3, name: "uplayDoneReward3");
				uplayDoneReward3 = s.Serialize<bool>(uplayDoneReward3, name: "uplayDoneReward3");
				playedDiamondCupSequence = s.SerializeObject<CArrayO<StringID>>(playedDiamondCupSequence, name: "playedDiamondCupSequence");
				costumes = s.SerializeObject<CArrayO<StringID>>(costumes, name: "costumes");
				playedChallenge = s.SerializeObject<CListP<uint>>(playedChallenge, name: "playedChallenge");
				playedInvasion = s.SerializeObject<CArrayO<StringID>>(playedInvasion, name: "playedInvasion");
				tvOffOptionEnabledNb = s.Serialize<uint>(tvOffOptionEnabledNb, name: "tvOffOptionEnabledNb");
				tvOffOptionActivatedTime = s.Serialize<uint>(tvOffOptionActivatedTime, name: "tvOffOptionActivatedTime");
				barbaraCostumeUnlockSeen = s.Serialize<bool>(barbaraCostumeUnlockSeen, name: "barbaraCostumeUnlockSeen");
				worldUnlockMessagesSeen = s.SerializeObject<CArrayO<StringID>>(worldUnlockMessagesSeen, name: "worldUnlockMessagesSeen");
				retroWorldUnlockMessageSeen = s.Serialize<bool>(retroWorldUnlockMessageSeen, name: "retroWorldUnlockMessageSeen");
				freedAllTeensiesMessageSeen = s.Serialize<bool>(freedAllTeensiesMessageSeen, name: "freedAllTeensiesMessageSeen");
				MisterDarkCompletionMessageSeen = s.Serialize<bool>(MisterDarkCompletionMessageSeen, name: "MisterDarkCompletionMessageSeen");
				FirstInvasionMessageSeen = s.Serialize<bool>(FirstInvasionMessageSeen, name: "FirstInvasionMessageSeen");
				InvitationTutoSeen = s.Serialize<bool>(InvitationTutoSeen, name: "InvitationTutoSeen");
				MessageSeen8Bit = s.Serialize<bool>(MessageSeen8Bit, name: "MessageSeen8Bit");
				challengeWorldUnlockMessageSeen = s.Serialize<bool>(challengeWorldUnlockMessageSeen, name: "challengeWorldUnlockMessageSeen");
				doorUnlockMessageSeen = s.SerializeObject<CArrayO<StringID>>(doorUnlockMessageSeen, name: "doorUnlockMessageSeen");
				doorUnlockDRCMessageRequired = s.SerializeObject<CArrayO<StringID>>(doorUnlockDRCMessageRequired, name: "doorUnlockDRCMessageRequired");
				luckyTicketRewardWorldName = s.SerializeObject<StringID>(luckyTicketRewardWorldName, name: "luckyTicketRewardWorldName");
				isUGCMiiverseWarningSet = s.Serialize<bool>(isUGCMiiverseWarningSet, name: "isUGCMiiverseWarningSet");
				unlockPrivilegesData = s.Serialize<string>(unlockPrivilegesData, name: "unlockPrivilegesData");
				prisonerDataDummy = s.SerializeObject<PrisonerData>(prisonerDataDummy, name: "prisonerDataDummy");
				persistentGameDataLevelDummy = s.SerializeObject<RO2_PersistentGameData_Level>(persistentGameDataLevelDummy, name: "persistentGameDataLevelDummy");
				unlockedDoorDummy = s.SerializeObject<RO2_PersistentGameData_Universe.UnlockedDoor>(unlockedDoorDummy, name: "unlockedDoorDummy");
				bubbleDreamerDataDummy = s.SerializeObject<RO2_PersistentGameData_BubbleDreamerData>(bubbleDreamerDataDummy, name: "bubbleDreamerDataDummy");
				dummmyNodeData = s.SerializeObject<RO2_PersistentGameData_Universe.NodeDataStruct>(dummmyNodeData, name: "dummmyNodeData");
				adventureNodeDataList = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RLC_AdventureNodeData>>(adventureNodeDataList, name: "adventureNodeDataList");
				introCompleted = s.Serialize<bool>(introCompleted, name: "introCompleted");
				introCreatureHatched = s.Serialize<bool>(introCreatureHatched, name: "introCreatureHatched");
				devTeam = s.Serialize<bool>(devTeam, name: "devTeam");
				onboardingCompleted = s.Serialize<bool>(onboardingCompleted, name: "onboardingCompleted");
				gameStartDateTime = s.SerializeObject<online.DateTime>(gameStartDateTime, name: "gameStartDateTime");
				globalSessionNb = s.Serialize<uint>(globalSessionNb, name: "globalSessionNb");
				isNotificationConfirmationDialogShown = s.Serialize<bool>(isNotificationConfirmationDialogShown, name: "isNotificationConfirmationDialogShown");
				foodAcquiredNbLtd = s.Serialize<uint>(foodAcquiredNbLtd, name: "foodAcquiredNbLtd");
				foodRefillStartDate = s.SerializeObject<online.DateTime>(foodRefillStartDate, name: "foodRefillStartDate");
				gemsAcquiredNbLtd = s.Serialize<uint>(gemsAcquiredNbLtd, name: "gemsAcquiredNbLtd");
				MglassAcquiredNbLtd = s.Serialize<uint>(MglassAcquiredNbLtd, name: "MglassAcquiredNbLtd");
				MGlassBoughtWithGemsNbLtd = s.Serialize<uint>(MGlassBoughtWithGemsNbLtd, name: "MGlassBoughtWithGemsNbLtd");
				rewardedVideoNbLtd = s.Serialize<uint>(rewardedVideoNbLtd, name: "rewardedVideoNbLtd");
				everyPlaySharedVideoNbLtd = s.Serialize<uint>(everyPlaySharedVideoNbLtd, name: "everyPlaySharedVideoNbLtd");
				gemsUsedNbLtd = s.Serialize<uint>(gemsUsedNbLtd, name: "gemsUsedNbLtd");
				nbMailboxReadLtd = s.Serialize<uint>(nbMailboxReadLtd, name: "nbMailboxReadLtd");
				characterSelectionNb = s.Serialize<uint>(characterSelectionNb, name: "characterSelectionNb");
				adventureSessionNb = s.Serialize<uint>(adventureSessionNb, name: "adventureSessionNb");
				adventureId = s.Serialize<uint>(adventureId, name: "adventureId");
				skipAdventure = s.Serialize<bool>(skipAdventure, name: "skipAdventure");
				adventureStartDate = s.SerializeObject<online.DateTime>(adventureStartDate, name: "adventureStartDate");
				adventureLifeTimeInSec = s.Serialize<ulong>(adventureLifeTimeInSec, name: "adventureLifeTimeInSec");
				adventureDefaultLifeTimeInSec = s.Serialize<ulong>(adventureDefaultLifeTimeInSec, name: "adventureDefaultLifeTimeInSec");
				timeLimitedAdventureTutorialShown = s.Serialize<uint>(timeLimitedAdventureTutorialShown, name: "timeLimitedAdventureTutorialShown");
				timeLimitedAdventureCompleteInTime = s.Serialize<uint>(timeLimitedAdventureCompleteInTime, name: "timeLimitedAdventureCompleteInTime");
				timeLimitedAdventureRewardCredited = s.Serialize<bool>(timeLimitedAdventureRewardCredited, name: "timeLimitedAdventureRewardCredited");
				adventureRenderParamIndex = s.Serialize<uint>(adventureRenderParamIndex, name: "adventureRenderParamIndex");
				adventureNewGameDone = s.Serialize<bool>(adventureNewGameDone, name: "adventureNewGameDone");
				adventureGlobalIndex = s.Serialize<uint>(adventureGlobalIndex, name: "adventureGlobalIndex");
				adventurePath = s.SerializeObject<Path>(adventurePath, name: "adventurePath");
				adventureCharlieFound = s.Serialize<bool>(adventureCharlieFound, name: "adventureCharlieFound");
				totalCharlieFound = s.Serialize<uint>(totalCharlieFound, name: "totalCharlieFound");
				tutorialCharlieFound = s.Serialize<bool>(tutorialCharlieFound, name: "tutorialCharlieFound");
				tutorialCharlieOptionalFound = s.Serialize<bool>(tutorialCharlieOptionalFound, name: "tutorialCharlieOptionalFound");
				tutorialFeedInGoScreenFound = s.Serialize<bool>(tutorialFeedInGoScreenFound, name: "tutorialFeedInGoScreenFound");
				newElixirDialogAlreadySeen = s.Serialize<bool>(newElixirDialogAlreadySeen, name: "newElixirDialogAlreadySeen");
				adventureFinishedAlreadyDisplayed = s.Serialize<bool>(adventureFinishedAlreadyDisplayed, name: "adventureFinishedAlreadyDisplayed");
				adventureCompleteAlreadyDisplayed = s.Serialize<bool>(adventureCompleteAlreadyDisplayed, name: "adventureCompleteAlreadyDisplayed");
				joinDate = s.SerializeObject<online.DateTime>(joinDate, name: "joinDate");
				iapScore = s.Serialize<uint>(iapScore, name: "iapScore");
				originalDeviceId = s.Serialize<string>(originalDeviceId, name: "originalDeviceId");
				spinCount = s.Serialize<uint>(spinCount, name: "spinCount");
				levelTryCount = s.Serialize<uint>(levelTryCount, name: "levelTryCount");
				challengeWheelRewardType = s.Serialize<uint>(challengeWheelRewardType, name: "challengeWheelRewardType");
				challengeWheelMapType = s.Serialize<uint>(challengeWheelMapType, name: "challengeWheelMapType");
				challengeWheelLevelType = s.Serialize<uint>(challengeWheelLevelType, name: "challengeWheelLevelType");
				challengeWheelMapPath = s.SerializeObject<PathRef>(challengeWheelMapPath, name: "challengeWheelMapPath");
				challengeWheelMapResult = s.Serialize<uint>(challengeWheelMapResult, name: "challengeWheelMapResult");
				challengeWheelCompleteTime = s.Serialize<ulong>(challengeWheelCompleteTime, name: "challengeWheelCompleteTime");
				challengeWheelIntroPopupShowTimeInSec = s.Serialize<ulong>(challengeWheelIntroPopupShowTimeInSec, name: "challengeWheelIntroPopupShowTimeInSec");
				needToShowSeasonalEventExclamation = s.Serialize<bool>(needToShowSeasonalEventExclamation, name: "needToShowSeasonalEventExclamation");
				endLessRunnerEventIntroPopupShowTimeInSec = s.Serialize<ulong>(endLessRunnerEventIntroPopupShowTimeInSec, name: "endLessRunnerEventIntroPopupShowTimeInSec");
				m_FacebookBenefitsShownFoeEventID = s.Serialize<uint>(m_FacebookBenefitsShownFoeEventID, name: "m_FacebookBenefitsShownFoeEventID");
				isScratchingFirstLuckyTicket = s.Serialize<bool>(isScratchingFirstLuckyTicket, name: "isScratchingFirstLuckyTicket");
				isScratchingSecondLuckyTicket = s.Serialize<bool>(isScratchingSecondLuckyTicket, name: "isScratchingSecondLuckyTicket");
				tutoLuckyTicketHasBeenConsumed = s.Serialize<bool>(tutoLuckyTicketHasBeenConsumed, name: "tutoLuckyTicketHasBeenConsumed");
				shopAlreadyOpened = s.Serialize<bool>(shopAlreadyOpened, name: "shopAlreadyOpened");
				facebookBenefitsAlreadyProposed = s.Serialize<bool>(facebookBenefitsAlreadyProposed, name: "facebookBenefitsAlreadyProposed");
				facebookBenefitsAlreadyOpened = s.Serialize<bool>(facebookBenefitsAlreadyOpened, name: "facebookBenefitsAlreadyOpened");
				adventureCharlieCountdown = s.Serialize<uint>(adventureCharlieCountdown, name: "adventureCharlieCountdown");
				bonusMapCountDown = s.Serialize<uint>(bonusMapCountDown, name: "bonusMapCountDown");
				challengeMapCountDown = s.Serialize<uint>(challengeMapCountDown, name: "challengeMapCountDown");
				playerCostumeSkin = s.SerializeObject<StringID>(playerCostumeSkin, name: "playerCostumeSkin");
				dailyObjectiveRefreshDate = s.SerializeObject<online.DateTime>(dailyObjectiveRefreshDate, name: "dailyObjectiveRefreshDate");
				lastTokenRefreshDate = s.SerializeObject<online.DateTime>(lastTokenRefreshDate, name: "lastTokenRefreshDate");
				lastEventBundleUIShownTime = s.Serialize<ulong>(lastEventBundleUIShownTime, name: "lastEventBundleUIShownTime");
				amarCreaturesEndDate = s.SerializeObject<online.DateTime>(amarCreaturesEndDate, name: "amarCreaturesEndDate");
				lastOpenedChallengeSeed = s.Serialize<uint>(lastOpenedChallengeSeed, name: "lastOpenedChallengeSeed");
				lastChallengeSeed = s.Serialize<uint>(lastChallengeSeed, name: "lastChallengeSeed");
				dailyChallengeBestScore = s.Serialize<uint>(dailyChallengeBestScore, name: "dailyChallengeBestScore");
				dailyChallengeBestDistance = s.Serialize<uint>(dailyChallengeBestDistance, name: "dailyChallengeBestDistance");
				lastChallengeTombs = s.SerializeObject<CArrayO<Vec3d>>(lastChallengeTombs, name: "lastChallengeTombs");
				lastChallengeTombs = s.SerializeObject<CArrayO<Vec3d>>(lastChallengeTombs, name: "lastChallengeTombs");
				dailyChallengeTicketPiecesState0 = s.Serialize<uint>(dailyChallengeTicketPiecesState0, name: "dailyChallengeTicketPiecesState0");
				dailyChallengeTicketPiecesState1 = s.Serialize<uint>(dailyChallengeTicketPiecesState1, name: "dailyChallengeTicketPiecesState1");
				dailyChallengeTicketPiecesState2 = s.Serialize<uint>(dailyChallengeTicketPiecesState2, name: "dailyChallengeTicketPiecesState2");
				dailyChallengeTicketCollected = s.Serialize<bool>(dailyChallengeTicketCollected, name: "dailyChallengeTicketCollected");
				retryPostDailyChallengeScore = s.Serialize<uint>(retryPostDailyChallengeScore, name: "retryPostDailyChallengeScore");
				missionDataList = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RLC_MissionData>>(missionDataList, name: "missionDataList");
				creatureDataList = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RLC_CreatureData>>(creatureDataList, name: "creatureDataList");
				currentCreatureData = s.SerializeObject<RO2_PersistentGameData_Universe.RLC_CreatureData>(currentCreatureData, name: "currentCreatureData");
				nbHatchedEggsSinceLastNewCreature = s.Serialize<uint>(nbHatchedEggsSinceLastNewCreature, name: "nbHatchedEggsSinceLastNewCreature");
				awayLongEnoughToHatchNewCreature = s.Serialize<bool>(awayLongEnoughToHatchNewCreature, name: "awayLongEnoughToHatchNewCreature");
				hatchFailCounter_NewCreature = s.Serialize<uint>(hatchFailCounter_NewCreature, name: "hatchFailCounter_NewCreature");
				hatchFailCounter_Queen = s.Serialize<uint>(hatchFailCounter_Queen, name: "hatchFailCounter_Queen");
				adventureEggData = s.SerializeObject<RO2_PersistentGameData_Universe.RLC_EggData>(adventureEggData, name: "adventureEggData");
				mb_needRequestStartNextAdventureParam = s.Serialize<bool>(mb_needRequestStartNextAdventureParam, name: "mb_needRequestStartNextAdventureParam");
				incubatorEggData = s.SerializeObject<RO2_PersistentGameData_Universe.RLC_EggData>(incubatorEggData, name: "incubatorEggData");
				incubatorElixirUtilisations = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RLC_ElixirUtilisation>>(incubatorElixirUtilisations, name: "incubatorElixirUtilisations");
				incubatorEggAdventureSequence = s.Serialize<uint>(incubatorEggAdventureSequence, name: "incubatorEggAdventureSequence");
				eggHatchingComplete = s.Serialize<bool>(eggHatchingComplete, name: "eggHatchingComplete");
				eggFirstTapComplete = s.Serialize<bool>(eggFirstTapComplete, name: "eggFirstTapComplete");
				lastEggHatchingTimeSkipped = s.Serialize<bool>(lastEggHatchingTimeSkipped, name: "lastEggHatchingTimeSkipped");
				incubatorDateTimeEggHatchingComplete = s.SerializeObject<online.DateTime>(incubatorDateTimeEggHatchingComplete, name: "incubatorDateTimeEggHatchingComplete");
				lastSavedGameDateTime = s.SerializeObject<online.DateTime>(lastSavedGameDateTime, name: "lastSavedGameDateTime");
				incubationDuration = s.Serialize<float>(incubationDuration, name: "incubationDuration");
				StartValuesSet = s.Serialize<bool>(StartValuesSet, name: "StartValuesSet");
				menuOptionSave = s.SerializeObject<RO2_PersistentGameData_Universe.RLC_MenuOptionSave>(menuOptionSave, name: "menuOptionSave");
				languageArabicPopupDisplayed = s.Serialize<bool>(languageArabicPopupDisplayed, name: "languageArabicPopupDisplayed");
				CostumePlayTime = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RLC_CostumePlayTime>>(CostumePlayTime, name: "CostumePlayTime");
				globalPlayTime = s.Serialize<float>(globalPlayTime, name: "globalPlayTime");
				adventurePlayTime = s.Serialize<float>(adventurePlayTime, name: "adventurePlayTime");
				adventureStep = s.Serialize<uint>(adventureStep, name: "adventureStep");
				adventureStepPlayTime = s.Serialize<float>(adventureStepPlayTime, name: "adventureStepPlayTime");
				adventureBoatState = s.Serialize<Enum_adventureBoatState>(adventureBoatState, name: "adventureBoatState");
				TreePlayTime = s.Serialize<float>(TreePlayTime, name: "TreePlayTime");
				BeatBoxPlayTime = s.Serialize<float>(BeatBoxPlayTime, name: "BeatBoxPlayTime");
				shopPlayTime = s.Serialize<float>(shopPlayTime, name: "shopPlayTime");
				shopFoodPlayTime = s.Serialize<float>(shopFoodPlayTime, name: "shopFoodPlayTime");
				shopElixirPlayTime = s.Serialize<float>(shopElixirPlayTime, name: "shopElixirPlayTime");
				shopCostumePlayTime = s.Serialize<float>(shopCostumePlayTime, name: "shopCostumePlayTime");
				shopLuckyTicketPlayTime = s.Serialize<float>(shopLuckyTicketPlayTime, name: "shopLuckyTicketPlayTime");
				shopPrimaryPlayTime = s.Serialize<float>(shopPrimaryPlayTime, name: "shopPrimaryPlayTime");
				nbPrimaryStoreVisits = s.Serialize<uint>(nbPrimaryStoreVisits, name: "nbPrimaryStoreVisits");
				nbLuckyTicketsScratchedLtd = s.Serialize<uint>(nbLuckyTicketsScratchedLtd, name: "nbLuckyTicketsScratchedLtd");
				nbGoldenTicketsScratchedLtd = s.Serialize<uint>(nbGoldenTicketsScratchedLtd, name: "nbGoldenTicketsScratchedLtd");
				nbClicksOnBuyBeatboxSlots = s.Serialize<uint>(nbClicksOnBuyBeatboxSlots, name: "nbClicksOnBuyBeatboxSlots");
				BeatBoxUsedCount = s.Serialize<uint>(BeatBoxUsedCount, name: "BeatBoxUsedCount");
				BeatBoxNoteCount = s.Serialize<uint>(BeatBoxNoteCount, name: "BeatBoxNoteCount");
				eggSequence = s.Serialize<uint>(eggSequence, name: "eggSequence");
				adventureEggSequence = s.Serialize<uint>(adventureEggSequence, name: "adventureEggSequence");
				runId = s.Serialize<uint>(runId, name: "runId");
				shopVisitNb = s.Serialize<uint>(shopVisitNb, name: "shopVisitNb");
				hatchingCountdownRemainingSkipped = s.Serialize<float>(hatchingCountdownRemainingSkipped, name: "hatchingCountdownRemainingSkipped");
				TrackingEggAlreadyReached = s.Serialize<bool>(TrackingEggAlreadyReached, name: "TrackingEggAlreadyReached");
				TrackingEggAlreadyPicked = s.Serialize<bool>(TrackingEggAlreadyPicked, name: "TrackingEggAlreadyPicked");
				TrackingCptFlurry = s.Serialize<uint>(TrackingCptFlurry, name: "TrackingCptFlurry");
				TrackingCptUbiServices = s.Serialize<uint>(TrackingCptUbiServices, name: "TrackingCptUbiServices");
				currentDuplicateStars = s.Serialize<uint>(currentDuplicateStars, name: "currentDuplicateStars");
				lastShownDuplicateStars = s.Serialize<uint>(lastShownDuplicateStars, name: "lastShownDuplicateStars");
				totalSpentDuplicateStars = s.Serialize<uint>(totalSpentDuplicateStars, name: "totalSpentDuplicateStars");
				lastRefusedDuplicateChoice = s.Serialize<uint>(lastRefusedDuplicateChoice, name: "lastRefusedDuplicateChoice");
				nbDuplicateCreaturesLtd = s.Serialize<uint>(nbDuplicateCreaturesLtd, name: "nbDuplicateCreaturesLtd");
				nbLuckyTicketsNoDuplicate = s.Serialize<uint>(nbLuckyTicketsNoDuplicate, name: "nbLuckyTicketsNoDuplicate");
				nbGoldenTicketsNoDuplicate = s.Serialize<uint>(nbGoldenTicketsNoDuplicate, name: "nbGoldenTicketsNoDuplicate");
				duplicateChoiceClaimIndex = s.Serialize<uint>(duplicateChoiceClaimIndex, name: "duplicateChoiceClaimIndex");
				duplicateChoiceWaitIndex = s.Serialize<uint>(duplicateChoiceWaitIndex, name: "duplicateChoiceWaitIndex");
				stoppedDuringDuplicateChoice = s.Serialize<bool>(stoppedDuringDuplicateChoice, name: "stoppedDuringDuplicateChoice");
				newDailyObjectivesAlreadyPopped = s.Serialize<bool>(newDailyObjectivesAlreadyPopped, name: "newDailyObjectivesAlreadyPopped");
				dailyObjectiveShuffleAvailable = s.Serialize<bool>(dailyObjectiveShuffleAvailable, name: "dailyObjectiveShuffleAvailable");
				dailyObjectiveTicketAvailable = s.Serialize<bool>(dailyObjectiveTicketAvailable, name: "dailyObjectiveTicketAvailable");
				dailyObjective0AlreadyShown = s.Serialize<bool>(dailyObjective0AlreadyShown, name: "dailyObjective0AlreadyShown");
				dailyObjective1AlreadyShown = s.Serialize<bool>(dailyObjective1AlreadyShown, name: "dailyObjective1AlreadyShown");
				dailyObjective2AlreadyShown = s.Serialize<bool>(dailyObjective2AlreadyShown, name: "dailyObjective2AlreadyShown");
				dailyObjectiveTicketPart0Reached = s.Serialize<bool>(dailyObjectiveTicketPart0Reached, name: "dailyObjectiveTicketPart0Reached");
				dailyObjectiveTicketPart1Reached = s.Serialize<bool>(dailyObjectiveTicketPart1Reached, name: "dailyObjectiveTicketPart1Reached");
				dailyObjectiveTicketPart2Reached = s.Serialize<bool>(dailyObjectiveTicketPart2Reached, name: "dailyObjectiveTicketPart2Reached");
				nbDailyObjectiveShuffle = s.Serialize<uint>(nbDailyObjectiveShuffle, name: "nbDailyObjectiveShuffle");
				saveRandomBackgroundId = s.Serialize<uint>(saveRandomBackgroundId, name: "saveRandomBackgroundId");
				firstShopOpeningDate = s.SerializeObject<online.DateTime>(firstShopOpeningDate, name: "firstShopOpeningDate");
				alreadyBoughtStarterPacks = s.SerializeObject<CListP<uint>>(alreadyBoughtStarterPacks, name: "alreadyBoughtStarterPacks");
				alreadyBoughStoreBundles = s.SerializeObject<CListP<uint>>(alreadyBoughStoreBundles, name: "alreadyBoughStoreBundles");
				alreadyBoughtDynamicPacks = s.SerializeObject<CListP<string>>(alreadyBoughtDynamicPacks, name: "alreadyBoughtDynamicPacks");
				unlockedCostumesNotSeenYet = s.SerializeObject<CListO<StringID>>(unlockedCostumesNotSeenYet, name: "unlockedCostumesNotSeenYet");
				alreadySeenCostumeTrades = s.SerializeObject<CListO<RLC_ShopCostumeVersion>>(alreadySeenCostumeTrades, name: "alreadySeenCostumeTrades");
				gppSessionId = s.Serialize<uint>(gppSessionId, name: "gppSessionId");
				lastSessionStartTimestamp = s.SerializeObject<online.DateTime>(lastSessionStartTimestamp, name: "lastSessionStartTimestamp");
				nbSessionsBeforeFacebookProposal = s.Serialize<uint>(nbSessionsBeforeFacebookProposal, name: "nbSessionsBeforeFacebookProposal");
				nbSessionsWithMailboxWaiting = s.Serialize<int>(nbSessionsWithMailboxWaiting, name: "nbSessionsWithMailboxWaiting");
				lastStarterPackPopupTimestamp = s.SerializeObject<online.DateTime>(lastStarterPackPopupTimestamp, name: "lastStarterPackPopupTimestamp");
				automaticPopupSaves = s.SerializeObject<CMap<RLC_StoreBundle.Type, RLC_AutomaticPopupSave>>(automaticPopupSaves, name: "automaticPopupSaves");
				specialPackSaves = s.SerializeObject<CMap<RLC_StoreBundle.Type, RLC_SpecialPackSave>>(specialPackSaves, name: "specialPackSaves");
				lastSentGiftsTimestamps = s.SerializeObject<CMap<StringID, online.DateTime>>(lastSentGiftsTimestamps, name: "lastSentGiftsTimestamps");
				lastAskForGiftsTimestamps = s.SerializeObject<CMap<StringID, online.DateTime>>(lastAskForGiftsTimestamps, name: "lastAskForGiftsTimestamps");
				inviteFriendsRewardWaiting = s.Serialize<bool>(inviteFriendsRewardWaiting, name: "inviteFriendsRewardWaiting");
				showInviteFriendsExclamation = s.Serialize<bool>(showInviteFriendsExclamation, name: "showInviteFriendsExclamation");
				creatureDoesntNeedFoodDialogShown = s.Serialize<bool>(creatureDoesntNeedFoodDialogShown, name: "creatureDoesntNeedFoodDialogShown");
				radarExhaustDialogShown = s.Serialize<bool>(radarExhaustDialogShown, name: "radarExhaustDialogShown");
				shieldActivateDialogShown = s.Serialize<bool>(shieldActivateDialogShown, name: "shieldActivateDialogShown");
				magnetActivateDialogShown = s.Serialize<bool>(magnetActivateDialogShown, name: "magnetActivateDialogShown");
				beatboxSaveConfirmation = s.Serialize<bool>(beatboxSaveConfirmation, name: "beatboxSaveConfirmation");
				beatboxTrashConfirmation = s.Serialize<bool>(beatboxTrashConfirmation, name: "beatboxTrashConfirmation");
				forcedGreeceFirstLevel = s.Serialize<bool>(forcedGreeceFirstLevel, name: "forcedGreeceFirstLevel");
				lastAdventureEggHatched = s.SerializeObject<StringID>(lastAdventureEggHatched, name: "lastAdventureEggHatched");
				lastNewCreatureId = s.SerializeObject<StringID>(lastNewCreatureId, name: "lastNewCreatureId");
				tutoLeaderboardDone = s.Serialize<bool>(tutoLeaderboardDone, name: "tutoLeaderboardDone");
				tutoMapButtonAlreadyDisplayed = s.Serialize<bool>(tutoMapButtonAlreadyDisplayed, name: "tutoMapButtonAlreadyDisplayed");
				ritualBeforeTutoLeaderboardDone = s.Serialize<bool>(ritualBeforeTutoLeaderboardDone, name: "ritualBeforeTutoLeaderboardDone");
				betweenTwoAdventures = s.Serialize<bool>(betweenTwoAdventures, name: "betweenTwoAdventures");
				legalPopupAlreadySeen = s.Serialize<bool>(legalPopupAlreadySeen, name: "legalPopupAlreadySeen");
				luckyTicketShopAlreadyEntered = s.Serialize<bool>(luckyTicketShopAlreadyEntered, name: "luckyTicketShopAlreadyEntered");
				elixirShopAlreadyEntered = s.Serialize<bool>(elixirShopAlreadyEntered, name: "elixirShopAlreadyEntered");
				beatboxShopAlreadyEntered = s.Serialize<bool>(beatboxShopAlreadyEntered, name: "beatboxShopAlreadyEntered");
				lastAdventureRegion = s.Serialize<RLC_GraphicalFamily>(lastAdventureRegion, name: "lastAdventureRegion");
				nextRegion0 = s.Serialize<RLC_GraphicalFamily>(nextRegion0, name: "nextRegion0");
				nextRegion1 = s.Serialize<RLC_GraphicalFamily>(nextRegion1, name: "nextRegion1");
				nextRegion2 = s.Serialize<RLC_GraphicalFamily>(nextRegion2, name: "nextRegion2");
				nextRegion3 = s.Serialize<RLC_GraphicalFamily>(nextRegion3, name: "nextRegion3");
				nextRegion4 = s.Serialize<RLC_GraphicalFamily>(nextRegion4, name: "nextRegion4");
				forcedNextRegion = s.Serialize<RLC_GraphicalFamily>(forcedNextRegion, name: "forcedNextRegion");
				nextRegionsChoiceNb = s.Serialize<uint>(nextRegionsChoiceNb, name: "nextRegionsChoiceNb");
				nextRegionRandomDone = s.Serialize<bool>(nextRegionRandomDone, name: "nextRegionRandomDone");
				revealedRegions = s.SerializeObject<CListP<RLC_GraphicalFamily>>(revealedRegions, name: "revealedRegions");
				nextRegionTravelMarks = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RLC_NextRegionTravelMark>>(nextRegionTravelMarks, name: "nextRegionTravelMarks");
				nextRegionEggSelectionData = s.SerializeObject<CListO<RO2_PersistentGameData_Universe.RLC_NextRegionEggSelectionData>>(nextRegionEggSelectionData, name: "nextRegionEggSelectionData");
				nextRegionsCreatureID0 = s.SerializeObject<StringID>(nextRegionsCreatureID0, name: "nextRegionsCreatureID0");
				nextRegionsCreatureID1 = s.SerializeObject<StringID>(nextRegionsCreatureID1, name: "nextRegionsCreatureID1");
				nextRegionsCreatureID2 = s.SerializeObject<StringID>(nextRegionsCreatureID2, name: "nextRegionsCreatureID2");
				nextRegionsCreatureID3 = s.SerializeObject<StringID>(nextRegionsCreatureID3, name: "nextRegionsCreatureID3");
				nextRegionsCreatureID4 = s.SerializeObject<StringID>(nextRegionsCreatureID4, name: "nextRegionsCreatureID4");
				forcedIncubatorCreatureID_BeforeElixirs = s.SerializeObject<StringID>(forcedIncubatorCreatureID_BeforeElixirs, name: "forcedIncubatorCreatureID_BeforeElixirs");
				forcedNextRegionCreatureID = s.SerializeObject<StringID>(forcedNextRegionCreatureID, name: "forcedNextRegionCreatureID");
				forcedIncubatorCreatureID = s.SerializeObject<StringID>(forcedIncubatorCreatureID, name: "forcedIncubatorCreatureID");
				IncubatorCreatureRegion = s.Serialize<Enum_IncubatorCreatureRegion>(IncubatorCreatureRegion, name: "IncubatorCreatureRegion");
				nextRegionMagnifyingGlassUsed = s.Serialize<bool>(nextRegionMagnifyingGlassUsed, name: "nextRegionMagnifyingGlassUsed");
				MagnifyingGlassUsedLtd = s.Serialize<uint>(MagnifyingGlassUsedLtd, name: "MagnifyingGlassUsedLtd");
				adventureEggRarityRevealed = s.Serialize<bool>(adventureEggRarityRevealed, name: "adventureEggRarityRevealed");
				treeSeed = s.Serialize<uint>(treeSeed, name: "treeSeed");
				adventureSeed = s.Serialize<uint>(adventureSeed, name: "adventureSeed");
				treeRewardFamilyComplete = s.SerializeObject<CListO<StringID>>(treeRewardFamilyComplete, name: "treeRewardFamilyComplete");
				RewardDojoRegionUnlocked = s.Serialize<bool>(RewardDojoRegionUnlocked, name: "RewardDojoRegionUnlocked");
				saveBranchId = s.Serialize<uint>(saveBranchId, name: "saveBranchId");
				fbToken = s.Serialize<string>(fbToken, name: "fbToken");
				completeAllCreatureValue = s.Serialize<uint>(completeAllCreatureValue, name: "completeAllCreatureValue");
				EndGamePlayersInformedAboutNewFamilies = s.Serialize<bool>(EndGamePlayersInformedAboutNewFamilies, name: "EndGamePlayersInformedAboutNewFamilies");
				currentTutorialStepString = s.Serialize<string>(currentTutorialStepString, name: "currentTutorialStepString");
				currentBeatboxTutoStepString = s.Serialize<string>(currentBeatboxTutoStepString, name: "currentBeatboxTutoStepString");
				IncubatorElixirUtilisationsCountLtd0 = s.Serialize<uint>(IncubatorElixirUtilisationsCountLtd0, name: "IncubatorElixirUtilisationsCountLtd0");
				IncubatorElixirUtilisationsCountLtd1 = s.Serialize<uint>(IncubatorElixirUtilisationsCountLtd1, name: "IncubatorElixirUtilisationsCountLtd1");
				IncubatorElixirUtilisationsCountLtd2 = s.Serialize<uint>(IncubatorElixirUtilisationsCountLtd2, name: "IncubatorElixirUtilisationsCountLtd2");
				IncubatorElixirUtilisationsCountLtd3 = s.Serialize<uint>(IncubatorElixirUtilisationsCountLtd3, name: "IncubatorElixirUtilisationsCountLtd3");
				IncubatorElixirUtilisationsCountLtd4 = s.Serialize<uint>(IncubatorElixirUtilisationsCountLtd4, name: "IncubatorElixirUtilisationsCountLtd4");
				IncubatorElixirUtilisationsCountLtd5 = s.Serialize<uint>(IncubatorElixirUtilisationsCountLtd5, name: "IncubatorElixirUtilisationsCountLtd5");
				hatchingRitualInProgressCreatureId = s.SerializeObject<StringID>(hatchingRitualInProgressCreatureId, name: "hatchingRitualInProgressCreatureId");
				hatchingRitualInProgressAcquisitionSource = s.Serialize<RLC_CreatureAcquisition>(hatchingRitualInProgressAcquisitionSource, name: "hatchingRitualInProgressAcquisitionSource");
				hatchingRitualInProgressEggData = s.SerializeObject<RO2_PersistentGameData_Universe.RLC_EggData>(hatchingRitualInProgressEggData, name: "hatchingRitualInProgressEggData");
				optionalData = s.SerializeObject<CMap<StringID, string>>(optionalData, name: "optionalData");
				additionalDataBufferInt0 = s.Serialize<uint>(additionalDataBufferInt0, name: "additionalDataBufferInt0");
				additionalDataBufferInt1 = s.Serialize<uint>(additionalDataBufferInt1, name: "additionalDataBufferInt1");
				additionalDataBufferInt2 = s.Serialize<uint>(additionalDataBufferInt2, name: "additionalDataBufferInt2");
				additionalDataBufferInt3 = s.Serialize<uint>(additionalDataBufferInt3, name: "additionalDataBufferInt3");
				additionalDataBufferInt4 = s.Serialize<uint>(additionalDataBufferInt4, name: "additionalDataBufferInt4");
				additionalDataBufferInt5 = s.Serialize<uint>(additionalDataBufferInt5, name: "additionalDataBufferInt5");
				additionalDataBufferInt6 = s.Serialize<uint>(additionalDataBufferInt6, name: "additionalDataBufferInt6");
				additionalDataBufferInt7 = s.Serialize<uint>(additionalDataBufferInt7, name: "additionalDataBufferInt7");
				additionalDataBufferInt8 = s.Serialize<uint>(additionalDataBufferInt8, name: "additionalDataBufferInt8");
				additionalDataBufferInt9 = s.Serialize<uint>(additionalDataBufferInt9, name: "additionalDataBufferInt9");
				additionalDataBufferBool0 = s.Serialize<bool>(additionalDataBufferBool0, name: "additionalDataBufferBool0");
				additionalDataBufferBool1 = s.Serialize<bool>(additionalDataBufferBool1, name: "additionalDataBufferBool1");
				additionalDataBufferBool2 = s.Serialize<bool>(additionalDataBufferBool2, name: "additionalDataBufferBool2");
				additionalDataBufferBool3 = s.Serialize<bool>(additionalDataBufferBool3, name: "additionalDataBufferBool3");
				additionalDataBufferBool4 = s.Serialize<bool>(additionalDataBufferBool4, name: "additionalDataBufferBool4");
				additionalDataBufferBool5 = s.Serialize<bool>(additionalDataBufferBool5, name: "additionalDataBufferBool5");
				additionalDataBufferBool6 = s.Serialize<bool>(additionalDataBufferBool6, name: "additionalDataBufferBool6");
				additionalDataBufferBool7 = s.Serialize<bool>(additionalDataBufferBool7, name: "additionalDataBufferBool7");
				additionalDataBufferBool8 = s.Serialize<bool>(additionalDataBufferBool8, name: "additionalDataBufferBool8");
				additionalDataBufferBool9 = s.Serialize<bool>(additionalDataBufferBool9, name: "additionalDataBufferBool9");
				additionalDataBufferFloat0 = s.Serialize<float>(additionalDataBufferFloat0, name: "additionalDataBufferFloat0");
				additionalDataBufferFloat1 = s.Serialize<float>(additionalDataBufferFloat1, name: "additionalDataBufferFloat1");
				additionalDataBufferFloat2 = s.Serialize<float>(additionalDataBufferFloat2, name: "additionalDataBufferFloat2");
				additionalDataBufferFloat3 = s.Serialize<float>(additionalDataBufferFloat3, name: "additionalDataBufferFloat3");
				additionalDataBufferFloat4 = s.Serialize<float>(additionalDataBufferFloat4, name: "additionalDataBufferFloat4");
				additionalDataBufferFloat5 = s.Serialize<float>(additionalDataBufferFloat5, name: "additionalDataBufferFloat5");
				additionalDataBufferFloat6 = s.Serialize<float>(additionalDataBufferFloat6, name: "additionalDataBufferFloat6");
				additionalDataBufferFloat7 = s.Serialize<float>(additionalDataBufferFloat7, name: "additionalDataBufferFloat7");
				additionalDataBufferFloat8 = s.Serialize<float>(additionalDataBufferFloat8, name: "additionalDataBufferFloat8");
				additionalDataBufferFloat9 = s.Serialize<float>(additionalDataBufferFloat9, name: "additionalDataBufferFloat9");
				LastAdsSeenDateTime = s.SerializeObject<online.DateTime>(LastAdsSeenDateTime, name: "LastAdsSeenDateTime");
				LastContextualAdsSeenDateTime = s.SerializeObject<online.DateTime>(LastContextualAdsSeenDateTime, name: "LastContextualAdsSeenDateTime");
				MGlassAdsAdventureSequence = s.Serialize<uint>(MGlassAdsAdventureSequence, name: "MGlassAdsAdventureSequence");
				ShowFreeElixirAd = s.Serialize<bool>(ShowFreeElixirAd, name: "ShowFreeElixirAd");
				maxTokenNb = s.Serialize<uint>(maxTokenNb, name: "maxTokenNb");
				tokenRefreshCooldown = s.Serialize<uint>(tokenRefreshCooldown, name: "tokenRefreshCooldown");
				eggAcquisition = s.Serialize<uint>(eggAcquisition, name: "eggAcquisition");
				maxContinue = s.Serialize<uint>(maxContinue, name: "maxContinue");
				continueCostX = s.Serialize<uint>(continueCostX, name: "continueCostX");
				startContinueCost = s.Serialize<uint>(startContinueCost, name: "startContinueCost");
				maxContinueCost = s.Serialize<uint>(maxContinueCost, name: "maxContinueCost");
				maxContinueWatchAd = s.Serialize<uint>(maxContinueWatchAd, name: "maxContinueWatchAd");
				SeasonalEventLastChanceId = s.Serialize<int>(SeasonalEventLastChanceId, name: "SeasonalEventLastChanceId");
				BeatboxCreatureList = s.SerializeObject<CListO<RLC_BeatboxDataList>>(BeatboxCreatureList, name: "BeatboxCreatureList");
				profileId = s.Serialize<string>(profileId, name: "profileId");
				PlayerNameNext = s.Serialize<string>(PlayerNameNext, name: "PlayerNameNext");
				askedSlot = s.Serialize<uint>(askedSlot, name: "askedSlot");
				readMailboxElements = s.SerializeObject<CListO<RLC_MailboxElementLight>>(readMailboxElements, name: "readMailboxElements");
				msdkItems = s.Serialize<string>(msdkItems, name: "msdkItems");
				PlayTime_Leaderboard_Global = s.Serialize<float>(PlayTime_Leaderboard_Global, name: "PlayTime_Leaderboard_Global");
				PlayTime_Leaderboard_Friends = s.Serialize<float>(PlayTime_Leaderboard_Friends, name: "PlayTime_Leaderboard_Friends");
				PlayTime_Leaderboard_Country = s.Serialize<float>(PlayTime_Leaderboard_Country, name: "PlayTime_Leaderboard_Country");
				PlayTime_Leaderboard_Worldwide = s.Serialize<float>(PlayTime_Leaderboard_Worldwide, name: "PlayTime_Leaderboard_Worldwide");
				PlayTime_Leaderboard_Likes = s.Serialize<float>(PlayTime_Leaderboard_Likes, name: "PlayTime_Leaderboard_Likes");
				Playtime_Leaderboard_VisitingTree = s.Serialize<float>(Playtime_Leaderboard_VisitingTree, name: "Playtime_Leaderboard_VisitingTree");
				Leaderboard_VisitingTreeCount = s.Serialize<uint>(Leaderboard_VisitingTreeCount, name: "Leaderboard_VisitingTreeCount");
				Leaderboard_VisitingProfileCount = s.Serialize<uint>(Leaderboard_VisitingProfileCount, name: "Leaderboard_VisitingProfileCount");
				TreeEventFamilyMap = s.SerializeObject<CMap<uint, pair<uint, RLC_CreatureTreeTier>>>(TreeEventFamilyMap, name: "TreeEventFamilyMap");
				seasonalEventCurrencyPoolAdventure = s.Serialize<uint>(seasonalEventCurrencyPoolAdventure, name: "seasonalEventCurrencyPoolAdventure");
				seasonalEventCurrencyPoolTree = s.Serialize<uint>(seasonalEventCurrencyPoolTree, name: "seasonalEventCurrencyPoolTree");
				seasonalEventCurrencyPoolLevel = s.Serialize<uint>(seasonalEventCurrencyPoolLevel, name: "seasonalEventCurrencyPoolLevel");
				seasonalCurrencyFoundInAdventureValueLTD = s.Serialize<uint>(seasonalCurrencyFoundInAdventureValueLTD, name: "seasonalCurrencyFoundInAdventureValueLTD");
				seasonalCurrencyFoundInTreeValueLTD = s.Serialize<uint>(seasonalCurrencyFoundInTreeValueLTD, name: "seasonalCurrencyFoundInTreeValueLTD");
				seasonalCurrencyFoundInLevelValueLTD = s.Serialize<uint>(seasonalCurrencyFoundInLevelValueLTD, name: "seasonalCurrencyFoundInLevelValueLTD");
				seasonalCurrencyAcquiredInPrimaryStoreLTD = s.Serialize<uint>(seasonalCurrencyAcquiredInPrimaryStoreLTD, name: "seasonalCurrencyAcquiredInPrimaryStoreLTD");
				seasonalCurrencyAcquiredInCheatLTD = s.Serialize<uint>(seasonalCurrencyAcquiredInCheatLTD, name: "seasonalCurrencyAcquiredInCheatLTD");
				seasonalCurrencyAcquiredTotalLTD = s.Serialize<uint>(seasonalCurrencyAcquiredTotalLTD, name: "seasonalCurrencyAcquiredTotalLTD");
				seasonalCurrencyUsedLTD = s.Serialize<uint>(seasonalCurrencyUsedLTD, name: "seasonalCurrencyUsedLTD");
				legChallengeRunsCount = s.Serialize<uint>(legChallengeRunsCount, name: "legChallengeRunsCount");
				totalChallengeRunsCount = s.Serialize<uint>(totalChallengeRunsCount, name: "totalChallengeRunsCount");
				seasonalEventLastTimeCurrencySpawnInAdventure = s.SerializeObject<online.DateTime>(seasonalEventLastTimeCurrencySpawnInAdventure, name: "seasonalEventLastTimeCurrencySpawnInAdventure");
				seasonalEventLastTimeCurrencySpawnInTree = s.SerializeObject<online.DateTime>(seasonalEventLastTimeCurrencySpawnInTree, name: "seasonalEventLastTimeCurrencySpawnInTree");
				seasonalEventLastTimeCurrencySpawnInLevel = s.SerializeObject<online.DateTime>(seasonalEventLastTimeCurrencySpawnInLevel, name: "seasonalEventLastTimeCurrencySpawnInLevel");
				seasonalEventLastTimeCurrencyFoundInAdventure = s.SerializeObject<online.DateTime>(seasonalEventLastTimeCurrencyFoundInAdventure, name: "seasonalEventLastTimeCurrencyFoundInAdventure");
				seasonalEventLastTimeCurrencyFoundInTree = s.SerializeObject<online.DateTime>(seasonalEventLastTimeCurrencyFoundInTree, name: "seasonalEventLastTimeCurrencyFoundInTree");
				seasonalEventLastTimeCurrencyFoundInLevel = s.SerializeObject<online.DateTime>(seasonalEventLastTimeCurrencyFoundInLevel, name: "seasonalEventLastTimeCurrencyFoundInLevel");
				seasonalEventFamilyList = s.SerializeObject<CMap<uint, RO2_PersistentGameData_Universe.SeasonalEventData>>(seasonalEventFamilyList, name: "seasonalEventFamilyList");
				currentSeasonalEventId = s.Serialize<uint>(currentSeasonalEventId, name: "currentSeasonalEventId");
				clusterName = s.Serialize<string>(clusterName, name: "clusterName");
				MagnifyingGlassUsedPerAdventure_LTD = s.Serialize<float>(MagnifyingGlassUsedPerAdventure_LTD, name: "MagnifyingGlassUsedPerAdventure_LTD");
				NbLevelUnlocked_LTD = s.Serialize<uint>(NbLevelUnlocked_LTD, name: "NbLevelUnlocked_LTD");
				NbLevelVisited_LTD = s.Serialize<uint>(NbLevelVisited_LTD, name: "NbLevelVisited_LTD");
				NbLevelCompleted_LTD = s.Serialize<uint>(NbLevelCompleted_LTD, name: "NbLevelCompleted_LTD");
				NbLevelBronze_LTD = s.Serialize<uint>(NbLevelBronze_LTD, name: "NbLevelBronze_LTD");
				NbLevelSilver_LTD = s.Serialize<uint>(NbLevelSilver_LTD, name: "NbLevelSilver_LTD");
				NbLevelGold_LTD = s.Serialize<uint>(NbLevelGold_LTD, name: "NbLevelGold_LTD");
				PropCompletion = s.Serialize<float>(PropCompletion, name: "PropCompletion");
				PropGold = s.Serialize<float>(PropGold, name: "PropGold");
				NbElixirSilverUsed_LTD = s.Serialize<uint>(NbElixirSilverUsed_LTD, name: "NbElixirSilverUsed_LTD");
				NbElixirGoldUsed_LTD = s.Serialize<uint>(NbElixirGoldUsed_LTD, name: "NbElixirGoldUsed_LTD");
				NbElixirNewCreatureUsed_LTD = s.Serialize<uint>(NbElixirNewCreatureUsed_LTD, name: "NbElixirNewCreatureUsed_LTD");
				NbElixirSpeedUsed_LTD = s.Serialize<uint>(NbElixirSpeedUsed_LTD, name: "NbElixirSpeedUsed_LTD");
				NbElixirSilverOwned_LTD = s.Serialize<uint>(NbElixirSilverOwned_LTD, name: "NbElixirSilverOwned_LTD");
				NbElixirGoldOwned_LTD = s.Serialize<uint>(NbElixirGoldOwned_LTD, name: "NbElixirGoldOwned_LTD");
				NbElixirNewCreatureOwned_LTD = s.Serialize<uint>(NbElixirNewCreatureOwned_LTD, name: "NbElixirNewCreatureOwned_LTD");
				NbElixirSpeedOwned_LTD = s.Serialize<uint>(NbElixirSpeedOwned_LTD, name: "NbElixirSpeedOwned_LTD");
				PropUsedElixirs = s.Serialize<float>(PropUsedElixirs, name: "PropUsedElixirs");
				ratingPopupVersionToSkip = s.Serialize<string>(ratingPopupVersionToSkip, name: "ratingPopupVersionToSkip");
				ratingPopupSkipLikePhase = s.Serialize<bool>(ratingPopupSkipLikePhase, name: "ratingPopupSkipLikePhase");
				neverShowRatingPopup = s.Serialize<bool>(neverShowRatingPopup, name: "neverShowRatingPopup");
				ratingPopupShownCptLtd = s.Serialize<uint>(ratingPopupShownCptLtd, name: "ratingPopupShownCptLtd");
				newRatingPopupRequestedCount = s.Serialize<uint>(newRatingPopupRequestedCount, name: "newRatingPopupRequestedCount");
				playedGameVersions = s.SerializeObject<CListP<string>>(playedGameVersions, name: "playedGameVersions");
				needToShowTimeSavingEndingPopup = s.Serialize<bool>(needToShowTimeSavingEndingPopup, name: "needToShowTimeSavingEndingPopup");
				ShopAgeGateCheckDone = s.Serialize<bool>(ShopAgeGateCheckDone, name: "ShopAgeGateCheckDone");
				ShopNonAgressiveMode = s.Serialize<bool>(ShopNonAgressiveMode, name: "ShopNonAgressiveMode");
				DecoyEggIntroDone = s.Serialize<bool>(DecoyEggIntroDone, name: "DecoyEggIntroDone");
				AddingMirroredLevelsDone = s.Serialize<bool>(AddingMirroredLevelsDone, name: "AddingMirroredLevelsDone");
				LuckyTicketAcquiredLtd = s.Serialize<uint>(LuckyTicketAcquiredLtd, name: "LuckyTicketAcquiredLtd");
				GoldenTicketAcquiredLtd = s.Serialize<uint>(GoldenTicketAcquiredLtd, name: "GoldenTicketAcquiredLtd");
				SeasonalTicketAcquiredLtd = s.Serialize<uint>(SeasonalTicketAcquiredLtd, name: "SeasonalTicketAcquiredLtd");
				ChallengeTicketAcquiredLtd = s.Serialize<uint>(ChallengeTicketAcquiredLtd, name: "ChallengeTicketAcquiredLtd");
				ChallengeTokenAcquiredLtd = s.Serialize<uint>(ChallengeTokenAcquiredLtd, name: "ChallengeTokenAcquiredLtd");
				BeatBoxSlotAcquiredLtd = s.Serialize<uint>(BeatBoxSlotAcquiredLtd, name: "BeatBoxSlotAcquiredLtd");
				SeasonalEggAcquiredLtd = s.Serialize<uint>(SeasonalEggAcquiredLtd, name: "SeasonalEggAcquiredLtd");
				RemoveAdsPurchased = s.Serialize<bool>(RemoveAdsPurchased, name: "RemoveAdsPurchased");
				TimerAdventureStartTimeInSec = s.Serialize<ulong>(TimerAdventureStartTimeInSec, name: "TimerAdventureStartTimeInSec");
				TimerAdventureEndTimeInSec = s.Serialize<ulong>(TimerAdventureEndTimeInSec, name: "TimerAdventureEndTimeInSec");
				TimerAdventureGemsExtentions = s.Serialize<uint>(TimerAdventureGemsExtentions, name: "TimerAdventureGemsExtentions");
				TimerAdventureAdExtentions = s.Serialize<uint>(TimerAdventureAdExtentions, name: "TimerAdventureAdExtentions");
				IsTimerAdventureEggRescued = s.Serialize<bool>(IsTimerAdventureEggRescued, name: "IsTimerAdventureEggRescued");
				CurrentPerkPackActive = s.Serialize<uint>(CurrentPerkPackActive, name: "CurrentPerkPackActive");
				TimeLastShownMiniEventExclamation = s.SerializeObject<online.DateTime>(TimeLastShownMiniEventExclamation, name: "TimeLastShownMiniEventExclamation");
				MiniEventsSessionsSinceLastShown = s.Serialize<uint>(MiniEventsSessionsSinceLastShown, name: "MiniEventsSessionsSinceLastShown");
			}
		}
		[Games(GameFlags.RA)]
		public partial class RO2_LuckyTicketReward : CSerializable {
			public uint id;
			public uint type;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				id = s.Serialize<uint>(id, name: "id");
				type = s.Serialize<uint>(type, name: "type");
			}
		}
		[Games(GameFlags.RA)]
		public partial class petRewardData : CSerializable {
			public uint lastSpawnDay;
			public uint maxRewardNb;
			public uint remainingRewards;
			public uint rewardType;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				lastSpawnDay = s.Serialize<uint>(lastSpawnDay, name: "lastSpawnDay");
				maxRewardNb = s.Serialize<uint>(maxRewardNb, name: "maxRewardNb");
				remainingRewards = s.Serialize<uint>(remainingRewards, name: "remainingRewards");
				rewardType = s.Serialize<uint>(rewardType, name: "rewardType");
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_MenuOptionSave : CSerializable {
			public float musicVolume;
			public float sfxVolume;
			public uint language;
			public bool Is3GDownloadEnabled;
			public bool Is3GCacheVideoEnabled;
			public bool notificationsEnabled;
			public bool everyplayEnabled;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				musicVolume = s.Serialize<float>(musicVolume, name: "musicVolume");
				sfxVolume = s.Serialize<float>(sfxVolume, name: "sfxVolume");
				language = s.Serialize<uint>(language, name: "language");
				Is3GDownloadEnabled = s.Serialize<bool>(Is3GDownloadEnabled, name: "Is3GDownloadEnabled");
				Is3GCacheVideoEnabled = s.Serialize<bool>(Is3GCacheVideoEnabled, name: "Is3GCacheVideoEnabled");
				notificationsEnabled = s.Serialize<bool>(notificationsEnabled, name: "notificationsEnabled");
				everyplayEnabled = s.Serialize<bool>(everyplayEnabled, name: "everyplayEnabled");
			}
		}
		[Games(GameFlags.RA)]
		public partial class UnlockedDoor : CSerializable {
			public StringID worldTag;
			public uint type;
			public bool isNew;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				worldTag = s.SerializeObject<StringID>(worldTag, name: "worldTag");
				type = s.Serialize<uint>(type, name: "type");
				isNew = s.Serialize<bool>(isNew, name: "isNew");
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_MissionData : CSerializable {
			public StringID missionId;
			public uint status;
			public uint hitCount;
			public ulong activeTime;
			public bool rewardAlreadyCollected;
			public uint requiredHitCount;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				missionId = s.SerializeObject<StringID>(missionId, name: "missionId");
				status = s.Serialize<uint>(status, name: "status");
				hitCount = s.Serialize<uint>(hitCount, name: "hitCount");
				activeTime = s.Serialize<ulong>(activeTime, name: "activeTime");
				rewardAlreadyCollected = s.Serialize<bool>(rewardAlreadyCollected, name: "rewardAlreadyCollected");
				requiredHitCount = s.Serialize<uint>(requiredHitCount, name: "requiredHitCount");
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_CreatureData : CSerializable {
			public StringID creatureId;
			public uint count;
			public bool favorite;
			public bool exhausted;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				creatureId = s.SerializeObject<StringID>(creatureId, name: "creatureId");
				count = s.Serialize<uint>(count, name: "count");
				favorite = s.Serialize<bool>(favorite, name: "favorite");
				exhausted = s.Serialize<bool>(exhausted, name: "exhausted");
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_CostumePlayTime : CSerializable {
			public StringID costumeID;
			public float playtime;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				costumeID = s.SerializeObject<StringID>(costumeID, name: "costumeID");
				playtime = s.Serialize<float>(playtime, name: "playtime");
			}
		}
		[Games(GameFlags.RA)]
		public partial class NodeDataStruct : CSerializable {
			public StringID tag;
			public bool unteaseSeen;
			public bool unlockSeend;
			public bool sentUnlockMessage;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				unteaseSeen = s.Serialize<bool>(unteaseSeen, name: "unteaseSeen");
				unlockSeend = s.Serialize<bool>(unlockSeend, name: "unlockSeend");
				sentUnlockMessage = s.Serialize<bool>(sentUnlockMessage, name: "sentUnlockMessage");
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_AdventureNodeData : CSerializable {
			public Enum_nodeType nodeType;
			public uint nodeIndex;
			public Path mapPath;
			public Enum_mapType mapType;
			public Enum_mapKit mapKit;
			public uint difficulty;
			public bool unlocked;
			public bool completed;
			public bool spawned;
			public bool baseSpawned;
			public bool childrenPathApparitionCompleted;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				nodeType = s.Serialize<Enum_nodeType>(nodeType, name: "nodeType");
				nodeIndex = s.Serialize<uint>(nodeIndex, name: "nodeIndex");
				mapPath = s.SerializeObject<Path>(mapPath, name: "mapPath");
				mapType = s.Serialize<Enum_mapType>(mapType, name: "mapType");
				mapKit = s.Serialize<Enum_mapKit>(mapKit, name: "mapKit");
				difficulty = s.Serialize<uint>(difficulty, name: "difficulty");
				unlocked = s.Serialize<bool>(unlocked, name: "unlocked");
				completed = s.Serialize<bool>(completed, name: "completed");
				spawned = s.Serialize<bool>(spawned, name: "spawned");
				baseSpawned = s.Serialize<bool>(baseSpawned, name: "baseSpawned");
				childrenPathApparitionCompleted = s.Serialize<bool>(childrenPathApparitionCompleted, name: "childrenPathApparitionCompleted");
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
			public int family;
			public uint cups;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				family = s.Serialize<int>(family, name: "family");
				cups = s.Serialize<uint>(cups, name: "cups");
			}
		}
		[Games(GameFlags.RA)]
		public partial class RLC_ElixirUtilisation : CSerializable {
			public Enum_elixirType elixirType;
			public uint nbElixirs;
			public float remainingTime;
			public online.DateTime dateTime;
			public uint gemsCost;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				elixirType = s.Serialize<Enum_elixirType>(elixirType, name: "elixirType");
				nbElixirs = s.Serialize<uint>(nbElixirs, name: "nbElixirs");
				remainingTime = s.Serialize<float>(remainingTime, name: "remainingTime");
				dateTime = s.SerializeObject<online.DateTime>(dateTime, name: "dateTime");
				gemsCost = s.Serialize<uint>(gemsCost, name: "gemsCost");
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
			public Vec3d pos;
			public uint adventureSequence;
			public online.DateTime adventureStartDate;
			public ulong adventureLifeTimeInSec;
			public ulong adventureDefaultLifeTimeInSec;
			public uint timeLimitedAdventureTutorialShown;
			public uint timeLimitedAdventureCompleteInTime;
			public bool timeLimitedAdventureRewardCredited;
			public Enum_region region;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				adventureSequence = s.Serialize<uint>(adventureSequence, name: "adventureSequence");
				adventureStartDate = s.SerializeObject<online.DateTime>(adventureStartDate, name: "adventureStartDate");
				adventureLifeTimeInSec = s.Serialize<ulong>(adventureLifeTimeInSec, name: "adventureLifeTimeInSec");
				adventureDefaultLifeTimeInSec = s.Serialize<ulong>(adventureDefaultLifeTimeInSec, name: "adventureDefaultLifeTimeInSec");
				timeLimitedAdventureTutorialShown = s.Serialize<uint>(timeLimitedAdventureTutorialShown, name: "timeLimitedAdventureTutorialShown");
				timeLimitedAdventureCompleteInTime = s.Serialize<uint>(timeLimitedAdventureCompleteInTime, name: "timeLimitedAdventureCompleteInTime");
				timeLimitedAdventureRewardCredited = s.Serialize<bool>(timeLimitedAdventureRewardCredited, name: "timeLimitedAdventureRewardCredited");
				region = s.Serialize<Enum_region>(region, name: "region");
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
			public StringID creatureId;
			public Enum_rewardType rewardType;
			public RLC_LuckyTicketReward decoyReward;
			public Enum_region region;
			public Creature_Rarity rarity;
			public RLC_CreatureAcquisition acquisition;
			public bool spyGlass;
			public uint version;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				creatureId = s.SerializeObject<StringID>(creatureId, name: "creatureId");
				rewardType = s.Serialize<Enum_rewardType>(rewardType, name: "rewardType");
				decoyReward = s.SerializeObject<RLC_LuckyTicketReward>(decoyReward, name: "decoyReward");
				region = s.Serialize<Enum_region>(region, name: "region");
				rarity = s.Serialize<Creature_Rarity>(rarity, name: "rarity");
				acquisition = s.Serialize<RLC_CreatureAcquisition>(acquisition, name: "acquisition");
				spyGlass = s.Serialize<bool>(spyGlass, name: "spyGlass");
				version = s.Serialize<uint>(version, name: "version");
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
			public Vec3d pos;
			public uint adventureSequence;
			public online.DateTime adventureStartDate;
			public ulong adventureLifeTimeInSec;
			public ulong adventureDefaultLifeTimeInSec;
			public uint timeLimitedAdventureTutorialShown;
			public uint timeLimitedAdventureCompleteInTime;
			public bool timeLimitedAdventureRewardCredited;
			public Enum_region region;
			public StringID creatureId;
			public Creature_Rarity rarity;
			public RO2_PersistentGameData_Universe.RLC_EggData eggData;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				adventureSequence = s.Serialize<uint>(adventureSequence, name: "adventureSequence");
				adventureStartDate = s.SerializeObject<online.DateTime>(adventureStartDate, name: "adventureStartDate");
				adventureLifeTimeInSec = s.Serialize<ulong>(adventureLifeTimeInSec, name: "adventureLifeTimeInSec");
				adventureDefaultLifeTimeInSec = s.Serialize<ulong>(adventureDefaultLifeTimeInSec, name: "adventureDefaultLifeTimeInSec");
				timeLimitedAdventureTutorialShown = s.Serialize<uint>(timeLimitedAdventureTutorialShown, name: "timeLimitedAdventureTutorialShown");
				timeLimitedAdventureCompleteInTime = s.Serialize<uint>(timeLimitedAdventureCompleteInTime, name: "timeLimitedAdventureCompleteInTime");
				timeLimitedAdventureRewardCredited = s.Serialize<bool>(timeLimitedAdventureRewardCredited, name: "timeLimitedAdventureRewardCredited");
				region = s.Serialize<Enum_region>(region, name: "region");
				creatureId = s.SerializeObject<StringID>(creatureId, name: "creatureId");
				rarity = s.Serialize<Creature_Rarity>(rarity, name: "rarity");
				eggData = s.SerializeObject<RO2_PersistentGameData_Universe.RLC_EggData>(eggData, name: "eggData");
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
			public bool unlocked;
			public bool finished;
			public CListP<uint> familyId;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				unlocked = s.Serialize<bool>(unlocked, name: "unlocked");
				finished = s.Serialize<bool>(finished, name: "finished");
				familyId = s.SerializeObject<CListP<uint>>(familyId, name: "familyId");
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
		public enum RLC_CreatureAcquisition {
			[Serialize("Unknown"             )] Unknown = 0,
			[Serialize("AdventureEgg"        )] AdventureEgg = 1,
			[Serialize("FindCharlie"         )] FindCharlie = 2,
			[Serialize("LuckyTicket"         )] LuckyTicket = 3,
			[Serialize("GoldenTicket"        )] GoldenTicket = 4,
			[Serialize("Intro"               )] Intro = 5,
			[Serialize("Cheat"               )] Cheat = 6,
			[Serialize("Message"             )] Message = 7,
			[Serialize("SeasonalTicket"      )] SeasonalTicket = 8,
			[Serialize("SeasonalEgg"         )] SeasonalEgg = 9,
			[Serialize("BuyNewCreature"      )] BuyNewCreature = 10,
			[Serialize("DecoyEggIntro"       )] DecoyEggIntro = 0xb,
			[Serialize("challengeTicket"     )] challengeTicket = 0xc,
			[Serialize("BuyNewFamilyCreature")] BuyNewFamilyCreature = 0xd,
			[Serialize("COUNT"               )] COUNT = 0xe,
		}
		public override uint? ClassCRC => 0xBAA85A3F;
	}
}

