using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SeasonalEventManager_Template : TemplateObj {
		public RLC_SeasonalEventManager__eSeasonalEventType currentSeasonalEventID2;
		public online.DateTime currentSeasonalEventStartingTime2;
		public online.DateTime currentSeasonalEventEndingTime2;
		public online.DateTime currentSeasonalEventCompleteEndingTime2;
		public float findSeasonalCurrencyTeaseDuration;
		public float findSeasonalCurrencyTeaseCountdownMin;
		public float findSeasonalCurrencyTeaseCountdownMax;
		public Path addCurrencyFeedbackTextPath;
		public Path addChallengeWheelCurrencyFeedbackIconPath;
		public Path addEndlessRunnerCurrencyFeedbackIconPath;
		public Path addHuntCurrencyFeedbackIconPath;
		public float addCurrencyFeedbackTextDuration;
		public float addCurrencyFeedbackTextScale;
		public uint outOfPlayHoursBeforeNotification;
		public RLC_CurrencyPoolConfig currencyPoolConfigAdventure;
		public RLC_CurrencyPoolConfig currencyPoolConfigTree;
		public RLC_CurrencyPoolConfig currencyPoolConfigLevel;
		public bool EDITOR_ResetTracking;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			currentSeasonalEventID2 = s.Serialize<RLC_SeasonalEventManager__eSeasonalEventType>(currentSeasonalEventID2, name: "currentSeasonalEventID2");
			currentSeasonalEventStartingTime2 = s.SerializeObject<online.DateTime>(currentSeasonalEventStartingTime2, name: "currentSeasonalEventStartingTime2");
			currentSeasonalEventEndingTime2 = s.SerializeObject<online.DateTime>(currentSeasonalEventEndingTime2, name: "currentSeasonalEventEndingTime2");
			currentSeasonalEventCompleteEndingTime2 = s.SerializeObject<online.DateTime>(currentSeasonalEventCompleteEndingTime2, name: "currentSeasonalEventCompleteEndingTime2");
			findSeasonalCurrencyTeaseDuration = s.Serialize<float>(findSeasonalCurrencyTeaseDuration, name: "findSeasonalCurrencyTeaseDuration");
			findSeasonalCurrencyTeaseCountdownMin = s.Serialize<float>(findSeasonalCurrencyTeaseCountdownMin, name: "findSeasonalCurrencyTeaseCountdownMin");
			findSeasonalCurrencyTeaseCountdownMax = s.Serialize<float>(findSeasonalCurrencyTeaseCountdownMax, name: "findSeasonalCurrencyTeaseCountdownMax");
			addCurrencyFeedbackTextPath = s.SerializeObject<Path>(addCurrencyFeedbackTextPath, name: "addCurrencyFeedbackTextPath");
			addChallengeWheelCurrencyFeedbackIconPath = s.SerializeObject<Path>(addChallengeWheelCurrencyFeedbackIconPath, name: "addChallengeWheelCurrencyFeedbackIconPath");
			addEndlessRunnerCurrencyFeedbackIconPath = s.SerializeObject<Path>(addEndlessRunnerCurrencyFeedbackIconPath, name: "addEndlessRunnerCurrencyFeedbackIconPath");
			addHuntCurrencyFeedbackIconPath = s.SerializeObject<Path>(addHuntCurrencyFeedbackIconPath, name: "addHuntCurrencyFeedbackIconPath");
			addCurrencyFeedbackTextDuration = s.Serialize<float>(addCurrencyFeedbackTextDuration, name: "addCurrencyFeedbackTextDuration");
			addCurrencyFeedbackTextScale = s.Serialize<float>(addCurrencyFeedbackTextScale, name: "addCurrencyFeedbackTextScale");
			outOfPlayHoursBeforeNotification = s.Serialize<uint>(outOfPlayHoursBeforeNotification, name: "outOfPlayHoursBeforeNotification");
			currencyPoolConfigAdventure = s.SerializeObject<RLC_CurrencyPoolConfig>(currencyPoolConfigAdventure, name: "currencyPoolConfigAdventure");
			currencyPoolConfigTree = s.SerializeObject<RLC_CurrencyPoolConfig>(currencyPoolConfigTree, name: "currencyPoolConfigTree");
			currencyPoolConfigLevel = s.SerializeObject<RLC_CurrencyPoolConfig>(currencyPoolConfigLevel, name: "currencyPoolConfigLevel");
			EDITOR_ResetTracking = s.Serialize<bool>(EDITOR_ResetTracking, name: "EDITOR_ResetTracking");
		}
		public enum RLC_SeasonalEventManager__eSeasonalEventType {
			[Serialize("RLC_SeasonalEventManager::eSeasonalEventType::None"               )] None = 0,
			[Serialize("RLC_SeasonalEventManager::eSeasonalEventType::ChallengeWheelEvent")] ChallengeWheelEvent = 1,
			[Serialize("RLC_SeasonalEventManager::eSeasonalEventType::EndlessRunnerEvent" )] EndlessRunnerEvent = 2,
			[Serialize("RLC_SeasonalEventManager::eSeasonalEventType::HuntEvent"          )] HuntEvent = 3,
		}
		public override uint? ClassCRC => 0x7DF89048;
	}
}

