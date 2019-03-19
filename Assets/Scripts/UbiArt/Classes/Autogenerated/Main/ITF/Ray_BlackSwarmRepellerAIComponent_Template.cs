using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BlackSwarmRepellerAIComponent_Template : CSerializable {
		[Serialize("interactive"              )] public int interactive;
		[Serialize("safeZoneToleranceDistance")] public float safeZoneToleranceDistance;
		[Serialize("safeZoneRadiusMin"        )] public float safeZoneRadiusMin;
		[Serialize("safeZoneRadiusMax"        )] public float safeZoneRadiusMax;
		[Serialize("syncOffset"               )] public float syncOffset;
		[Serialize("defaultState"             )] public int defaultState;
		[Serialize("cycleDuration"            )] public float cycleDuration;
		[Serialize("maxAllowedCycles"         )] public int maxAllowedCycles;
		[Serialize("stateRatioOFF"            )] public float stateRatioOFF;
		[Serialize("stateRatioOFFtoON"        )] public float stateRatioOFFtoON;
		[Serialize("stateRatioON"             )] public float stateRatioON;
		[Serialize("stateRatioONtoOFF"        )] public float stateRatioONtoOFF;
		[Serialize("useSynchro"               )] public int useSynchro;
		[Serialize("safeZonePulseRadius"      )] public float safeZonePulseRadius;
		[Serialize("safeZonePulseTime"        )] public float safeZonePulseTime;
		[Serialize("minAlphaValue"            )] public float minAlphaValue;
		[Serialize("maxAlphaValue"            )] public float maxAlphaValue;
		[Serialize("safeZoneCenterOffset"     )] public Vector2 safeZoneCenterOffset;
		[Serialize("pulseTexturePath"         )] public Path pulseTexturePath;
		[Serialize("particleFxName"           )] public StringID particleFxName;
		[Serialize("particleFXSizeRatio"      )] public float particleFXSizeRatio;
		[Serialize("textureBlendMode"         )] public uint textureBlendMode;
		[Serialize("interactiveSoundName"     )] public StringID interactiveSoundName;
		[Serialize("periodicSoundName"        )] public StringID periodicSoundName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(interactive));
			SerializeField(s, nameof(safeZoneToleranceDistance));
			SerializeField(s, nameof(safeZoneRadiusMin));
			SerializeField(s, nameof(safeZoneRadiusMax));
			SerializeField(s, nameof(syncOffset));
			SerializeField(s, nameof(defaultState));
			SerializeField(s, nameof(cycleDuration));
			SerializeField(s, nameof(maxAllowedCycles));
			SerializeField(s, nameof(stateRatioOFF));
			SerializeField(s, nameof(stateRatioOFFtoON));
			SerializeField(s, nameof(stateRatioON));
			SerializeField(s, nameof(stateRatioONtoOFF));
			SerializeField(s, nameof(useSynchro));
			SerializeField(s, nameof(safeZonePulseRadius));
			SerializeField(s, nameof(safeZonePulseTime));
			SerializeField(s, nameof(minAlphaValue));
			SerializeField(s, nameof(maxAlphaValue));
			SerializeField(s, nameof(safeZoneCenterOffset));
			SerializeField(s, nameof(pulseTexturePath));
			SerializeField(s, nameof(particleFxName));
			SerializeField(s, nameof(particleFXSizeRatio));
			SerializeField(s, nameof(textureBlendMode));
			SerializeField(s, nameof(interactiveSoundName));
			SerializeField(s, nameof(periodicSoundName));
		}
		public override uint? ClassCRC => 0x8AFD9C0D;
	}
}

