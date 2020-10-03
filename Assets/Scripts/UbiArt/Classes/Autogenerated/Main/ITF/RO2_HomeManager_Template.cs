using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HomeManager_Template : TemplateObj {
		public Path tombPath;
		public Path tombIconPath;
		public float challengeEndDelay;
		public float challengeEndDelayAfterDistanceSuccess;
		public float saveDelayMin;
		public CListO<CompetitionModeInfo> competitionsModes;
		public CListO<CompetitionLevelInfo> competitionsLevels;
		public CListO<StatInfos> statsInfos;
		public CListO<PlayerLevelInfos> playerLevelInfos;
		public CListO<CupInfos> cupInfos;
		public CListO<ITF.Message> messages;
		public CListO<online.Message> messagesAdventures;
		public CArrayO<Color> medalColors;
		public CArrayO<StringID> miiverseMenuSequenceNames;
		public CArrayP<int> countryId;
		public Path emblemDev;
		public Path emblemVip;
		public Path CompetitionFrequencyIcon_Daily;
		public Path CompetitionFrequencyIcon_Weekly;
		public Path CompetitionFrequencyIcon_Weekly_Expert;
		public Path CompetitionFrequencyIcon_Daily_Expert;
		public StringID challengeFailedFX;
		public StringID challengeSuccessFX;
		public StringID challengeBestScoreFX;
		public SmartLocId challengeTimesUpText;
		public SmartLocId legendsWorldUnlock;
		public SmartLocId legendsWorldUnlockButton;
		public SmartLocId legendsWorldUnlockButton2;
		public SmartLocId princessUnlock;
		public SmartLocId worldUnlock;
		public SmartLocId worldUnlockButton;
		public SmartLocId levelUnlock;
		public SmartLocId levelUnlockButton;
		public SmartLocId retroLevelUnlock;
		public SmartLocId retroLevelUnlockButton;
		public SmartLocId petUnlock;
		public SmartLocId petUnlockButton;
		public SmartLocId costumeUnlock;
		public SmartLocId costumeUnlockButton;
		public SmartLocId challengeUnlock;
		public SmartLocId challengeUnlockButton;
		public SmartLocId invasionUnlock;
		public SmartLocId invasionUnlockButton;
		public SmartLocId invasionFailedTitle;
		public SmartLocId invasionFailedText;
		public SmartLocId invasionOneTeensySuccess;
		public SmartLocId invasionTwoTeensySuccess;
		public SmartLocId invasionThreeTeensySuccess;
		public SmartLocId invasionScoreText;
		public SmartLocId invasionRecordText;
		public SmartLocId difficulty1;
		public SmartLocId difficulty2;
		public SmartLocId difficulty3;
		public SmartLocId difficulty4;
		public SmartLocId difficulty5;
		public Color unlockHighlightColor;
		public float unlockHighlightSize;
		public SmartLocId unitMeters;
		public SmartLocId unitKMeters;
		public SmartLocId unitPoints;
		public SmartLocId unitPoint;
		public SmartLocId unit0Points;
		public SmartLocId unitLums;
		public float syncMessageDelayMin;
		public float syncMessageDelayMax;
		public float syncMessageRestartDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				tombPath = s.SerializeObject<Path>(tombPath, name: "tombPath");
				tombIconPath = s.SerializeObject<Path>(tombIconPath, name: "tombIconPath");
				challengeEndDelay = s.Serialize<float>(challengeEndDelay, name: "challengeEndDelay");
				challengeEndDelayAfterDistanceSuccess = s.Serialize<float>(challengeEndDelayAfterDistanceSuccess, name: "challengeEndDelayAfterDistanceSuccess");
				saveDelayMin = s.Serialize<float>(saveDelayMin, name: "saveDelayMin");
				competitionsModes = s.SerializeObject<CListO<CompetitionModeInfo>>(competitionsModes, name: "competitionsModes");
				competitionsLevels = s.SerializeObject<CListO<CompetitionLevelInfo>>(competitionsLevels, name: "competitionsLevels");
				statsInfos = s.SerializeObject<CListO<StatInfos>>(statsInfos, name: "statsInfos");
				playerLevelInfos = s.SerializeObject<CListO<PlayerLevelInfos>>(playerLevelInfos, name: "playerLevelInfos");
				cupInfos = s.SerializeObject<CListO<CupInfos>>(cupInfos, name: "cupInfos");
				messages = s.SerializeObject<CListO<ITF.Message>>(messages, name: "messages");
				medalColors = s.SerializeObject<CArrayO<Color>>(medalColors, name: "medalColors");
				miiverseMenuSequenceNames = s.SerializeObject<CArrayO<StringID>>(miiverseMenuSequenceNames, name: "miiverseMenuSequenceNames");
				countryId = s.SerializeObject<CArrayP<int>>(countryId, name: "countryId");
				CompetitionFrequencyIcon_Daily = s.SerializeObject<Path>(CompetitionFrequencyIcon_Daily, name: "CompetitionFrequencyIcon_Daily");
				CompetitionFrequencyIcon_Weekly = s.SerializeObject<Path>(CompetitionFrequencyIcon_Weekly, name: "CompetitionFrequencyIcon_Weekly");
				CompetitionFrequencyIcon_Weekly_Expert = s.SerializeObject<Path>(CompetitionFrequencyIcon_Weekly_Expert, name: "CompetitionFrequencyIcon_Weekly_Expert");
				CompetitionFrequencyIcon_Daily_Expert = s.SerializeObject<Path>(CompetitionFrequencyIcon_Daily_Expert, name: "CompetitionFrequencyIcon_Daily_Expert");
				challengeFailedFX = s.SerializeObject<StringID>(challengeFailedFX, name: "challengeFailedFX");
				challengeSuccessFX = s.SerializeObject<StringID>(challengeSuccessFX, name: "challengeSuccessFX");
				challengeBestScoreFX = s.SerializeObject<StringID>(challengeBestScoreFX, name: "challengeBestScoreFX");
				challengeTimesUpText = s.SerializeObject<SmartLocId>(challengeTimesUpText, name: "challengeTimesUpText");
				legendsWorldUnlock = s.SerializeObject<SmartLocId>(legendsWorldUnlock, name: "legendsWorldUnlock");
				legendsWorldUnlockButton = s.SerializeObject<SmartLocId>(legendsWorldUnlockButton, name: "legendsWorldUnlockButton");
				legendsWorldUnlockButton2 = s.SerializeObject<SmartLocId>(legendsWorldUnlockButton2, name: "legendsWorldUnlockButton2");
				princessUnlock = s.SerializeObject<SmartLocId>(princessUnlock, name: "princessUnlock");
				worldUnlock = s.SerializeObject<SmartLocId>(worldUnlock, name: "worldUnlock");
				worldUnlockButton = s.SerializeObject<SmartLocId>(worldUnlockButton, name: "worldUnlockButton");
				levelUnlock = s.SerializeObject<SmartLocId>(levelUnlock, name: "levelUnlock");
				levelUnlockButton = s.SerializeObject<SmartLocId>(levelUnlockButton, name: "levelUnlockButton");
				retroLevelUnlock = s.SerializeObject<SmartLocId>(retroLevelUnlock, name: "retroLevelUnlock");
				retroLevelUnlockButton = s.SerializeObject<SmartLocId>(retroLevelUnlockButton, name: "retroLevelUnlockButton");
				petUnlock = s.SerializeObject<SmartLocId>(petUnlock, name: "petUnlock");
				petUnlockButton = s.SerializeObject<SmartLocId>(petUnlockButton, name: "petUnlockButton");
				costumeUnlock = s.SerializeObject<SmartLocId>(costumeUnlock, name: "costumeUnlock");
				costumeUnlockButton = s.SerializeObject<SmartLocId>(costumeUnlockButton, name: "costumeUnlockButton");
				challengeUnlock = s.SerializeObject<SmartLocId>(challengeUnlock, name: "challengeUnlock");
				challengeUnlockButton = s.SerializeObject<SmartLocId>(challengeUnlockButton, name: "challengeUnlockButton");
				invasionUnlock = s.SerializeObject<SmartLocId>(invasionUnlock, name: "invasionUnlock");
				invasionUnlockButton = s.SerializeObject<SmartLocId>(invasionUnlockButton, name: "invasionUnlockButton");
				invasionFailedTitle = s.SerializeObject<SmartLocId>(invasionFailedTitle, name: "invasionFailedTitle");
				invasionFailedText = s.SerializeObject<SmartLocId>(invasionFailedText, name: "invasionFailedText");
				invasionOneTeensySuccess = s.SerializeObject<SmartLocId>(invasionOneTeensySuccess, name: "invasionOneTeensySuccess");
				invasionTwoTeensySuccess = s.SerializeObject<SmartLocId>(invasionTwoTeensySuccess, name: "invasionTwoTeensySuccess");
				invasionThreeTeensySuccess = s.SerializeObject<SmartLocId>(invasionThreeTeensySuccess, name: "invasionThreeTeensySuccess");
				invasionScoreText = s.SerializeObject<SmartLocId>(invasionScoreText, name: "invasionScoreText");
				invasionRecordText = s.SerializeObject<SmartLocId>(invasionRecordText, name: "invasionRecordText");
				difficulty1 = s.SerializeObject<SmartLocId>(difficulty1, name: "difficulty1");
				difficulty2 = s.SerializeObject<SmartLocId>(difficulty2, name: "difficulty2");
				difficulty3 = s.SerializeObject<SmartLocId>(difficulty3, name: "difficulty3");
				difficulty4 = s.SerializeObject<SmartLocId>(difficulty4, name: "difficulty4");
				difficulty5 = s.SerializeObject<SmartLocId>(difficulty5, name: "difficulty5");
				unlockHighlightColor = s.SerializeObject<Color>(unlockHighlightColor, name: "unlockHighlightColor");
				unlockHighlightSize = s.Serialize<float>(unlockHighlightSize, name: "unlockHighlightSize");
				unitMeters = s.SerializeObject<SmartLocId>(unitMeters, name: "unitMeters");
				unitKMeters = s.SerializeObject<SmartLocId>(unitKMeters, name: "unitKMeters");
				unitPoints = s.SerializeObject<SmartLocId>(unitPoints, name: "unitPoints");
				unitPoint = s.SerializeObject<SmartLocId>(unitPoint, name: "unitPoint");
				unit0Points = s.SerializeObject<SmartLocId>(unit0Points, name: "unit0Points");
				unitLums = s.SerializeObject<SmartLocId>(unitLums, name: "unitLums");
				syncMessageDelayMin = s.Serialize<float>(syncMessageDelayMin, name: "syncMessageDelayMin");
				syncMessageDelayMax = s.Serialize<float>(syncMessageDelayMax, name: "syncMessageDelayMax");
				syncMessageRestartDelay = s.Serialize<float>(syncMessageRestartDelay, name: "syncMessageRestartDelay");
			} else {
				tombPath = s.SerializeObject<Path>(tombPath, name: "tombPath");
				tombIconPath = s.SerializeObject<Path>(tombIconPath, name: "tombIconPath");
				challengeEndDelay = s.Serialize<float>(challengeEndDelay, name: "challengeEndDelay");
				challengeEndDelayAfterDistanceSuccess = s.Serialize<float>(challengeEndDelayAfterDistanceSuccess, name: "challengeEndDelayAfterDistanceSuccess");
				saveDelayMin = s.Serialize<float>(saveDelayMin, name: "saveDelayMin");
				competitionsModes = s.SerializeObject<CListO<CompetitionModeInfo>>(competitionsModes, name: "competitionsModes");
				competitionsLevels = s.SerializeObject<CListO<CompetitionLevelInfo>>(competitionsLevels, name: "competitionsLevels");
				statsInfos = s.SerializeObject<CListO<StatInfos>>(statsInfos, name: "statsInfos");
				playerLevelInfos = s.SerializeObject<CListO<PlayerLevelInfos>>(playerLevelInfos, name: "playerLevelInfos");
				cupInfos = s.SerializeObject<CListO<CupInfos>>(cupInfos, name: "cupInfos");
				messagesAdventures = s.SerializeObject<CListO<online.Message>>(messagesAdventures, name: "messages");
				medalColors = s.SerializeObject<CArrayO<Color>>(medalColors, name: "medalColors");
				miiverseMenuSequenceNames = s.SerializeObject<CArrayO<StringID>>(miiverseMenuSequenceNames, name: "miiverseMenuSequenceNames");
				countryId = s.SerializeObject<CArrayP<int>>(countryId, name: "countryId");
				emblemDev = s.SerializeObject<Path>(emblemDev, name: "emblemDev");
				emblemVip = s.SerializeObject<Path>(emblemVip, name: "emblemVip");
				CompetitionFrequencyIcon_Daily = s.SerializeObject<Path>(CompetitionFrequencyIcon_Daily, name: "CompetitionFrequencyIcon_Daily");
				CompetitionFrequencyIcon_Weekly = s.SerializeObject<Path>(CompetitionFrequencyIcon_Weekly, name: "CompetitionFrequencyIcon_Weekly");
				CompetitionFrequencyIcon_Weekly_Expert = s.SerializeObject<Path>(CompetitionFrequencyIcon_Weekly_Expert, name: "CompetitionFrequencyIcon_Weekly_Expert");
				CompetitionFrequencyIcon_Daily_Expert = s.SerializeObject<Path>(CompetitionFrequencyIcon_Daily_Expert, name: "CompetitionFrequencyIcon_Daily_Expert");
				challengeFailedFX = s.SerializeObject<StringID>(challengeFailedFX, name: "challengeFailedFX");
				challengeSuccessFX = s.SerializeObject<StringID>(challengeSuccessFX, name: "challengeSuccessFX");
				challengeBestScoreFX = s.SerializeObject<StringID>(challengeBestScoreFX, name: "challengeBestScoreFX");
				challengeTimesUpText = s.SerializeObject<SmartLocId>(challengeTimesUpText, name: "challengeTimesUpText");
				legendsWorldUnlock = s.SerializeObject<SmartLocId>(legendsWorldUnlock, name: "legendsWorldUnlock");
				legendsWorldUnlockButton = s.SerializeObject<SmartLocId>(legendsWorldUnlockButton, name: "legendsWorldUnlockButton");
				legendsWorldUnlockButton2 = s.SerializeObject<SmartLocId>(legendsWorldUnlockButton2, name: "legendsWorldUnlockButton2");
				princessUnlock = s.SerializeObject<SmartLocId>(princessUnlock, name: "princessUnlock");
				worldUnlock = s.SerializeObject<SmartLocId>(worldUnlock, name: "worldUnlock");
				worldUnlockButton = s.SerializeObject<SmartLocId>(worldUnlockButton, name: "worldUnlockButton");
				levelUnlock = s.SerializeObject<SmartLocId>(levelUnlock, name: "levelUnlock");
				levelUnlockButton = s.SerializeObject<SmartLocId>(levelUnlockButton, name: "levelUnlockButton");
				retroLevelUnlock = s.SerializeObject<SmartLocId>(retroLevelUnlock, name: "retroLevelUnlock");
				retroLevelUnlockButton = s.SerializeObject<SmartLocId>(retroLevelUnlockButton, name: "retroLevelUnlockButton");
				petUnlock = s.SerializeObject<SmartLocId>(petUnlock, name: "petUnlock");
				petUnlockButton = s.SerializeObject<SmartLocId>(petUnlockButton, name: "petUnlockButton");
				costumeUnlock = s.SerializeObject<SmartLocId>(costumeUnlock, name: "costumeUnlock");
				costumeUnlockButton = s.SerializeObject<SmartLocId>(costumeUnlockButton, name: "costumeUnlockButton");
				challengeUnlock = s.SerializeObject<SmartLocId>(challengeUnlock, name: "challengeUnlock");
				challengeUnlockButton = s.SerializeObject<SmartLocId>(challengeUnlockButton, name: "challengeUnlockButton");
				invasionUnlock = s.SerializeObject<SmartLocId>(invasionUnlock, name: "invasionUnlock");
				invasionUnlockButton = s.SerializeObject<SmartLocId>(invasionUnlockButton, name: "invasionUnlockButton");
				invasionFailedTitle = s.SerializeObject<SmartLocId>(invasionFailedTitle, name: "invasionFailedTitle");
				invasionFailedText = s.SerializeObject<SmartLocId>(invasionFailedText, name: "invasionFailedText");
				invasionOneTeensySuccess = s.SerializeObject<SmartLocId>(invasionOneTeensySuccess, name: "invasionOneTeensySuccess");
				invasionTwoTeensySuccess = s.SerializeObject<SmartLocId>(invasionTwoTeensySuccess, name: "invasionTwoTeensySuccess");
				invasionThreeTeensySuccess = s.SerializeObject<SmartLocId>(invasionThreeTeensySuccess, name: "invasionThreeTeensySuccess");
				invasionScoreText = s.SerializeObject<SmartLocId>(invasionScoreText, name: "invasionScoreText");
				invasionRecordText = s.SerializeObject<SmartLocId>(invasionRecordText, name: "invasionRecordText");
				difficulty1 = s.SerializeObject<SmartLocId>(difficulty1, name: "difficulty1");
				difficulty2 = s.SerializeObject<SmartLocId>(difficulty2, name: "difficulty2");
				difficulty3 = s.SerializeObject<SmartLocId>(difficulty3, name: "difficulty3");
				difficulty4 = s.SerializeObject<SmartLocId>(difficulty4, name: "difficulty4");
				difficulty5 = s.SerializeObject<SmartLocId>(difficulty5, name: "difficulty5");
				unlockHighlightColor = s.SerializeObject<Color>(unlockHighlightColor, name: "unlockHighlightColor");
				unlockHighlightSize = s.Serialize<float>(unlockHighlightSize, name: "unlockHighlightSize");
				unitMeters = s.SerializeObject<SmartLocId>(unitMeters, name: "unitMeters");
				unitKMeters = s.SerializeObject<SmartLocId>(unitKMeters, name: "unitKMeters");
				unitPoints = s.SerializeObject<SmartLocId>(unitPoints, name: "unitPoints");
				unitPoint = s.SerializeObject<SmartLocId>(unitPoint, name: "unitPoint");
				unit0Points = s.SerializeObject<SmartLocId>(unit0Points, name: "unit0Points");
				unitLums = s.SerializeObject<SmartLocId>(unitLums, name: "unitLums");
				syncMessageDelayMin = s.Serialize<float>(syncMessageDelayMin, name: "syncMessageDelayMin");
				syncMessageDelayMax = s.Serialize<float>(syncMessageDelayMax, name: "syncMessageDelayMax");
				syncMessageRestartDelay = s.Serialize<float>(syncMessageRestartDelay, name: "syncMessageRestartDelay");
			}
		}
		public override uint? ClassCRC => 0xBF5E4832;
	}
}

