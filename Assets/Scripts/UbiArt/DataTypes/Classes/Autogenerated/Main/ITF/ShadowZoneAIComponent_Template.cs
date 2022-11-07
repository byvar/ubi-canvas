namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ShadowZoneAIComponent_Template : ActorComponent_Template {
		public float fadeTime;
		public float pulseDuration;
		public uint numPulses;
		public float blinkOnDuration;
		public float blinkOffDuration;
		public float detectedPauseDuration;
		public GFXPrimitiveParam detectedParams;
		public GFXPrimitiveParam detectedParams2;
		public Path laserActorPath;
		public float fadeToOnShortFxTime;
		public StringID animOff;
		public StringID animOn;
		public StringID animFadeToDetected;
		public StringID animDetected;
		public StringID animFadeToOn;
		public float alertFactor;
		public Angle lightUVRotationSpeedMin;
		public Angle lightUVRotationSpeedMax;
		public float reloadTime;
		public float closingSpeed;
		public float flashFrequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fadeTime = s.Serialize<float>(fadeTime, name: "fadeTime");
			pulseDuration = s.Serialize<float>(pulseDuration, name: "pulseDuration");
			numPulses = s.Serialize<uint>(numPulses, name: "numPulses");
			blinkOnDuration = s.Serialize<float>(blinkOnDuration, name: "blinkOnDuration");
			blinkOffDuration = s.Serialize<float>(blinkOffDuration, name: "blinkOffDuration");
			detectedPauseDuration = s.Serialize<float>(detectedPauseDuration, name: "detectedPauseDuration");
			detectedParams = s.SerializeObject<GFXPrimitiveParam>(detectedParams, name: "detectedParams");
			detectedParams2 = s.SerializeObject<GFXPrimitiveParam>(detectedParams2, name: "detectedParams2");
			laserActorPath = s.SerializeObject<Path>(laserActorPath, name: "laserActorPath");
			fadeToOnShortFxTime = s.Serialize<float>(fadeToOnShortFxTime, name: "fadeToOnShortFxTime");
			animOff = s.SerializeObject<StringID>(animOff, name: "animOff");
			animOn = s.SerializeObject<StringID>(animOn, name: "animOn");
			animFadeToDetected = s.SerializeObject<StringID>(animFadeToDetected, name: "animFadeToDetected");
			animDetected = s.SerializeObject<StringID>(animDetected, name: "animDetected");
			animFadeToOn = s.SerializeObject<StringID>(animFadeToOn, name: "animFadeToOn");
			alertFactor = s.Serialize<float>(alertFactor, name: "alertFactor");
			lightUVRotationSpeedMin = s.SerializeObject<Angle>(lightUVRotationSpeedMin, name: "lightUVRotationSpeedMin");
			lightUVRotationSpeedMax = s.SerializeObject<Angle>(lightUVRotationSpeedMax, name: "lightUVRotationSpeedMax");
			reloadTime = s.Serialize<float>(reloadTime, name: "reloadTime");
			closingSpeed = s.Serialize<float>(closingSpeed, name: "closingSpeed");
			flashFrequency = s.Serialize<float>(flashFrequency, name: "flashFrequency");
		}
		public override uint? ClassCRC => 0x44193B72;
	}
}

