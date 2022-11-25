namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LightingMushroomComponent_Template : ActorComponent_Template {
		public bool DisplayDebugCircle;
		public bool DisplayDebugFlight;
		public bool MurphyOnly;
		public float Speed = 10f;
		public float Gravity = 9.81f;
		public float ExplosionExpansionCoeff = 1f;
		public float TornadoHitMultiplier = 3f;
		public float RestartTimer = 2f;
		public float LightingTimer = 5f;
		public float TimeToFade = 2f;
		public float FadeFallCoeff = 1f;
		public float NoHitZoneLength = 1f;
		public StringID FlareFX;
		public StringID ExplosionFX;
		public StringID LightRocketFX;
		public StringID LightSteadyFX;
		public Vec2d FXScaleSmall = Vec2d.One;
		public Vec2d FXScaleMedium = Vec2d.One;
		public Vec2d FXScaleLarge = Vec2d.One;
		public Vec2d FXScaleXLarge = Vec2d.One;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DisplayDebugCircle = s.Serialize<bool>(DisplayDebugCircle, name: "DisplayDebugCircle");
			DisplayDebugFlight = s.Serialize<bool>(DisplayDebugFlight, name: "DisplayDebugFlight");
			MurphyOnly = s.Serialize<bool>(MurphyOnly, name: "MurphyOnly");
			Speed = s.Serialize<float>(Speed, name: "Speed");
			Gravity = s.Serialize<float>(Gravity, name: "Gravity");
			ExplosionExpansionCoeff = s.Serialize<float>(ExplosionExpansionCoeff, name: "ExplosionExpansionCoeff");
			TornadoHitMultiplier = s.Serialize<float>(TornadoHitMultiplier, name: "TornadoHitMultiplier");
			RestartTimer = s.Serialize<float>(RestartTimer, name: "RestartTimer");
			LightingTimer = s.Serialize<float>(LightingTimer, name: "LightingTimer");
			TimeToFade = s.Serialize<float>(TimeToFade, name: "TimeToFade");
			FadeFallCoeff = s.Serialize<float>(FadeFallCoeff, name: "FadeFallCoeff");
			NoHitZoneLength = s.Serialize<float>(NoHitZoneLength, name: "NoHitZoneLength");
			FlareFX = s.SerializeObject<StringID>(FlareFX, name: "FlareFX");
			ExplosionFX = s.SerializeObject<StringID>(ExplosionFX, name: "ExplosionFX");
			LightRocketFX = s.SerializeObject<StringID>(LightRocketFX, name: "LightRocketFX");
			LightSteadyFX = s.SerializeObject<StringID>(LightSteadyFX, name: "LightSteadyFX");
			FXScaleSmall = s.SerializeObject<Vec2d>(FXScaleSmall, name: "FXScaleSmall");
			FXScaleMedium = s.SerializeObject<Vec2d>(FXScaleMedium, name: "FXScaleMedium");
			FXScaleLarge = s.SerializeObject<Vec2d>(FXScaleLarge, name: "FXScaleLarge");
			FXScaleXLarge = s.SerializeObject<Vec2d>(FXScaleXLarge, name: "FXScaleXLarge");
		}
		public override uint? ClassCRC => 0x7DF1E5B9;
	}
}

