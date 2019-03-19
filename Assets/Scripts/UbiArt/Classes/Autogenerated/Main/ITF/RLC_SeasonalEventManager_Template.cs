using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SeasonalEventManager_Template : TemplateObj {
		[Serialize("currentSeasonalEventID2"                  )] public RLC_SeasonalEventManager__eSeasonalEventType currentSeasonalEventID2;
		[Serialize("currentSeasonalEventStartingTime2"        )] public online.DateTime currentSeasonalEventStartingTime2;
		[Serialize("currentSeasonalEventEndingTime2"          )] public online.DateTime currentSeasonalEventEndingTime2;
		[Serialize("currentSeasonalEventCompleteEndingTime2"  )] public online.DateTime currentSeasonalEventCompleteEndingTime2;
		[Serialize("findSeasonalCurrencyTeaseDuration"        )] public float findSeasonalCurrencyTeaseDuration;
		[Serialize("findSeasonalCurrencyTeaseCountdownMin"    )] public float findSeasonalCurrencyTeaseCountdownMin;
		[Serialize("findSeasonalCurrencyTeaseCountdownMax"    )] public float findSeasonalCurrencyTeaseCountdownMax;
		[Serialize("addCurrencyFeedbackTextPath"              )] public Path addCurrencyFeedbackTextPath;
		[Serialize("addChallengeWheelCurrencyFeedbackIconPath")] public Path addChallengeWheelCurrencyFeedbackIconPath;
		[Serialize("addEndlessRunnerCurrencyFeedbackIconPath" )] public Path addEndlessRunnerCurrencyFeedbackIconPath;
		[Serialize("addHuntCurrencyFeedbackIconPath"          )] public Path addHuntCurrencyFeedbackIconPath;
		[Serialize("addCurrencyFeedbackTextDuration"          )] public float addCurrencyFeedbackTextDuration;
		[Serialize("addCurrencyFeedbackTextScale"             )] public float addCurrencyFeedbackTextScale;
		[Serialize("outOfPlayHoursBeforeNotification"         )] public uint outOfPlayHoursBeforeNotification;
		[Serialize("currencyPoolConfigAdventure"              )] public RLC_CurrencyPoolConfig currencyPoolConfigAdventure;
		[Serialize("currencyPoolConfigTree"                   )] public RLC_CurrencyPoolConfig currencyPoolConfigTree;
		[Serialize("currencyPoolConfigLevel"                  )] public RLC_CurrencyPoolConfig currencyPoolConfigLevel;
		[Serialize("EDITOR_ResetTracking"                     )] public bool EDITOR_ResetTracking;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(currentSeasonalEventID2));
			SerializeField(s, nameof(currentSeasonalEventStartingTime2));
			SerializeField(s, nameof(currentSeasonalEventEndingTime2));
			SerializeField(s, nameof(currentSeasonalEventCompleteEndingTime2));
			SerializeField(s, nameof(findSeasonalCurrencyTeaseDuration));
			SerializeField(s, nameof(findSeasonalCurrencyTeaseCountdownMin));
			SerializeField(s, nameof(findSeasonalCurrencyTeaseCountdownMax));
			SerializeField(s, nameof(addCurrencyFeedbackTextPath));
			SerializeField(s, nameof(addChallengeWheelCurrencyFeedbackIconPath));
			SerializeField(s, nameof(addEndlessRunnerCurrencyFeedbackIconPath));
			SerializeField(s, nameof(addHuntCurrencyFeedbackIconPath));
			SerializeField(s, nameof(addCurrencyFeedbackTextDuration));
			SerializeField(s, nameof(addCurrencyFeedbackTextScale));
			SerializeField(s, nameof(outOfPlayHoursBeforeNotification));
			SerializeField(s, nameof(currencyPoolConfigAdventure));
			SerializeField(s, nameof(currencyPoolConfigTree));
			SerializeField(s, nameof(currencyPoolConfigLevel));
			SerializeField(s, nameof(EDITOR_ResetTracking));
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

