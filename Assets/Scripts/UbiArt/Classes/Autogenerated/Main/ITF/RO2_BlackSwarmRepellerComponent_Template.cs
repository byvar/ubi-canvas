using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BlackSwarmRepellerComponent_Template : ActorComponent_Template {
		[Serialize("interactive"              )] public bool interactive;
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
		[Serialize("useSynchro"               )] public bool useSynchro;
		[Serialize("safeZonePulseRadius"      )] public float safeZonePulseRadius;
		[Serialize("safeZonePulseTime"        )] public float safeZonePulseTime;
		[Serialize("minAlphaValue"            )] public float minAlphaValue;
		[Serialize("maxAlphaValue"            )] public float maxAlphaValue;
		[Serialize("safeZoneCenterOffset"     )] public Vector2 safeZoneCenterOffset;
		[Serialize("particleFxName"           )] public StringID particleFxName;
		[Serialize("particleFXSizeRatio"      )] public float particleFXSizeRatio;
		[Serialize("textureBlendMode"         )] public uint textureBlendMode;
		[Serialize("interactiveSoundName"     )] public StringID interactiveSoundName;
		[Serialize("periodicSoundName"        )] public StringID periodicSoundName;
		[Serialize("pulseMaterial"            )] public GFXMaterialSerializable pulseMaterial;
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
			SerializeField(s, nameof(particleFxName));
			SerializeField(s, nameof(particleFXSizeRatio));
			SerializeField(s, nameof(textureBlendMode));
			SerializeField(s, nameof(interactiveSoundName));
			SerializeField(s, nameof(periodicSoundName));
			SerializeField(s, nameof(pulseMaterial));
		}
		public override uint? ClassCRC => 0xB91C0A84;
	}
}

