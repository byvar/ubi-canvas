namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudRepellerComponent_Template : CSerializable {
		public float safeZoneToleranceDistance;
		public float safeZoneRadiusMin;
		public float safeZoneRadiusMax;
		public int defaultState;
		public float cycleDuration;
		public int maxAllowedCycles;
		public float stateRatioOFF;
		public float stateRatioOFFtoON;
		public float stateRatioON;
		public float stateRatioONtoOFF;
		public float safeZonePulseRadius;
		public float safeZonePulseTime;
		public float minAlphaValue;
		public float maxAlphaValue;
		public Vec2d safeZoneCenterOffset;
		public StringID particleFxName;
		public float particleFXSizeRatio;
		public Enum_textureBlendMode textureBlendMode;
		public Placeholder pulseMaterial;
		public StringID loopingSoundName;
		public StringID periodicSoundName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			safeZoneToleranceDistance = s.Serialize<float>(safeZoneToleranceDistance, name: "safeZoneToleranceDistance");
			safeZoneRadiusMin = s.Serialize<float>(safeZoneRadiusMin, name: "safeZoneRadiusMin");
			safeZoneRadiusMax = s.Serialize<float>(safeZoneRadiusMax, name: "safeZoneRadiusMax");
			defaultState = s.Serialize<int>(defaultState, name: "defaultState");
			cycleDuration = s.Serialize<float>(cycleDuration, name: "cycleDuration");
			maxAllowedCycles = s.Serialize<int>(maxAllowedCycles, name: "maxAllowedCycles");
			stateRatioOFF = s.Serialize<float>(stateRatioOFF, name: "stateRatioOFF");
			stateRatioOFFtoON = s.Serialize<float>(stateRatioOFFtoON, name: "stateRatioOFFtoON");
			stateRatioON = s.Serialize<float>(stateRatioON, name: "stateRatioON");
			stateRatioONtoOFF = s.Serialize<float>(stateRatioONtoOFF, name: "stateRatioONtoOFF");
			safeZonePulseRadius = s.Serialize<float>(safeZonePulseRadius, name: "safeZonePulseRadius");
			safeZonePulseTime = s.Serialize<float>(safeZonePulseTime, name: "safeZonePulseTime");
			minAlphaValue = s.Serialize<float>(minAlphaValue, name: "minAlphaValue");
			maxAlphaValue = s.Serialize<float>(maxAlphaValue, name: "maxAlphaValue");
			safeZoneCenterOffset = s.SerializeObject<Vec2d>(safeZoneCenterOffset, name: "safeZoneCenterOffset");
			particleFxName = s.SerializeObject<StringID>(particleFxName, name: "particleFxName");
			particleFXSizeRatio = s.Serialize<float>(particleFXSizeRatio, name: "particleFXSizeRatio");
			textureBlendMode = s.Serialize<Enum_textureBlendMode>(textureBlendMode, name: "textureBlendMode");
			pulseMaterial = s.SerializeObject<Placeholder>(pulseMaterial, name: "pulseMaterial");
			loopingSoundName = s.SerializeObject<StringID>(loopingSoundName, name: "loopingSoundName");
			periodicSoundName = s.SerializeObject<StringID>(periodicSoundName, name: "periodicSoundName");
		}
		public enum Enum_textureBlendMode {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_18")] Value_18 = 18,
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_20")] Value_20 = 20,
			[Serialize("Value_21")] Value_21 = 21,
			[Serialize("Value_22")] Value_22 = 22,
		}
		public override uint? ClassCRC => 0x38BC11BD;
	}
}

