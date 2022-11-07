namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LightingMushroomComponent_Template : ActorComponent_Template {
		public bool DisplayDebugCircle;
		public bool DisplayDebugFlight;
		public bool MurphyOnly;
		public float Speed;
		public float Gravity;
		public float ExplosionExpansionCoeff;
		public float TornadoHitMultiplier;
		public float RestartTimer;
		public float LightingTimer;
		public float TimeToFade;
		public float FadeFallCoeff;
		public float NoHitZoneLength;
		public StringID FlareFX;
		public StringID ExplosionFX;
		public StringID LightRocketFX;
		public StringID LightSteadyFX;
		public Vec2d FXScaleSmall;
		public Vec2d FXScaleMedium;
		public Vec2d FXScaleLarge;
		public Vec2d FXScaleXLarge;
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

