using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SpikyShellTrapComponent_Template : CSerializable {
		public Path texturePath;
		public float baseWidth;
		public float minScaleFactor;
		public float minSpacing;
		public float maxSpacing;
		public float baseHeight;
		public float restHeightPercent;
		public float risenHeightPercent;
		public float maxHeight;
		public uint frontBaseTexIndex_Idle;
		public uint frontBaseFirstTexIndex_Shaking;
		public uint frontBaseLastTexIndex_Shaking;
		public uint backBaseTexIndex_Idle;
		public uint backBaseFirstTexIndex_Shaking;
		public uint spikeFirstTexIndex;
		public uint spikeLastTexIndex;
		public float spikeWidth;
		public float shakeDetectionRadius;
		public float spikeDetectionRadius;
		public float endOfSpikeDetectionRadius;
		public uint faction;
		public float minAlertDuration;
		public float minSpikeDuration;
		public float shakeAmplitude;
		public float spikeVibration_UpDuration;
		public float spikeVibration_DownDuration;
		public float spikeAmplitude;
		public float spikeYOffset;
		public float hitMarginPercent;
		public uint hitLevel;
		public float spikeAnimationFirstFrameDuration;
		public float spikeAnimationFrameDuration;
		public float baseAnimationFrameDuration;
		public float spikeInertia_Out;
		public float spikeInertia_EmergencyOut;
		public float spikeInertia_Holster;
		public float spikeDetectionRadius_Emergency;
		public float spikeBounciness;
		public float hitWidthScale;
		public Angle rotationMargin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			texturePath = s.SerializeObject<Path>(texturePath, name: "texturePath");
			baseWidth = s.Serialize<float>(baseWidth, name: "baseWidth");
			minScaleFactor = s.Serialize<float>(minScaleFactor, name: "minScaleFactor");
			minSpacing = s.Serialize<float>(minSpacing, name: "minSpacing");
			maxSpacing = s.Serialize<float>(maxSpacing, name: "maxSpacing");
			baseHeight = s.Serialize<float>(baseHeight, name: "baseHeight");
			restHeightPercent = s.Serialize<float>(restHeightPercent, name: "restHeightPercent");
			risenHeightPercent = s.Serialize<float>(risenHeightPercent, name: "risenHeightPercent");
			maxHeight = s.Serialize<float>(maxHeight, name: "maxHeight");
			frontBaseTexIndex_Idle = s.Serialize<uint>(frontBaseTexIndex_Idle, name: "frontBaseTexIndex_Idle");
			frontBaseFirstTexIndex_Shaking = s.Serialize<uint>(frontBaseFirstTexIndex_Shaking, name: "frontBaseFirstTexIndex_Shaking");
			frontBaseLastTexIndex_Shaking = s.Serialize<uint>(frontBaseLastTexIndex_Shaking, name: "frontBaseLastTexIndex_Shaking");
			backBaseTexIndex_Idle = s.Serialize<uint>(backBaseTexIndex_Idle, name: "backBaseTexIndex_Idle");
			backBaseFirstTexIndex_Shaking = s.Serialize<uint>(backBaseFirstTexIndex_Shaking, name: "backBaseFirstTexIndex_Shaking");
			spikeFirstTexIndex = s.Serialize<uint>(spikeFirstTexIndex, name: "spikeFirstTexIndex");
			spikeLastTexIndex = s.Serialize<uint>(spikeLastTexIndex, name: "spikeLastTexIndex");
			spikeWidth = s.Serialize<float>(spikeWidth, name: "spikeWidth");
			shakeDetectionRadius = s.Serialize<float>(shakeDetectionRadius, name: "shakeDetectionRadius");
			spikeDetectionRadius = s.Serialize<float>(spikeDetectionRadius, name: "spikeDetectionRadius");
			endOfSpikeDetectionRadius = s.Serialize<float>(endOfSpikeDetectionRadius, name: "endOfSpikeDetectionRadius");
			faction = s.Serialize<uint>(faction, name: "faction");
			minAlertDuration = s.Serialize<float>(minAlertDuration, name: "minAlertDuration");
			minSpikeDuration = s.Serialize<float>(minSpikeDuration, name: "minSpikeDuration");
			shakeAmplitude = s.Serialize<float>(shakeAmplitude, name: "shakeAmplitude");
			spikeVibration_UpDuration = s.Serialize<float>(spikeVibration_UpDuration, name: "spikeVibration_UpDuration");
			spikeVibration_DownDuration = s.Serialize<float>(spikeVibration_DownDuration, name: "spikeVibration_DownDuration");
			spikeAmplitude = s.Serialize<float>(spikeAmplitude, name: "spikeAmplitude");
			spikeYOffset = s.Serialize<float>(spikeYOffset, name: "spikeYOffset");
			hitMarginPercent = s.Serialize<float>(hitMarginPercent, name: "hitMarginPercent");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			spikeAnimationFirstFrameDuration = s.Serialize<float>(spikeAnimationFirstFrameDuration, name: "spikeAnimationFirstFrameDuration");
			spikeAnimationFrameDuration = s.Serialize<float>(spikeAnimationFrameDuration, name: "spikeAnimationFrameDuration");
			baseAnimationFrameDuration = s.Serialize<float>(baseAnimationFrameDuration, name: "baseAnimationFrameDuration");
			spikeInertia_Out = s.Serialize<float>(spikeInertia_Out, name: "spikeInertia_Out");
			spikeInertia_EmergencyOut = s.Serialize<float>(spikeInertia_EmergencyOut, name: "spikeInertia_EmergencyOut");
			spikeInertia_Holster = s.Serialize<float>(spikeInertia_Holster, name: "spikeInertia_Holster");
			spikeDetectionRadius_Emergency = s.Serialize<float>(spikeDetectionRadius_Emergency, name: "spikeDetectionRadius_Emergency");
			spikeBounciness = s.Serialize<float>(spikeBounciness, name: "spikeBounciness");
			hitWidthScale = s.Serialize<float>(hitWidthScale, name: "hitWidthScale");
			rotationMargin = s.SerializeObject<Angle>(rotationMargin, name: "rotationMargin");
		}
		public override uint? ClassCRC => 0xE62DB02F;
	}
}

