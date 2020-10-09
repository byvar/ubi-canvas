using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BlackSwarmRepellerAIComponent_Template : CSerializable {
		public int interactive;
		public float safeZoneToleranceDistance;
		public float safeZoneRadiusMin;
		public float safeZoneRadiusMax;
		public float syncOffset;
		public int defaultState;
		public float cycleDuration;
		public int maxAllowedCycles;
		public float stateRatioOFF;
		public float stateRatioOFFtoON;
		public float stateRatioON;
		public float stateRatioONtoOFF;
		public int useSynchro;
		public float safeZonePulseRadius;
		public float safeZonePulseTime;
		public float minAlphaValue;
		public float maxAlphaValue;
		public Vec2d safeZoneCenterOffset;
		public Path pulseTexturePath;
		public StringID particleFxName;
		public float particleFXSizeRatio;
		public uint textureBlendMode;
		public StringID interactiveSoundName;
		public StringID periodicSoundName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			interactive = s.Serialize<int>(interactive, name: "interactive");
			safeZoneToleranceDistance = s.Serialize<float>(safeZoneToleranceDistance, name: "safeZoneToleranceDistance");
			safeZoneRadiusMin = s.Serialize<float>(safeZoneRadiusMin, name: "safeZoneRadiusMin");
			safeZoneRadiusMax = s.Serialize<float>(safeZoneRadiusMax, name: "safeZoneRadiusMax");
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
			defaultState = s.Serialize<int>(defaultState, name: "defaultState");
			cycleDuration = s.Serialize<float>(cycleDuration, name: "cycleDuration");
			maxAllowedCycles = s.Serialize<int>(maxAllowedCycles, name: "maxAllowedCycles");
			stateRatioOFF = s.Serialize<float>(stateRatioOFF, name: "stateRatioOFF");
			stateRatioOFFtoON = s.Serialize<float>(stateRatioOFFtoON, name: "stateRatioOFFtoON");
			stateRatioON = s.Serialize<float>(stateRatioON, name: "stateRatioON");
			stateRatioONtoOFF = s.Serialize<float>(stateRatioONtoOFF, name: "stateRatioONtoOFF");
			useSynchro = s.Serialize<int>(useSynchro, name: "useSynchro");
			safeZonePulseRadius = s.Serialize<float>(safeZonePulseRadius, name: "safeZonePulseRadius");
			safeZonePulseTime = s.Serialize<float>(safeZonePulseTime, name: "safeZonePulseTime");
			minAlphaValue = s.Serialize<float>(minAlphaValue, name: "minAlphaValue");
			maxAlphaValue = s.Serialize<float>(maxAlphaValue, name: "maxAlphaValue");
			safeZoneCenterOffset = s.SerializeObject<Vec2d>(safeZoneCenterOffset, name: "safeZoneCenterOffset");
			pulseTexturePath = s.SerializeObject<Path>(pulseTexturePath, name: "pulseTexturePath");
			particleFxName = s.SerializeObject<StringID>(particleFxName, name: "particleFxName");
			particleFXSizeRatio = s.Serialize<float>(particleFXSizeRatio, name: "particleFXSizeRatio");
			textureBlendMode = s.Serialize<uint>(textureBlendMode, name: "textureBlendMode");
			interactiveSoundName = s.SerializeObject<StringID>(interactiveSoundName, name: "interactiveSoundName");
			periodicSoundName = s.SerializeObject<StringID>(periodicSoundName, name: "periodicSoundName");
		}
		public override uint? ClassCRC => 0x8AFD9C0D;
	}
}

