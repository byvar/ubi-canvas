namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SpikyShellTrapComponent_Template : ActorComponent_Template {
		public GFXMaterialSerializable spikeMaterial;
		public float spikeWidth;
		public float spikeHeight;
		public float spikeHeightOffsetDown;
		public float spikeHeightOffsetUp;
		public float baseWidth;
		public float baseHeight;
		public float baseHeightOffset;
		public float minScaleFactor;
		public float minSpacing;
		public float maxSpacing;
		public float restHeightPercent;
		public float shakeHeightPercent;
		public float risenHeightPercent;
		public uint frontBaseTexIndex_Idle;
		public uint frontBaseFirstTexIndex_Shaking;
		public uint frontBaseLastTexIndex_Shaking;
		public uint backBaseTexIndex_Idle;
		public uint backBaseFirstTexIndex_Shaking;
		public uint spikeFirstTexIndex;
		public uint spikeLastTexIndex;
		public float shakeDetectionRadius;
		public float spikeDetectionRadius;
		public float endOfSpikeDetectionRadius;
		public uint faction;
		public float minAlertDuration;
		public float minSpikeDuration;
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
		public Angle sidesAngle;
		public float hitWidthScale;
		public Angle rotationMargin;
		public float syncRatio;
		public float syncOffset;
		public float syncIndexOffset;
		public bool useAdditionalSpikes;

		public float baseHeightVita { get; set; }


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spikeMaterial = s.SerializeObject<GFXMaterialSerializable>(spikeMaterial, name: "spikeMaterial");
			spikeWidth = s.Serialize<float>(spikeWidth, name: "spikeWidth");
			spikeHeight = s.Serialize<float>(spikeHeight, name: "spikeHeight");
			spikeHeightOffsetDown = s.Serialize<float>(spikeHeightOffsetDown, name: "spikeHeightOffsetDown");
			spikeHeightOffsetUp = s.Serialize<float>(spikeHeightOffsetUp, name: "spikeHeightOffsetUp");
			baseWidth = s.Serialize<float>(baseWidth, name: "baseWidth");
			baseHeight = s.Serialize<float>(baseHeight, name: "baseHeight");
			baseHeightOffset = s.Serialize<float>(baseHeightOffset, name: "baseHeightOffset");
			minScaleFactor = s.Serialize<float>(minScaleFactor, name: "minScaleFactor");
			minSpacing = s.Serialize<float>(minSpacing, name: "minSpacing");
			maxSpacing = s.Serialize<float>(maxSpacing, name: "maxSpacing");
			if (s.Settings.Platform == GamePlatform.Vita) {
				baseHeightVita = s.Serialize<float>(baseHeightVita, name: "baseHeight2");
			}
			restHeightPercent = s.Serialize<float>(restHeightPercent, name: "restHeightPercent");
			shakeHeightPercent = s.Serialize<float>(shakeHeightPercent, name: "shakeHeightPercent");
			risenHeightPercent = s.Serialize<float>(risenHeightPercent, name: "risenHeightPercent");
			frontBaseTexIndex_Idle = s.Serialize<uint>(frontBaseTexIndex_Idle, name: "frontBaseTexIndex_Idle");
			frontBaseFirstTexIndex_Shaking = s.Serialize<uint>(frontBaseFirstTexIndex_Shaking, name: "frontBaseFirstTexIndex_Shaking");
			frontBaseLastTexIndex_Shaking = s.Serialize<uint>(frontBaseLastTexIndex_Shaking, name: "frontBaseLastTexIndex_Shaking");
			backBaseTexIndex_Idle = s.Serialize<uint>(backBaseTexIndex_Idle, name: "backBaseTexIndex_Idle");
			backBaseFirstTexIndex_Shaking = s.Serialize<uint>(backBaseFirstTexIndex_Shaking, name: "backBaseFirstTexIndex_Shaking");
			spikeFirstTexIndex = s.Serialize<uint>(spikeFirstTexIndex, name: "spikeFirstTexIndex");
			spikeLastTexIndex = s.Serialize<uint>(spikeLastTexIndex, name: "spikeLastTexIndex");
			shakeDetectionRadius = s.Serialize<float>(shakeDetectionRadius, name: "shakeDetectionRadius");
			spikeDetectionRadius = s.Serialize<float>(spikeDetectionRadius, name: "spikeDetectionRadius");
			endOfSpikeDetectionRadius = s.Serialize<float>(endOfSpikeDetectionRadius, name: "endOfSpikeDetectionRadius");
			faction = s.Serialize<uint>(faction, name: "faction");
			minAlertDuration = s.Serialize<float>(minAlertDuration, name: "minAlertDuration");
			minSpikeDuration = s.Serialize<float>(minSpikeDuration, name: "minSpikeDuration");
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
			sidesAngle = s.SerializeObject<Angle>(sidesAngle, name: "sidesAngle");
			hitWidthScale = s.Serialize<float>(hitWidthScale, name: "hitWidthScale");
			rotationMargin = s.SerializeObject<Angle>(rotationMargin, name: "rotationMargin");
			syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
			syncIndexOffset = s.Serialize<float>(syncIndexOffset, name: "syncIndexOffset");
			useAdditionalSpikes = s.Serialize<bool>(useAdditionalSpikes, name: "useAdditionalSpikes");
		}
		public override uint? ClassCRC => 0xF941D2A2;
	}
}

