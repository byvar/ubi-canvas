using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudRepellerComponent_Template : CSerializable {
		[Serialize("safeZoneToleranceDistance")] public float safeZoneToleranceDistance;
		[Serialize("safeZoneRadiusMin"        )] public float safeZoneRadiusMin;
		[Serialize("safeZoneRadiusMax"        )] public float safeZoneRadiusMax;
		[Serialize("defaultState"             )] public int defaultState;
		[Serialize("cycleDuration"            )] public float cycleDuration;
		[Serialize("maxAllowedCycles"         )] public int maxAllowedCycles;
		[Serialize("stateRatioOFF"            )] public float stateRatioOFF;
		[Serialize("stateRatioOFFtoON"        )] public float stateRatioOFFtoON;
		[Serialize("stateRatioON"             )] public float stateRatioON;
		[Serialize("stateRatioONtoOFF"        )] public float stateRatioONtoOFF;
		[Serialize("safeZonePulseRadius"      )] public float safeZonePulseRadius;
		[Serialize("safeZonePulseTime"        )] public float safeZonePulseTime;
		[Serialize("minAlphaValue"            )] public float minAlphaValue;
		[Serialize("maxAlphaValue"            )] public float maxAlphaValue;
		[Serialize("safeZoneCenterOffset"     )] public Vector2 safeZoneCenterOffset;
		[Serialize("particleFxName"           )] public StringID particleFxName;
		[Serialize("particleFXSizeRatio"      )] public float particleFXSizeRatio;
		[Serialize("textureBlendMode"         )] public Enum_textureBlendMode textureBlendMode;
		[Serialize("pulseMaterial"            )] public Placeholder pulseMaterial;
		[Serialize("loopingSoundName"         )] public StringID loopingSoundName;
		[Serialize("periodicSoundName"        )] public StringID periodicSoundName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(safeZoneToleranceDistance));
			SerializeField(s, nameof(safeZoneRadiusMin));
			SerializeField(s, nameof(safeZoneRadiusMax));
			SerializeField(s, nameof(defaultState));
			SerializeField(s, nameof(cycleDuration));
			SerializeField(s, nameof(maxAllowedCycles));
			SerializeField(s, nameof(stateRatioOFF));
			SerializeField(s, nameof(stateRatioOFFtoON));
			SerializeField(s, nameof(stateRatioON));
			SerializeField(s, nameof(stateRatioONtoOFF));
			SerializeField(s, nameof(safeZonePulseRadius));
			SerializeField(s, nameof(safeZonePulseTime));
			SerializeField(s, nameof(minAlphaValue));
			SerializeField(s, nameof(maxAlphaValue));
			SerializeField(s, nameof(safeZoneCenterOffset));
			SerializeField(s, nameof(particleFxName));
			SerializeField(s, nameof(particleFXSizeRatio));
			SerializeField(s, nameof(textureBlendMode));
			SerializeField(s, nameof(pulseMaterial));
			SerializeField(s, nameof(loopingSoundName));
			SerializeField(s, nameof(periodicSoundName));
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
		public override uint? ClassCRC => 0xB9090F9A;
	}
}

