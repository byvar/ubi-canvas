using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LightingMushroomComponent_Template : ActorComponent_Template {
		[Serialize("DisplayDebugCircle"     )] public bool DisplayDebugCircle;
		[Serialize("DisplayDebugFlight"     )] public bool DisplayDebugFlight;
		[Serialize("MurphyOnly"             )] public bool MurphyOnly;
		[Serialize("Speed"                  )] public float Speed;
		[Serialize("Gravity"                )] public float Gravity;
		[Serialize("ExplosionExpansionCoeff")] public float ExplosionExpansionCoeff;
		[Serialize("TornadoHitMultiplier"   )] public float TornadoHitMultiplier;
		[Serialize("RestartTimer"           )] public float RestartTimer;
		[Serialize("LightingTimer"          )] public float LightingTimer;
		[Serialize("TimeToFade"             )] public float TimeToFade;
		[Serialize("FadeFallCoeff"          )] public float FadeFallCoeff;
		[Serialize("NoHitZoneLength"        )] public float NoHitZoneLength;
		[Serialize("FlareFX"                )] public StringID FlareFX;
		[Serialize("ExplosionFX"            )] public StringID ExplosionFX;
		[Serialize("LightRocketFX"          )] public StringID LightRocketFX;
		[Serialize("LightSteadyFX"          )] public StringID LightSteadyFX;
		[Serialize("FXScaleSmall"           )] public Vector2 FXScaleSmall;
		[Serialize("FXScaleMedium"          )] public Vector2 FXScaleMedium;
		[Serialize("FXScaleLarge"           )] public Vector2 FXScaleLarge;
		[Serialize("FXScaleXLarge"          )] public Vector2 FXScaleXLarge;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DisplayDebugCircle));
			SerializeField(s, nameof(DisplayDebugFlight));
			SerializeField(s, nameof(MurphyOnly));
			SerializeField(s, nameof(Speed));
			SerializeField(s, nameof(Gravity));
			SerializeField(s, nameof(ExplosionExpansionCoeff));
			SerializeField(s, nameof(TornadoHitMultiplier));
			SerializeField(s, nameof(RestartTimer));
			SerializeField(s, nameof(LightingTimer));
			SerializeField(s, nameof(TimeToFade));
			SerializeField(s, nameof(FadeFallCoeff));
			SerializeField(s, nameof(NoHitZoneLength));
			SerializeField(s, nameof(FlareFX));
			SerializeField(s, nameof(ExplosionFX));
			SerializeField(s, nameof(LightRocketFX));
			SerializeField(s, nameof(LightSteadyFX));
			SerializeField(s, nameof(FXScaleSmall));
			SerializeField(s, nameof(FXScaleMedium));
			SerializeField(s, nameof(FXScaleLarge));
			SerializeField(s, nameof(FXScaleXLarge));
		}
		public override uint? ClassCRC => 0x7DF1E5B9;
	}
}

