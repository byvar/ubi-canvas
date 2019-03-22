using UnityEngine;

namespace UbiArt.ITF {
	public enum GameplayErrorContext {
		[Serialize("RangeContexte")] RangeContexte = 100,
		[Serialize("Gen_NoEnoughSpaceToPlay")] Gen_NoEnoughSpaceToPlay = 101,
		[Serialize("Gen_CustomText1Button")] Gen_CustomText1Button = 102,
		[Serialize("Gen_CustomText2Button")] Gen_CustomText2Button = 103,
		[Serialize("Gen_RatingEurope")] Gen_RatingEurope = 104,
		[Serialize("Gen_RatingAmerica")] Gen_RatingAmerica = 105,
		[Serialize("Gen_FakeMessage")] Gen_FakeMessage = 106,
		[Serialize("Test_0Button")] Test_0Button = 400,
		[Serialize("Test_1Button")] Test_1Button = 401,
		[Serialize("Test_2Button")] Test_2Button = 402,
		[Serialize("Pad_enum")] Pad_enum = 500,
		[Serialize("Pad_DisconnectingDuringTitleScreen")] Pad_DisconnectingDuringTitleScreen = 501,
		[Serialize("Pad_DisconnectingDuringGameplay")] Pad_DisconnectingDuringGameplay = 502,
		[Serialize("Pad_DisconnectingDuringMenu")] Pad_DisconnectingDuringMenu = 503,
		[Serialize("Pad_ExtensionNunchukDetected")] Pad_ExtensionNunchukDetected = 504,
		[Serialize("Pad_NoExtensionDetected")] Pad_NoExtensionDetected = 505,
		[Serialize("Pad_ExtensionClassicDetected")] Pad_ExtensionClassicDetected = 506,
		[Serialize("Pad_LowBattery")] Pad_LowBattery = 507,
		[Serialize("Pad_NoDRCDetected")] Pad_NoDRCDetected = 508,
		[Serialize("Pad_DRCDisconnected")] Pad_DRCDisconnected = 509,
		[Serialize("Pad_URCCDisconnected")] Pad_URCCDisconnected = 510,
		[Serialize("Sav_enum")] Sav_enum = 600,
		[Serialize("Sav_CheckSpace")] Sav_CheckSpace = 601,
		[Serialize("Sav_CheckSpaceBoot")] Sav_CheckSpaceBoot = 602,
		[Serialize("Sav_NoEnoughSpaceBoot")] Sav_NoEnoughSpaceBoot = 603,
		[Serialize("Sav_NoEnoughSpace")] Sav_NoEnoughSpace = 604,
		[Serialize("Sav_NoEnoughInode")] Sav_NoEnoughInode = 605,
		[Serialize("Sav_OperationRunning")] Sav_OperationRunning = 606,
		[Serialize("Sav_ReadFiles")] Sav_ReadFiles = 607,
		[Serialize("Sav_InitCreatingFiles")] Sav_InitCreatingFiles = 608,
		[Serialize("Sav_InitCreatingBanner")] Sav_InitCreatingBanner = 609,
		[Serialize("Sav_NoAvailableStorage")] Sav_NoAvailableStorage = 610,
		[Serialize("Sav_NewGameAskForOverwrite")] Sav_NewGameAskForOverwrite = 611,
		[Serialize("Sav_SaveAskForOverwrite")] Sav_SaveAskForOverwrite = 612,
		[Serialize("Sav_AskForDelete")] Sav_AskForDelete = 613,
		[Serialize("Sav_UserNotSignedIn")] Sav_UserNotSignedIn = 614,
		[Serialize("Sav_SaveAndExit")] Sav_SaveAndExit = 615,
		[Serialize("Sav_DeviceNoMoreAvailableForSave")] Sav_DeviceNoMoreAvailableForSave = 616,
		[Serialize("Sav_DeviceNoMoreAvailableForLoad")] Sav_DeviceNoMoreAvailableForLoad = 617,
		[Serialize("Sav_FileNotAvailable")] Sav_FileNotAvailable = 618,
		[Serialize("Sav_ErrorDuringSave")] Sav_ErrorDuringSave = 619,
		[Serialize("Sav_ErrorDuringLoad")] Sav_ErrorDuringLoad = 620,
		[Serialize("Sav_CorruptedFile")] Sav_CorruptedFile = 621,
		[Serialize("Sav_NotOwnerOfTheSave")] Sav_NotOwnerOfTheSave = 622,
		[Serialize("Sav_WarningBoot")] Sav_WarningBoot = 623,
		[Serialize("Sav_AchievementWarning")] Sav_AchievementWarning = 624,
		[Serialize("Sav_AskToAllowTracking")] Sav_AskToAllowTracking = 625,
		[Serialize("Sav_TooRecentVersion")] Sav_TooRecentVersion = 626,
		[Serialize("Sav_EnumeratingContent")] Sav_EnumeratingContent = 627,
		[Serialize("Sav_ErrorDuringDelete")] Sav_ErrorDuringDelete = 628,
		[Serialize("Sav_UGCSaveManager_NoFreeBlocks")] Sav_UGCSaveManager_NoFreeBlocks = 629,
		[Serialize("Sav_CloudSaveConflict")] Sav_CloudSaveConflict = 630,
		[Serialize("Sav_CloudSourceChoice")] Sav_CloudSourceChoice = 631,
		[Serialize("Sav_CloudSourceChanged")] Sav_CloudSourceChanged = 632,
		[Serialize("Sav_BackToMainMenu")] Sav_BackToMainMenu = 633,
		[Serialize("Sav_BackToAdventureMap")] Sav_BackToAdventureMap = 634,
		[Serialize("Sav_NoEnoughSlot")] Sav_NoEnoughSlot = 635,
		[Serialize("Sav_SongBeatBox")] Sav_SongBeatBox = 636,
		[Serialize("Sav_QuitBeatBox")] Sav_QuitBeatBox = 637,
		[Serialize("Sav_QuitGame")] Sav_QuitGame = 638,
		[Serialize("Sav_NoStorrageSpace")] Sav_NoStorrageSpace = 639,
		[Serialize("Sav_CloudSaveAlreadyExists")] Sav_CloudSaveAlreadyExists = 640,
		[Serialize("Sav_CloudSaveBadImportCode")] Sav_CloudSaveBadImportCode = 641,
		[Serialize("IO_enum")] IO_enum = 700,
		[Serialize("IO_UnexpectedError")] IO_UnexpectedError = 701,
		[Serialize("IO_Corrupted")] IO_Corrupted = 702,
		[Serialize("IO_OpeningFile")] IO_OpeningFile = 703,
		[Serialize("IO_ReadingFile")] IO_ReadingFile = 704,
		[Serialize("IO_SeekingFile")] IO_SeekingFile = 705,
		[Serialize("IO_WritingFile")] IO_WritingFile = 706,
		[Serialize("IO_DescriptingFile")] IO_DescriptingFile = 707,
		[Serialize("IO_DeletingFile")] IO_DeletingFile = 708,
		[Serialize("IO_RenamingFile")] IO_RenamingFile = 709,
		[Serialize("Rwd_enum")] Rwd_enum = 800,
		[Serialize("Rwd_CheckSpaceBoot")] Rwd_CheckSpaceBoot = 801,
		[Serialize("Rwd_NoEnoughSpace")] Rwd_NoEnoughSpace = 802,
		[Serialize("Mobile__enum")] Mobile__enum = 810,
		[Serialize("Mobile_DisclaimerDevice")] Mobile_DisclaimerDevice = 811,
		[Serialize("Net_enum")] Net_enum = 900,
		[Serialize("Net_PlatformConnectionLost")] Net_PlatformConnectionLost = 901,
		[Serialize("Net_RendezVousConnectionLost")] Net_RendezVousConnectionLost = 902,
		[Serialize("Net_RendezVousConnectionImpossible")] Net_RendezVousConnectionImpossible = 903,
		[Serialize("Net_RendezVousConnectionMaintenance")] Net_RendezVousConnectionMaintenance = 904,
		[Serialize("Net_RendezVousDisconnected")] Net_RendezVousDisconnected = 905,
		[Serialize("Net_PlatformConnectionRequired")] Net_PlatformConnectionRequired = 906,
		[Serialize("Net_ConnectionInProgress")] Net_ConnectionInProgress = 907,
		[Serialize("Net_NoNetworkAccount")] Net_NoNetworkAccount = 908,
		[Serialize("Net_NoErrorFound")] Net_NoErrorFound = 909,
		[Serialize("Net_NoConnectedFakeOnly")] Net_NoConnectedFakeOnly = 910,
		[Serialize("Net_SystemError")] Net_SystemError = 911,
		[Serialize("Net_ConnectionTimeOut")] Net_ConnectionTimeOut = 912,
		[Serialize("Net_ParentalControlRestriction")] Net_ParentalControlRestriction = 913,
		[Serialize("Net_UserSignOut")] Net_UserSignOut = 914,
		[Serialize("Net_OperationInProgress")] Net_OperationInProgress = 915,
		[Serialize("Net_PatchNeeded")] Net_PatchNeeded = 916,
		[Serialize("Net_AlreadyConnected")] Net_AlreadyConnected = 917,
		[Serialize("Net_RequestError")] Net_RequestError = 918,
		[Serialize("Net_UpdateDownloaded")] Net_UpdateDownloaded = 919,
		[Serialize("Net_FacebookAppNeededForScreenshot")] Net_FacebookAppNeededForScreenshot = 920,
		[Serialize("Net_TwitterAppNeededForScreenshot")] Net_TwitterAppNeededForScreenshot = 921,
		[Serialize("Net_MessagingCustom")] Net_MessagingCustom = 922,
		[Serialize("Net_AdColony")] Net_AdColony = 923,
		[Serialize("Net_FacebookDevicesCode")] Net_FacebookDevicesCode = 924,
		[Serialize("Net_SinaWeiboAppNeededForScreenshot")] Net_SinaWeiboAppNeededForScreenshot = 925,
		[Serialize("Net_DeleteSaveSlotsToImportFacebookSaves")] Net_DeleteSaveSlotsToImportFacebookSaves = 926,
		[Serialize("Net_DeleteSaveSlotsToImportSinaWeiboSaves")] Net_DeleteSaveSlotsToImportSinaWeiboSaves = 927,
		[Serialize("Net_AskFor3GDownload")] Net_AskFor3GDownload = 928,
		[Serialize("Net_NoConnectionInternet")] Net_NoConnectionInternet = 929,
		[Serialize("Net_StoragePermissionInFaceBookAppNeededForScreenshot")] Net_StoragePermissionInFaceBookAppNeededForScreenshot = 930,
		[Serialize("Net_StoragePermissionInTwitterAppNeededForScreenshot")] Net_StoragePermissionInTwitterAppNeededForScreenshot = 931,
		[Serialize("Net_GameServerMaintenance")] Net_GameServerMaintenance = 932,
		[Serialize("Net_GameServerTimedMaintenance")] Net_GameServerTimedMaintenance = 933,
		[Serialize("Net_GuidedAccess")] Net_GuidedAccess = 934,
		[Serialize("Uplay_WarningUnder13")] Uplay_WarningUnder13 = 950,
		[Serialize("Uplay_IncorrectInformationSignin")] Uplay_IncorrectInformationSignin = 951,
		[Serialize("Uplay_AlreadyLinked")] Uplay_AlreadyLinked = 952,
		[Serialize("Uplay_LinkSucced")] Uplay_LinkSucced = 953,
		[Serialize("Uplay_InformationMessage")] Uplay_InformationMessage = 954,
		[Serialize("Uplay_WarningLeavingTheGame")] Uplay_WarningLeavingTheGame = 955,
		[Serialize("Uplay_NotAvailableYet")] Uplay_NotAvailableYet = 956,
		[Serialize("Uplay_BootSigninMessage")] Uplay_BootSigninMessage = 957,
		[Serialize("Miiverse_UGCWarning")] Miiverse_UGCWarning = 960,
		[Serialize("Shop_UpsellTrial")] Shop_UpsellTrial = 970,
		[Serialize("Exit_QuitGame")] Exit_QuitGame = 980,
		[Serialize("Gam_enum")] Gam_enum = 1000,
		[Serialize("Gam_NoConnectedForDailyChallenge")] Gam_NoConnectedForDailyChallenge = 1001,
		[Serialize("Gam_WaitingForTitleStorageDownload")] Gam_WaitingForTitleStorageDownload = 1002,
		[Serialize("Gam_DailyChallengeRequestError")] Gam_DailyChallengeRequestError = 1003,
		[Serialize("Gam_LeaderboardRequestError")] Gam_LeaderboardRequestError = 1004,
		[Serialize("Gam_PlayerCardRequestError")] Gam_PlayerCardRequestError = 1005,
		[Serialize("Gam_AddFriendConfirm")] Gam_AddFriendConfirm = 1006,
		[Serialize("Gam_AddedFriendSuccess")] Gam_AddedFriendSuccess = 1007,
		[Serialize("Gam_AddedFriendFailed")] Gam_AddedFriendFailed = 1008,
		[Serialize("Gam_RemoveFriendConfirm")] Gam_RemoveFriendConfirm = 1009,
		[Serialize("Gam_RemovedFriendSuccess")] Gam_RemovedFriendSuccess = 1010,
		[Serialize("Gam_RemovedFriendFailed")] Gam_RemovedFriendFailed = 1011,
		[Serialize("Gam_LeaderboardWritingError")] Gam_LeaderboardWritingError = 1012,
		[Serialize("Gam_TransactionDeletingError")] Gam_TransactionDeletingError = 1013,
		[Serialize("Gam_ChallengeInvitationConfirmOne")] Gam_ChallengeInvitationConfirmOne = 1014,
		[Serialize("Gam_ChallengeInvitationConfirmMany")] Gam_ChallengeInvitationConfirmMany = 1015,
		[Serialize("Gam_ChallengeInvitationConfirmTooMany")] Gam_ChallengeInvitationConfirmTooMany = 1016,
		[Serialize("Gam_ChallengeInvitationError")] Gam_ChallengeInvitationError = 1017,
		[Serialize("Gam_ChallengeInvitationSuccess")] Gam_ChallengeInvitationSuccess = 1018,
		[Serialize("Gam_LuckyTicketOfferConfirm")] Gam_LuckyTicketOfferConfirm = 1019,
		[Serialize("Gam_LuckyTicketOfferError")] Gam_LuckyTicketOfferError = 1020,
		[Serialize("Gam_LuckyTicketOfferSuccess")] Gam_LuckyTicketOfferSuccess = 1021,
		[Serialize("Gam_TvOffInGameConfirm")] Gam_TvOffInGameConfirm = 1022,
		[Serialize("Gam_TvOffHomeConfirm")] Gam_TvOffHomeConfirm = 1023,
		[Serialize("Gam_TvOnConfirm")] Gam_TvOnConfirm = 1024,
		[Serialize("Gam_ChallengeTimeOver")] Gam_ChallengeTimeOver = 1025,
		[Serialize("Gam_ChallengeExpertStart")] Gam_ChallengeExpertStart = 1026,
		[Serialize("Gam_ChallengeNeedOnline")] Gam_ChallengeNeedOnline = 1027,
		[Serialize("Gam_PauseRestartLevel")] Gam_PauseRestartLevel = 1028,
		[Serialize("Gam_PauseRestartCheckpoint")] Gam_PauseRestartCheckpoint = 1029,
		[Serialize("Gam_PauseExitLevel")] Gam_PauseExitLevel = 1030,
		[Serialize("Gam_PauseExitGame")] Gam_PauseExitGame = 1031,
		[Serialize("Gam_NextPlayerLevel")] Gam_NextPlayerLevel = 1032,
		[Serialize("Gam_LastPlayerLevel")] Gam_LastPlayerLevel = 1033,
		[Serialize("Gam_FirstPlayerLevel")] Gam_FirstPlayerLevel = 1034,
		[Serialize("Gam_NextOtherPlayerLevel")] Gam_NextOtherPlayerLevel = 1035,
		[Serialize("Gam_LastOtherPlayerLevel")] Gam_LastOtherPlayerLevel = 1036,
		[Serialize("Gam_TvOffMainMenuConfirm")] Gam_TvOffMainMenuConfirm = 1037,
		[Serialize("Gam_FriendAlreadyChallenged")] Gam_FriendAlreadyChallenged = 1038,
		[Serialize("Gam_FriendAlreadyChallengePlayed")] Gam_FriendAlreadyChallengePlayed = 1039,
		[Serialize("Gam_FriendChallengeLocked")] Gam_FriendChallengeLocked = 1040,
		[Serialize("Gam_ChallengeUserDisconnected")] Gam_ChallengeUserDisconnected = 1041,
		[Serialize("Gam_ChallengeConnectionFailed")] Gam_ChallengeConnectionFailed = 1042,
		[Serialize("Gam_ChallengeTimesUp")] Gam_ChallengeTimesUp = 1043,
		[Serialize("Gam_VoucherInvalidKey")] Gam_VoucherInvalidKey = 1044,
		[Serialize("Gam_VoucherGoodKey")] Gam_VoucherGoodKey = 1045,
		[Serialize("Gam_VoucherAlreadyUsedKey")] Gam_VoucherAlreadyUsedKey = 1046,
		[Serialize("Gam_SlowChallengeIssue")] Gam_SlowChallengeIssue = 1047,
		[Serialize("Gam_ConfirmGoToNextAdventure")] Gam_ConfirmGoToNextAdventure = 1048,
		[Serialize("Gam_CollectionSyncRestart")] Gam_CollectionSyncRestart = 1049,
		[Serialize("Gam_LocalizationFontReboot")] Gam_LocalizationFontReboot = 1050,
		[Serialize("Gam_DemoAskForTutos")] Gam_DemoAskForTutos = 1051,
		[Serialize("Gam_DeleteSlotsForFacebook")] Gam_DeleteSlotsForFacebook = 1052,
		[Serialize("Gam_DeleteSlotsForSinaWeibo")] Gam_DeleteSlotsForSinaWeibo = 1053,
		[Serialize("Gam_ThankYouIAP")] Gam_ThankYouIAP = 1054,
		[Serialize("Gam_ScreenshotFailed")] Gam_ScreenshotFailed = 1055,
		[Serialize("Gam_QuittingSeasonalEventLastChance")] Gam_QuittingSeasonalEventLastChance = 1056,
		[Serialize("Gam_ShopAgeGate")] Gam_ShopAgeGate = 1057,
	}
}

