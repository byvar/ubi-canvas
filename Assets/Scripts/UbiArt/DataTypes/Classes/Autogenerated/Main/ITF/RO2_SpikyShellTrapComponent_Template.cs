namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SpikyShellTrapComponent_Template : ActorComponent_Template {
		public GFXMaterialSerializable spikeMaterial;
		public float spikeWidth = 0.2f;
		public float spikeHeight = 1f;
		public float spikeHeightOffsetDown;
		public float spikeHeightOffsetUp;
		public float baseWidth = 1f;
		public float baseHeight = 0.5f;
		public float baseHeightOffset;
		public float minScaleFactor = 0.9f;
		public float minSpacing = 0.4f;
		public float maxSpacing = 0.6f;
		public float restHeightPercent = 0.3f;
		public float shakeHeightPercent = 0.3f;
		public float risenHeightPercent = 0.9f;
		public uint frontBaseTexIndex_Idle = 4;
		public uint frontBaseFirstTexIndex_Shaking = 5;
		public uint frontBaseLastTexIndex_Shaking = 6;
		public uint backBaseTexIndex_Idle = 5;
		public uint backBaseFirstTexIndex_Shaking = 6;
		public uint spikeFirstTexIndex;
		public uint spikeLastTexIndex = 3;
		public float shakeDetectionRadius = 4f;
		public float spikeDetectionRadius = 2f;
		public float endOfSpikeDetectionRadius = 4f;
		public uint faction = 2;
		public float minAlertDuration = 1f;
		public float minSpikeDuration = 0.5f;
		public float spikeYOffset = 0.2f;
		public float hitMarginPercent = 0.1f;
		public uint hitLevel;
		public float spikeAnimationFirstFrameDuration = 0.5f;
		public float spikeAnimationFrameDuration = 0.05f;
		public float baseAnimationFrameDuration = 0.1f;
		public float spikeInertia_Out = 0.1f;
		public float spikeInertia_EmergencyOut = 0.1f;
		public float spikeInertia_Holster = 0.5f;
		public float spikeDetectionRadius_Emergency = 3f;
		public float spikeBounciness = 4f;
		public Angle sidesAngle = 0.5f;
		public float hitWidthScale = 0.5f;
		public Angle rotationMargin = 0.08726646f;
		public float syncRatio = 1f;
		public float syncOffset;
		public float syncIndexOffset = 0.1f;
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

