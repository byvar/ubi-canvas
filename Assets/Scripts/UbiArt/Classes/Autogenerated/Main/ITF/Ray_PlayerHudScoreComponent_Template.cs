using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerHudScoreComponent_Template : GraphicComponent_Template {
		public float relativeWidth;
		public float relativeSpacing;
		public float actualWidthPercent;
		public Placeholder relativeAdditionalMargin;
		public Placeholder pressToJoinRelativeAdditionalMargin;
		public float fadeInDuration;
		public float visibleDuration;
		public float fadeOutDuration;
		public Path fontName;
		public Vec2d scorePos;
		public Vec2d scoreSize;
		public Color scoreColor;
		public uint lumBigIncreaseSpeed;
		public uint lumProgressiveBigIncreaseThreshold;
		public uint lumSmallIncreaseSpeed;
		public uint lumProgressiveSmallIncreaseThreshold;
		public float pulseSustainDuration;
		public float lumNormalScale;
		public float pulseScale;
		public float pulseIncreaseDuration;
		public float pulseDecreaseDuration;
		public float pulseDoublePeakDuration;
		public float pulseDoublePeakMinScale;
		public float pulseCycleDuration_SingleLum;
		public float pulseCycleDuration_MultipleLums;
		public StringID scoreMultiplierParticleID;
		public uint scoreMultiplierValue;
		public float pressStartHeight;
		public Vec2d pressStartPos;
		public Path pressStartFontName;
		public float grayedAlpha;
		public float idleAlpha;
		public float pressStartPulsePeriod;
		public float pressStartFadeInDuration;
		public float pressStartFadeOutDuration;
		public float pressStartMinAlpha;
		public float pressStartMaxAlpha;
		public LocalisationId pressStartTextID;
		public Path lumTexture;
		public Path characterTexture;
		public Vec2d lumBoxLocalPosition;
		public Vec2d lumBoxLocalSize;
		public Vec2d headBoxLocalSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			relativeWidth = s.Serialize<float>(relativeWidth, name: "relativeWidth");
			relativeSpacing = s.Serialize<float>(relativeSpacing, name: "relativeSpacing");
			actualWidthPercent = s.Serialize<float>(actualWidthPercent, name: "actualWidthPercent");
			relativeAdditionalMargin = s.SerializeObject<Placeholder>(relativeAdditionalMargin, name: "relativeAdditionalMargin");
			pressToJoinRelativeAdditionalMargin = s.SerializeObject<Placeholder>(pressToJoinRelativeAdditionalMargin, name: "pressToJoinRelativeAdditionalMargin");
			fadeInDuration = s.Serialize<float>(fadeInDuration, name: "fadeInDuration");
			visibleDuration = s.Serialize<float>(visibleDuration, name: "visibleDuration");
			fadeOutDuration = s.Serialize<float>(fadeOutDuration, name: "fadeOutDuration");
			fontName = s.SerializeObject<Path>(fontName, name: "fontName");
			scorePos = s.SerializeObject<Vec2d>(scorePos, name: "scorePos");
			scoreSize = s.SerializeObject<Vec2d>(scoreSize, name: "scoreSize");
			scoreColor = s.SerializeObject<Color>(scoreColor, name: "scoreColor");
			lumBigIncreaseSpeed = s.Serialize<uint>(lumBigIncreaseSpeed, name: "lumBigIncreaseSpeed");
			lumProgressiveBigIncreaseThreshold = s.Serialize<uint>(lumProgressiveBigIncreaseThreshold, name: "lumProgressiveBigIncreaseThreshold");
			lumSmallIncreaseSpeed = s.Serialize<uint>(lumSmallIncreaseSpeed, name: "lumSmallIncreaseSpeed");
			lumProgressiveSmallIncreaseThreshold = s.Serialize<uint>(lumProgressiveSmallIncreaseThreshold, name: "lumProgressiveSmallIncreaseThreshold");
			pulseSustainDuration = s.Serialize<float>(pulseSustainDuration, name: "pulseSustainDuration");
			lumNormalScale = s.Serialize<float>(lumNormalScale, name: "lumNormalScale");
			pulseScale = s.Serialize<float>(pulseScale, name: "pulseScale");
			pulseIncreaseDuration = s.Serialize<float>(pulseIncreaseDuration, name: "pulseIncreaseDuration");
			pulseDecreaseDuration = s.Serialize<float>(pulseDecreaseDuration, name: "pulseDecreaseDuration");
			pulseDoublePeakDuration = s.Serialize<float>(pulseDoublePeakDuration, name: "pulseDoublePeakDuration");
			pulseDoublePeakMinScale = s.Serialize<float>(pulseDoublePeakMinScale, name: "pulseDoublePeakMinScale");
			pulseCycleDuration_SingleLum = s.Serialize<float>(pulseCycleDuration_SingleLum, name: "pulseCycleDuration_SingleLum");
			pulseCycleDuration_MultipleLums = s.Serialize<float>(pulseCycleDuration_MultipleLums, name: "pulseCycleDuration_MultipleLums");
			scoreMultiplierParticleID = s.SerializeObject<StringID>(scoreMultiplierParticleID, name: "scoreMultiplierParticleID");
			scoreMultiplierValue = s.Serialize<uint>(scoreMultiplierValue, name: "scoreMultiplierValue");
			pressStartHeight = s.Serialize<float>(pressStartHeight, name: "pressStartHeight");
			pressStartPos = s.SerializeObject<Vec2d>(pressStartPos, name: "pressStartPos");
			pressStartFontName = s.SerializeObject<Path>(pressStartFontName, name: "pressStartFontName");
			grayedAlpha = s.Serialize<float>(grayedAlpha, name: "grayedAlpha");
			idleAlpha = s.Serialize<float>(idleAlpha, name: "idleAlpha");
			pressStartPulsePeriod = s.Serialize<float>(pressStartPulsePeriod, name: "pressStartPulsePeriod");
			pressStartFadeInDuration = s.Serialize<float>(pressStartFadeInDuration, name: "pressStartFadeInDuration");
			pressStartFadeOutDuration = s.Serialize<float>(pressStartFadeOutDuration, name: "pressStartFadeOutDuration");
			pressStartMinAlpha = s.Serialize<float>(pressStartMinAlpha, name: "pressStartMinAlpha");
			pressStartMaxAlpha = s.Serialize<float>(pressStartMaxAlpha, name: "pressStartMaxAlpha");
			pressStartTextID = s.SerializeObject<LocalisationId>(pressStartTextID, name: "pressStartTextID");
			lumTexture = s.SerializeObject<Path>(lumTexture, name: "lumTexture");
			characterTexture = s.SerializeObject<Path>(characterTexture, name: "characterTexture");
			lumBoxLocalPosition = s.SerializeObject<Vec2d>(lumBoxLocalPosition, name: "lumBoxLocalPosition");
			lumBoxLocalSize = s.SerializeObject<Vec2d>(lumBoxLocalSize, name: "lumBoxLocalSize");
			headBoxLocalSize = s.SerializeObject<Vec2d>(headBoxLocalSize, name: "headBoxLocalSize");
		}
		public override uint? ClassCRC => 0xF0F35EB5;
	}
}

