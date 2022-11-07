namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_StringWaveFaderComponent_Template : ActorComponent_Template {
		public float minBounceSpeed;
		public float maxDownwardSpeed;
		public float maxUpwardSpeed;
		public float upwardAcceleration;
		public float downwardAcceleration;
		public float bounceFactor;
		public float thresholdPosition;
		public float linkeeScaleForOff;
		public float linkeeScaleForOn;
		public float crushSpeed;
		public StringID bounceOnEndFX;
		public StringID goDownwardFX;
		public float minSpeedForSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minBounceSpeed = s.Serialize<float>(minBounceSpeed, name: "minBounceSpeed");
			maxDownwardSpeed = s.Serialize<float>(maxDownwardSpeed, name: "maxDownwardSpeed");
			maxUpwardSpeed = s.Serialize<float>(maxUpwardSpeed, name: "maxUpwardSpeed");
			upwardAcceleration = s.Serialize<float>(upwardAcceleration, name: "upwardAcceleration");
			downwardAcceleration = s.Serialize<float>(downwardAcceleration, name: "downwardAcceleration");
			bounceFactor = s.Serialize<float>(bounceFactor, name: "bounceFactor");
			thresholdPosition = s.Serialize<float>(thresholdPosition, name: "thresholdPosition");
			linkeeScaleForOff = s.Serialize<float>(linkeeScaleForOff, name: "linkeeScaleForOff");
			linkeeScaleForOn = s.Serialize<float>(linkeeScaleForOn, name: "linkeeScaleForOn");
			crushSpeed = s.Serialize<float>(crushSpeed, name: "crushSpeed");
			bounceOnEndFX = s.SerializeObject<StringID>(bounceOnEndFX, name: "bounceOnEndFX");
			goDownwardFX = s.SerializeObject<StringID>(goDownwardFX, name: "goDownwardFX");
			minSpeedForSound = s.Serialize<float>(minSpeedForSound, name: "minSpeedForSound");
		}
		public override uint? ClassCRC => 0x7A6DD69D;
	}
}

