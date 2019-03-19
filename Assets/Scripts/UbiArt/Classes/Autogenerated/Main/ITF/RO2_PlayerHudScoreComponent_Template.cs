using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerHudScoreComponent_Template : GraphicComponent_Template {
		[Serialize("relativeWidth"                       )] public float relativeWidth;
		[Serialize("relativeSpacing"                     )] public float relativeSpacing;
		[Serialize("actualWidthPercent"                  )] public float actualWidthPercent;
		[Serialize("relativeAdditionalMargin"            )] public Margin relativeAdditionalMargin;
		[Serialize("pressToJoinRelativeAdditionalMargin" )] public Margin pressToJoinRelativeAdditionalMargin;
		[Serialize("homeAdditionalMargin"                )] public Margin homeAdditionalMargin;
		[Serialize("fadeInDuration"                      )] public float fadeInDuration;
		[Serialize("visibleDuration"                     )] public float visibleDuration;
		[Serialize("fadeOutDuration"                     )] public float fadeOutDuration;
		[Serialize("scorePos"                            )] public Vector2 scorePos;
		[Serialize("scoreSize"                           )] public Vector2 scoreSize;
		[Serialize("scoreColor"                          )] public Color scoreColor;
		[Serialize("lumBigIncreaseSpeed"                 )] public uint lumBigIncreaseSpeed;
		[Serialize("lumProgressiveBigIncreaseThreshold"  )] public uint lumProgressiveBigIncreaseThreshold;
		[Serialize("lumSmallIncreaseSpeed"               )] public uint lumSmallIncreaseSpeed;
		[Serialize("lumProgressiveSmallIncreaseThreshold")] public uint lumProgressiveSmallIncreaseThreshold;
		[Serialize("lumNormalScale"                      )] public float lumNormalScale;
		[Serialize("scoreMultiplierParticleID"           )] public StringID scoreMultiplierParticleID;
		[Serialize("scoreMultiplierValue"                )] public uint scoreMultiplierValue;
		[Serialize("pressStartHeight"                    )] public float pressStartHeight;
		[Serialize("pressStartPos"                       )] public Vector2 pressStartPos;
		[Serialize("grayedAlpha"                         )] public float grayedAlpha;
		[Serialize("idleAlpha"                           )] public float idleAlpha;
		[Serialize("leaveDRCTextID"                      )] public LocalisationId leaveDRCTextID;
		[Serialize("lumTexture"                          )] public Path lumTexture;
		[Serialize("lumMaterial"                         )] public GFXMaterialSerializable lumMaterial;
		[Serialize("lumBoxLocalPosition"                 )] public Vector2 lumBoxLocalPosition;
		[Serialize("lumBoxLocalSize"                     )] public Vector2 lumBoxLocalSize;
		[Serialize("headBoxLocalSize"                    )] public Vector2 headBoxLocalSize;
		[Serialize("pulseSustainDuration"                )] public float pulseSustainDuration;
		[Serialize("pulseScale"                          )] public float pulseScale;
		[Serialize("pulseIncreaseDuration"               )] public float pulseIncreaseDuration;
		[Serialize("pulseDecreaseDuration"               )] public float pulseDecreaseDuration;
		[Serialize("pulseDoublePeakDuration"             )] public float pulseDoublePeakDuration;
		[Serialize("pulseDoublePeakMinScale"             )] public float pulseDoublePeakMinScale;
		[Serialize("pulseCycleDuration_SingleLum"        )] public float pulseCycleDuration_SingleLum;
		[Serialize("pulseCycleDuration_MultipleLums"     )] public float pulseCycleDuration_MultipleLums;
		[Serialize("pressStartPulsePeriod"               )] public float pressStartPulsePeriod;
		[Serialize("pressStartFadeInDuration"            )] public float pressStartFadeInDuration;
		[Serialize("pressStartFadeOutDuration"           )] public float pressStartFadeOutDuration;
		[Serialize("pressStartMinAlpha"                  )] public float pressStartMinAlpha;
		[Serialize("pressStartMaxAlpha"                  )] public float pressStartMaxAlpha;
		[Serialize("pressStartTextID"                    )] public LocalisationId pressStartTextID;
		[Serialize("girlFriendModePulseDuration"         )] public float girlFriendModePulseDuration;
		[Serialize("girlFriendModeScorePosXOffset"       )] public float girlFriendModeScorePosXOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(relativeWidth));
				SerializeField(s, nameof(relativeSpacing));
				SerializeField(s, nameof(actualWidthPercent));
				SerializeField(s, nameof(relativeAdditionalMargin));
				SerializeField(s, nameof(pressToJoinRelativeAdditionalMargin));
				SerializeField(s, nameof(homeAdditionalMargin));
				SerializeField(s, nameof(fadeInDuration));
				SerializeField(s, nameof(visibleDuration));
				SerializeField(s, nameof(fadeOutDuration));
				SerializeField(s, nameof(scorePos));
				SerializeField(s, nameof(scoreSize));
				SerializeField(s, nameof(scoreColor));
				SerializeField(s, nameof(lumBigIncreaseSpeed));
				SerializeField(s, nameof(lumProgressiveBigIncreaseThreshold));
				SerializeField(s, nameof(lumSmallIncreaseSpeed));
				SerializeField(s, nameof(lumProgressiveSmallIncreaseThreshold));
				SerializeField(s, nameof(pulseSustainDuration));
				SerializeField(s, nameof(lumNormalScale));
				SerializeField(s, nameof(pulseScale));
				SerializeField(s, nameof(pulseIncreaseDuration));
				SerializeField(s, nameof(pulseDecreaseDuration));
				SerializeField(s, nameof(pulseDoublePeakDuration));
				SerializeField(s, nameof(pulseDoublePeakMinScale));
				SerializeField(s, nameof(pulseCycleDuration_SingleLum));
				SerializeField(s, nameof(pulseCycleDuration_MultipleLums));
				SerializeField(s, nameof(scoreMultiplierParticleID));
				SerializeField(s, nameof(scoreMultiplierValue));
				SerializeField(s, nameof(pressStartHeight));
				SerializeField(s, nameof(pressStartPos));
				SerializeField(s, nameof(grayedAlpha));
				SerializeField(s, nameof(idleAlpha));
				SerializeField(s, nameof(pressStartPulsePeriod));
				SerializeField(s, nameof(pressStartFadeInDuration));
				SerializeField(s, nameof(pressStartFadeOutDuration));
				SerializeField(s, nameof(pressStartMinAlpha));
				SerializeField(s, nameof(pressStartMaxAlpha));
				SerializeField(s, nameof(pressStartTextID));
				SerializeField(s, nameof(leaveDRCTextID));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(lumTexture));
				}
				SerializeField(s, nameof(lumMaterial));
				SerializeField(s, nameof(lumBoxLocalPosition));
				SerializeField(s, nameof(lumBoxLocalSize));
				SerializeField(s, nameof(headBoxLocalSize));
				SerializeField(s, nameof(girlFriendModePulseDuration));
				SerializeField(s, nameof(girlFriendModeScorePosXOffset));
			} else {
				SerializeField(s, nameof(relativeWidth));
				SerializeField(s, nameof(relativeSpacing));
				SerializeField(s, nameof(actualWidthPercent));
				SerializeField(s, nameof(relativeAdditionalMargin));
				SerializeField(s, nameof(pressToJoinRelativeAdditionalMargin));
				SerializeField(s, nameof(homeAdditionalMargin));
				SerializeField(s, nameof(fadeInDuration));
				SerializeField(s, nameof(visibleDuration));
				SerializeField(s, nameof(fadeOutDuration));
				SerializeField(s, nameof(scorePos));
				SerializeField(s, nameof(scoreSize));
				SerializeField(s, nameof(scoreColor));
				SerializeField(s, nameof(lumBigIncreaseSpeed));
				SerializeField(s, nameof(lumProgressiveBigIncreaseThreshold));
				SerializeField(s, nameof(lumSmallIncreaseSpeed));
				SerializeField(s, nameof(lumProgressiveSmallIncreaseThreshold));
				SerializeField(s, nameof(lumNormalScale));
				SerializeField(s, nameof(scoreMultiplierParticleID));
				SerializeField(s, nameof(scoreMultiplierValue));
				SerializeField(s, nameof(pressStartHeight));
				SerializeField(s, nameof(pressStartPos));
				SerializeField(s, nameof(grayedAlpha));
				SerializeField(s, nameof(idleAlpha));
				SerializeField(s, nameof(leaveDRCTextID));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(lumTexture));
				}
				SerializeField(s, nameof(lumMaterial));
				SerializeField(s, nameof(lumBoxLocalPosition));
				SerializeField(s, nameof(lumBoxLocalSize));
				SerializeField(s, nameof(headBoxLocalSize));
			}
		}
		public override uint? ClassCRC => 0xC71DEF17;
	}
}

