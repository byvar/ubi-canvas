using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LuckyTicketComponent_Template : ActorComponent_Template {
		public Path regionPath;
		public Vec2d startPos;
		public float lineHeight;
		public float columnWidth;
		public float revealedCoef;
		public uint teensyRandomCoef;
		public int lumsThreshold_4;
		public int lumsThreshold_5;
		public int lumsThreshold_6;
		public uint lumsThreshold_3_RandomCoef;
		public uint lumsThreshold_4_RandomCoef;
		public uint lumsThreshold_5_RandomCoef;
		public uint lumsThreshold_6_RandomCoef;
		public uint frameRandomCoef;
		public uint petRandomCoef;
		public Path teensyIconPath;
		public Path petIconPath;
		public Path frameIconPath;
		public Path lumIconPath;
		public Vec2d teensyIconOffset;
		public Vec2d petIconOffset;
		public Vec2d frameIconOffset;
		public Vec2d lumIconOffset;
		public StringID iconAnimStand;
		public StringID iconAnimRevealed;
		public float hideMenuCoef;
		public uint petRewardCount;
		public uint teensyRewardCount;
		public uint lums_3_RewardCount;
		public uint lums_4_RewardCount;
		public uint lums_5_RewardCount;
		public uint lums_6_RewardCount;
		public uint frameRewardCount;
		public float fadeToBlackDuration;
		public float rewardIconOffsetWidth;
		public float rewardIconOffsetHeight;
		public float speedBlend;
		public float speedMin;
		public float speedMax;
		public float blendAtSpeedMin;
		public float blendAtSpeedMax;
		public Path dalleFramePath;
		public Path dalleLumPath;
		public Path dalleNeutralPath;
		public Path dallePetPath;
		public Path dalleTeensyPath;
		public float iconFadeAlpha;
		public float dalleFadeAlpha;
		public StringID cameraFX;
		public StringID fireworkFX;
		public CArray<Vec3d> fireworksOffsets;
		public float minTimeBetweenFireworks;
		public float maxTimeBetweenFireworks;
		public Color iconFadeColor;
		public float timeBetweenRewardIconMove;
		public uint looseRandomCoef;
		public CList<RO2_LTReward> rewardsOrder;
		public Path debugRewardFilePath;
		public float delayBeforeReward;
		public float digShapeRadiusSpeed;
		public float scratchStopTime;
		public float scratchAccelTime;
		public float scratchMinSpeed;
		public float scratchMaxSpeed;
		public float scratchStepSpeed;
		public float scratchAcceleration;
		public float scratchDeceleration;
		public bool scratchShapeEnabled;
		public Generic<Event> musicEnterEvent;
		public Generic<Event> musicWinEvent;
		public Generic<Event> musicStopEvent;
		public float textRewardScaleStart;
		public float textRewardScaleEnd;
		public float textRewardScaleDuration;
		public float textRewardAlphaStart;
		public float textRewardAlphaEnd;
		public float textRewardAlphaDuration;
		public float textRewardTypeDelay;
		public float murphyFingerFadeOutDuration;
		public float textRewardDelay;
		public float screenDarkerAlphaStart;
		public float screenDarkerAlphaEnd;
		public float screenDarkerAlphaStartDuration;
		public float screenDarkerAlphaEndDuration;
		public float iconFadeOutDuration;
		public float iconFadeInDelay;
		public float iconFadeInDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				regionPath = s.SerializeObject<Path>(regionPath, name: "regionPath");
				startPos = s.SerializeObject<Vec2d>(startPos, name: "startPos");
				lineHeight = s.Serialize<float>(lineHeight, name: "lineHeight");
				columnWidth = s.Serialize<float>(columnWidth, name: "columnWidth");
				revealedCoef = s.Serialize<float>(revealedCoef, name: "revealedCoef");
				teensyRandomCoef = s.Serialize<uint>(teensyRandomCoef, name: "teensyRandomCoef");
				lumsThreshold_4 = s.Serialize<int>(lumsThreshold_4, name: "lumsThreshold_4");
				lumsThreshold_5 = s.Serialize<int>(lumsThreshold_5, name: "lumsThreshold_5");
				lumsThreshold_6 = s.Serialize<int>(lumsThreshold_6, name: "lumsThreshold_6");
				lumsThreshold_3_RandomCoef = s.Serialize<uint>(lumsThreshold_3_RandomCoef, name: "lumsThreshold_3_RandomCoef");
				lumsThreshold_4_RandomCoef = s.Serialize<uint>(lumsThreshold_4_RandomCoef, name: "lumsThreshold_4_RandomCoef");
				lumsThreshold_5_RandomCoef = s.Serialize<uint>(lumsThreshold_5_RandomCoef, name: "lumsThreshold_5_RandomCoef");
				lumsThreshold_6_RandomCoef = s.Serialize<uint>(lumsThreshold_6_RandomCoef, name: "lumsThreshold_6_RandomCoef");
				frameRandomCoef = s.Serialize<uint>(frameRandomCoef, name: "frameRandomCoef");
				petRandomCoef = s.Serialize<uint>(petRandomCoef, name: "petRandomCoef");
				teensyIconPath = s.SerializeObject<Path>(teensyIconPath, name: "teensyIconPath");
				petIconPath = s.SerializeObject<Path>(petIconPath, name: "petIconPath");
				frameIconPath = s.SerializeObject<Path>(frameIconPath, name: "frameIconPath");
				lumIconPath = s.SerializeObject<Path>(lumIconPath, name: "lumIconPath");
				teensyIconOffset = s.SerializeObject<Vec2d>(teensyIconOffset, name: "teensyIconOffset");
				petIconOffset = s.SerializeObject<Vec2d>(petIconOffset, name: "petIconOffset");
				frameIconOffset = s.SerializeObject<Vec2d>(frameIconOffset, name: "frameIconOffset");
				lumIconOffset = s.SerializeObject<Vec2d>(lumIconOffset, name: "lumIconOffset");
				iconAnimStand = s.SerializeObject<StringID>(iconAnimStand, name: "iconAnimStand");
				iconAnimRevealed = s.SerializeObject<StringID>(iconAnimRevealed, name: "iconAnimRevealed");
				hideMenuCoef = s.Serialize<float>(hideMenuCoef, name: "hideMenuCoef");
				petRewardCount = s.Serialize<uint>(petRewardCount, name: "petRewardCount");
				teensyRewardCount = s.Serialize<uint>(teensyRewardCount, name: "teensyRewardCount");
				lums_3_RewardCount = s.Serialize<uint>(lums_3_RewardCount, name: "lums_3_RewardCount");
				lums_4_RewardCount = s.Serialize<uint>(lums_4_RewardCount, name: "lums_4_RewardCount");
				lums_5_RewardCount = s.Serialize<uint>(lums_5_RewardCount, name: "lums_5_RewardCount");
				lums_6_RewardCount = s.Serialize<uint>(lums_6_RewardCount, name: "lums_6_RewardCount");
				frameRewardCount = s.Serialize<uint>(frameRewardCount, name: "frameRewardCount");
				musicEnterEvent = s.SerializeObject<Generic<Event>>(musicEnterEvent, name: "musicEnterEvent");
				musicWinEvent = s.SerializeObject<Generic<Event>>(musicWinEvent, name: "musicWinEvent");
				musicStopEvent = s.SerializeObject<Generic<Event>>(musicStopEvent, name: "musicStopEvent");
				fadeToBlackDuration = s.Serialize<float>(fadeToBlackDuration, name: "fadeToBlackDuration");
				rewardIconOffsetWidth = s.Serialize<float>(rewardIconOffsetWidth, name: "rewardIconOffsetWidth");
				rewardIconOffsetHeight = s.Serialize<float>(rewardIconOffsetHeight, name: "rewardIconOffsetHeight");
				speedBlend = s.Serialize<float>(speedBlend, name: "speedBlend");
				speedMin = s.Serialize<float>(speedMin, name: "speedMin");
				speedMax = s.Serialize<float>(speedMax, name: "speedMax");
				blendAtSpeedMin = s.Serialize<float>(blendAtSpeedMin, name: "blendAtSpeedMin");
				blendAtSpeedMax = s.Serialize<float>(blendAtSpeedMax, name: "blendAtSpeedMax");
				dalleFramePath = s.SerializeObject<Path>(dalleFramePath, name: "dalleFramePath");
				dalleLumPath = s.SerializeObject<Path>(dalleLumPath, name: "dalleLumPath");
				dalleNeutralPath = s.SerializeObject<Path>(dalleNeutralPath, name: "dalleNeutralPath");
				dallePetPath = s.SerializeObject<Path>(dallePetPath, name: "dallePetPath");
				dalleTeensyPath = s.SerializeObject<Path>(dalleTeensyPath, name: "dalleTeensyPath");
				iconFadeAlpha = s.Serialize<float>(iconFadeAlpha, name: "iconFadeAlpha");
				dalleFadeAlpha = s.Serialize<float>(dalleFadeAlpha, name: "dalleFadeAlpha");
				cameraFX = s.SerializeObject<StringID>(cameraFX, name: "cameraFX");
				fireworkFX = s.SerializeObject<StringID>(fireworkFX, name: "fireworkFX");
				fireworksOffsets = s.SerializeObject<CArray<Vec3d>>(fireworksOffsets, name: "fireworksOffsets");
				minTimeBetweenFireworks = s.Serialize<float>(minTimeBetweenFireworks, name: "minTimeBetweenFireworks");
				maxTimeBetweenFireworks = s.Serialize<float>(maxTimeBetweenFireworks, name: "maxTimeBetweenFireworks");
				iconFadeColor = s.SerializeObject<Color>(iconFadeColor, name: "iconFadeColor");
				timeBetweenRewardIconMove = s.Serialize<float>(timeBetweenRewardIconMove, name: "timeBetweenRewardIconMove");
				looseRandomCoef = s.Serialize<uint>(looseRandomCoef, name: "looseRandomCoef");
				rewardsOrder = s.SerializeObject<CList<RO2_LTReward>>(rewardsOrder, name: "rewardsOrder");
				debugRewardFilePath = s.SerializeObject<Path>(debugRewardFilePath, name: "debugRewardFilePath");
				delayBeforeReward = s.Serialize<float>(delayBeforeReward, name: "delayBeforeReward");
				digShapeRadiusSpeed = s.Serialize<float>(digShapeRadiusSpeed, name: "digShapeRadiusSpeed");
				scratchStopTime = s.Serialize<float>(scratchStopTime, name: "scratchStopTime");
				scratchAccelTime = s.Serialize<float>(scratchAccelTime, name: "scratchAccelTime");
				scratchMinSpeed = s.Serialize<float>(scratchMinSpeed, name: "scratchMinSpeed");
				scratchMaxSpeed = s.Serialize<float>(scratchMaxSpeed, name: "scratchMaxSpeed");
				scratchStepSpeed = s.Serialize<float>(scratchStepSpeed, name: "scratchStepSpeed");
				scratchAcceleration = s.Serialize<float>(scratchAcceleration, name: "scratchAcceleration");
				scratchDeceleration = s.Serialize<float>(scratchDeceleration, name: "scratchDeceleration");
				scratchShapeEnabled = s.Serialize<bool>(scratchShapeEnabled, name: "scratchShapeEnabled");
				textRewardScaleStart = s.Serialize<float>(textRewardScaleStart, name: "textRewardScaleStart");
				textRewardScaleEnd = s.Serialize<float>(textRewardScaleEnd, name: "textRewardScaleEnd");
				textRewardScaleDuration = s.Serialize<float>(textRewardScaleDuration, name: "textRewardScaleDuration");
				textRewardAlphaStart = s.Serialize<float>(textRewardAlphaStart, name: "textRewardAlphaStart");
				textRewardAlphaEnd = s.Serialize<float>(textRewardAlphaEnd, name: "textRewardAlphaEnd");
				textRewardAlphaDuration = s.Serialize<float>(textRewardAlphaDuration, name: "textRewardAlphaDuration");
				textRewardTypeDelay = s.Serialize<float>(textRewardTypeDelay, name: "textRewardTypeDelay");
				murphyFingerFadeOutDuration = s.Serialize<float>(murphyFingerFadeOutDuration, name: "murphyFingerFadeOutDuration");
				textRewardDelay = s.Serialize<float>(textRewardDelay, name: "textRewardDelay");
				screenDarkerAlphaStart = s.Serialize<float>(screenDarkerAlphaStart, name: "screenDarkerAlphaStart");
				screenDarkerAlphaEnd = s.Serialize<float>(screenDarkerAlphaEnd, name: "screenDarkerAlphaEnd");
				screenDarkerAlphaStartDuration = s.Serialize<float>(screenDarkerAlphaStartDuration, name: "screenDarkerAlphaStartDuration");
				screenDarkerAlphaEndDuration = s.Serialize<float>(screenDarkerAlphaEndDuration, name: "screenDarkerAlphaEndDuration");
				iconFadeOutDuration = s.Serialize<float>(iconFadeOutDuration, name: "iconFadeOutDuration");
				iconFadeInDelay = s.Serialize<float>(iconFadeInDelay, name: "iconFadeInDelay");
				iconFadeInDuration = s.Serialize<float>(iconFadeInDuration, name: "iconFadeInDuration");
			} else {
				regionPath = s.SerializeObject<Path>(regionPath, name: "regionPath");
				startPos = s.SerializeObject<Vec2d>(startPos, name: "startPos");
				lineHeight = s.Serialize<float>(lineHeight, name: "lineHeight");
				columnWidth = s.Serialize<float>(columnWidth, name: "columnWidth");
				revealedCoef = s.Serialize<float>(revealedCoef, name: "revealedCoef");
				teensyRandomCoef = s.Serialize<uint>(teensyRandomCoef, name: "teensyRandomCoef");
				lumsThreshold_4 = s.Serialize<int>(lumsThreshold_4, name: "lumsThreshold_4");
				lumsThreshold_5 = s.Serialize<int>(lumsThreshold_5, name: "lumsThreshold_5");
				lumsThreshold_6 = s.Serialize<int>(lumsThreshold_6, name: "lumsThreshold_6");
				lumsThreshold_3_RandomCoef = s.Serialize<uint>(lumsThreshold_3_RandomCoef, name: "lumsThreshold_3_RandomCoef");
				lumsThreshold_4_RandomCoef = s.Serialize<uint>(lumsThreshold_4_RandomCoef, name: "lumsThreshold_4_RandomCoef");
				lumsThreshold_5_RandomCoef = s.Serialize<uint>(lumsThreshold_5_RandomCoef, name: "lumsThreshold_5_RandomCoef");
				lumsThreshold_6_RandomCoef = s.Serialize<uint>(lumsThreshold_6_RandomCoef, name: "lumsThreshold_6_RandomCoef");
				frameRandomCoef = s.Serialize<uint>(frameRandomCoef, name: "frameRandomCoef");
				petRandomCoef = s.Serialize<uint>(petRandomCoef, name: "petRandomCoef");
				teensyIconPath = s.SerializeObject<Path>(teensyIconPath, name: "teensyIconPath");
				petIconPath = s.SerializeObject<Path>(petIconPath, name: "petIconPath");
				frameIconPath = s.SerializeObject<Path>(frameIconPath, name: "frameIconPath");
				lumIconPath = s.SerializeObject<Path>(lumIconPath, name: "lumIconPath");
				teensyIconOffset = s.SerializeObject<Vec2d>(teensyIconOffset, name: "teensyIconOffset");
				petIconOffset = s.SerializeObject<Vec2d>(petIconOffset, name: "petIconOffset");
				frameIconOffset = s.SerializeObject<Vec2d>(frameIconOffset, name: "frameIconOffset");
				lumIconOffset = s.SerializeObject<Vec2d>(lumIconOffset, name: "lumIconOffset");
				iconAnimStand = s.SerializeObject<StringID>(iconAnimStand, name: "iconAnimStand");
				iconAnimRevealed = s.SerializeObject<StringID>(iconAnimRevealed, name: "iconAnimRevealed");
				hideMenuCoef = s.Serialize<float>(hideMenuCoef, name: "hideMenuCoef");
				petRewardCount = s.Serialize<uint>(petRewardCount, name: "petRewardCount");
				teensyRewardCount = s.Serialize<uint>(teensyRewardCount, name: "teensyRewardCount");
				lums_3_RewardCount = s.Serialize<uint>(lums_3_RewardCount, name: "lums_3_RewardCount");
				lums_4_RewardCount = s.Serialize<uint>(lums_4_RewardCount, name: "lums_4_RewardCount");
				lums_5_RewardCount = s.Serialize<uint>(lums_5_RewardCount, name: "lums_5_RewardCount");
				lums_6_RewardCount = s.Serialize<uint>(lums_6_RewardCount, name: "lums_6_RewardCount");
				frameRewardCount = s.Serialize<uint>(frameRewardCount, name: "frameRewardCount");
				fadeToBlackDuration = s.Serialize<float>(fadeToBlackDuration, name: "fadeToBlackDuration");
				rewardIconOffsetWidth = s.Serialize<float>(rewardIconOffsetWidth, name: "rewardIconOffsetWidth");
				rewardIconOffsetHeight = s.Serialize<float>(rewardIconOffsetHeight, name: "rewardIconOffsetHeight");
				speedBlend = s.Serialize<float>(speedBlend, name: "speedBlend");
				speedMin = s.Serialize<float>(speedMin, name: "speedMin");
				speedMax = s.Serialize<float>(speedMax, name: "speedMax");
				blendAtSpeedMin = s.Serialize<float>(blendAtSpeedMin, name: "blendAtSpeedMin");
				blendAtSpeedMax = s.Serialize<float>(blendAtSpeedMax, name: "blendAtSpeedMax");
				dalleFramePath = s.SerializeObject<Path>(dalleFramePath, name: "dalleFramePath");
				dalleLumPath = s.SerializeObject<Path>(dalleLumPath, name: "dalleLumPath");
				dalleNeutralPath = s.SerializeObject<Path>(dalleNeutralPath, name: "dalleNeutralPath");
				dallePetPath = s.SerializeObject<Path>(dallePetPath, name: "dallePetPath");
				dalleTeensyPath = s.SerializeObject<Path>(dalleTeensyPath, name: "dalleTeensyPath");
				iconFadeAlpha = s.Serialize<float>(iconFadeAlpha, name: "iconFadeAlpha");
				dalleFadeAlpha = s.Serialize<float>(dalleFadeAlpha, name: "dalleFadeAlpha");
				cameraFX = s.SerializeObject<StringID>(cameraFX, name: "cameraFX");
				fireworkFX = s.SerializeObject<StringID>(fireworkFX, name: "fireworkFX");
				fireworksOffsets = s.SerializeObject<CArray<Vec3d>>(fireworksOffsets, name: "fireworksOffsets");
				fireworksOffsets = s.SerializeObject<CArray<Vec3d>>(fireworksOffsets, name: "fireworksOffsets");
				minTimeBetweenFireworks = s.Serialize<float>(minTimeBetweenFireworks, name: "minTimeBetweenFireworks");
				maxTimeBetweenFireworks = s.Serialize<float>(maxTimeBetweenFireworks, name: "maxTimeBetweenFireworks");
				iconFadeColor = s.SerializeObject<Color>(iconFadeColor, name: "iconFadeColor");
				timeBetweenRewardIconMove = s.Serialize<float>(timeBetweenRewardIconMove, name: "timeBetweenRewardIconMove");
				looseRandomCoef = s.Serialize<uint>(looseRandomCoef, name: "looseRandomCoef");
				rewardsOrder = s.SerializeObject<CList<RO2_LTReward>>(rewardsOrder, name: "rewardsOrder");
				debugRewardFilePath = s.SerializeObject<Path>(debugRewardFilePath, name: "debugRewardFilePath");
				delayBeforeReward = s.Serialize<float>(delayBeforeReward, name: "delayBeforeReward");
				digShapeRadiusSpeed = s.Serialize<float>(digShapeRadiusSpeed, name: "digShapeRadiusSpeed");
				scratchStopTime = s.Serialize<float>(scratchStopTime, name: "scratchStopTime");
				scratchAccelTime = s.Serialize<float>(scratchAccelTime, name: "scratchAccelTime");
				scratchMinSpeed = s.Serialize<float>(scratchMinSpeed, name: "scratchMinSpeed");
				scratchMaxSpeed = s.Serialize<float>(scratchMaxSpeed, name: "scratchMaxSpeed");
				scratchStepSpeed = s.Serialize<float>(scratchStepSpeed, name: "scratchStepSpeed");
				scratchAcceleration = s.Serialize<float>(scratchAcceleration, name: "scratchAcceleration");
				scratchDeceleration = s.Serialize<float>(scratchDeceleration, name: "scratchDeceleration");
				scratchShapeEnabled = s.Serialize<bool>(scratchShapeEnabled, name: "scratchShapeEnabled");
			}
		}
		public override uint? ClassCRC => 0x24B33A58;
	}
}

