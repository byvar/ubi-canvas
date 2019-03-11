using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_381_sub_B0E870 : CSerializable {
		[Serialize("fadeTime"               )] public float fadeTime;
		[Serialize("pulseDuration"          )] public float pulseDuration;
		[Serialize("numPulses"              )] public uint numPulses;
		[Serialize("blinkOnDuration"        )] public float blinkOnDuration;
		[Serialize("blinkOffDuration"       )] public float blinkOffDuration;
		[Serialize("detectedPauseDuration"  )] public float detectedPauseDuration;
		[Serialize("detectedParams"         )] public Placeholder detectedParams;
		[Serialize("detectedParams2"        )] public Placeholder detectedParams2;
		[Serialize("laserActorPath"         )] public Path laserActorPath;
		[Serialize("fadeToOnShortFxTime"    )] public float fadeToOnShortFxTime;
		[Serialize("animOff"                )] public StringID animOff;
		[Serialize("animOn"                 )] public StringID animOn;
		[Serialize("animFadeToDetected"     )] public StringID animFadeToDetected;
		[Serialize("animDetected"           )] public StringID animDetected;
		[Serialize("animFadeToOn"           )] public StringID animFadeToOn;
		[Serialize("alertFactor"            )] public float alertFactor;
		[Serialize("lightUVRotationSpeedMin")] public Angle lightUVRotationSpeedMin;
		[Serialize("lightUVRotationSpeedMax")] public Angle lightUVRotationSpeedMax;
		[Serialize("reloadTime"             )] public float reloadTime;
		[Serialize("closingSpeed"           )] public float closingSpeed;
		[Serialize("flashFrequency"         )] public float flashFrequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fadeTime));
			SerializeField(s, nameof(pulseDuration));
			SerializeField(s, nameof(numPulses));
			SerializeField(s, nameof(blinkOnDuration));
			SerializeField(s, nameof(blinkOffDuration));
			SerializeField(s, nameof(detectedPauseDuration));
			SerializeField(s, nameof(detectedParams));
			SerializeField(s, nameof(detectedParams2));
			SerializeField(s, nameof(laserActorPath));
			SerializeField(s, nameof(fadeToOnShortFxTime));
			SerializeField(s, nameof(animOff));
			SerializeField(s, nameof(animOn));
			SerializeField(s, nameof(animFadeToDetected));
			SerializeField(s, nameof(animDetected));
			SerializeField(s, nameof(animFadeToOn));
			SerializeField(s, nameof(alertFactor));
			SerializeField(s, nameof(lightUVRotationSpeedMin));
			SerializeField(s, nameof(lightUVRotationSpeedMax));
			SerializeField(s, nameof(reloadTime));
			SerializeField(s, nameof(closingSpeed));
			SerializeField(s, nameof(flashFrequency));
		}
		public override uint? ClassCRC => 0xB65AD628;
	}
}

