using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidModifier : CSerializable {
		[Serialize("BoxOffset"     )] public Vec3d BoxOffset;
		[Serialize("BoxSize"       )] public Vec2d BoxSize;
		[Serialize("Force"         )] public Vec2d Force;
		[Serialize("ForceTexFactor")] public float ForceTexFactor;
		[Serialize("Mode"          )] public GFX_GRID_MOD_MODE Mode;
		[Serialize("Intensity"     )] public float Intensity;
		[Serialize("FluidColor"    )] public Color FluidColor;
		[Serialize("Active"        )] public bool Active;
		[Serialize("SpeedToForce"  )] public bool SpeedToForce;
		[Serialize("Texture"       )] public Path Texture;
		[Serialize("LifeTime"      )] public float LifeTime;
		[Serialize("StartDelay"    )] public float StartDelay;
		[Serialize("FadeInLength"  )] public float FadeInLength;
		[Serialize("FadeOutLength" )] public float FadeOutLength;
		[Serialize("ScaleInit"     )] public Vec2d ScaleInit;
		[Serialize("ScaleEnd"      )] public Vec2d ScaleEnd;
		[Serialize("RotationInit"  )] public float RotationInit;
		[Serialize("RotationEnd"   )] public float RotationEnd;
		[Serialize("Speed"         )] public Vec2d Speed;
		[Serialize("EmitterFilter" )] public uint EmitterFilter;
		[Serialize("PulseMode"     )] public GFX_GRID_MOD_PULSE PulseMode;
		[Serialize("PulseFreq"     )] public float PulseFreq;
		[Serialize("PulsePhase"    )] public float PulsePhase;
		[Serialize("PulseAmplitude")] public float PulseAmplitude;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(BoxOffset));
				SerializeField(s, nameof(BoxSize));
				SerializeField(s, nameof(Force));
				SerializeField(s, nameof(ForceTexFactor));
				SerializeField(s, nameof(Mode));
				SerializeField(s, nameof(Intensity));
				SerializeField(s, nameof(FluidColor));
				SerializeField(s, nameof(Active));
				SerializeField(s, nameof(SpeedToForce));
				SerializeField(s, nameof(Texture));
				SerializeField(s, nameof(LifeTime));
				SerializeField(s, nameof(StartDelay));
				SerializeField(s, nameof(FadeInLength));
				SerializeField(s, nameof(FadeOutLength));
				SerializeField(s, nameof(ScaleInit));
				SerializeField(s, nameof(ScaleEnd));
				SerializeField(s, nameof(RotationInit));
				SerializeField(s, nameof(RotationEnd));
				SerializeField(s, nameof(Speed));
				SerializeField(s, nameof(EmitterFilter));
				SerializeField(s, nameof(PulseMode));
				SerializeField(s, nameof(PulseFreq));
				SerializeField(s, nameof(PulsePhase));
				SerializeField(s, nameof(PulseAmplitude));
			}
		}

		public enum GFX_GRID_MOD_MODE {
			[Serialize("GFX_GRID_MOD_MODE"       )] NONE = 0,
			[Serialize("GFX_GRID_MOD_FLUID"      )] FLUID = 1,
			[Serialize("GFX_GRID_MOD_FORCE"      )] FORCE = 2,
			[Serialize("GFX_GRID_MOD_BLOCKER"    )] BLOCKER = 4,
			[Serialize("GFX_GRID_MOD_FLUID_FORCE")] FLUID_FORCE = 3
		}
	
		public enum GFX_GRID_MOD_PULSE {
			[Serialize("GFX_GRID_MOD_PULSE_NONE"     )] NONE = 0,
			[Serialize("GFX_GRID_MOD_PULSE_SINUS"    )] SINUS = 1,
			[Serialize("GFX_GRID_MOD_PULSE_TRIANGLE1")] TRIANGLE1 = 2,
			[Serialize("GFX_GRID_MOD_PULSE_TRIANGLE2")] TRIANGLE2 = 3,
			[Serialize("GFX_GRID_MOD_PULSE_TRIANGLE3")] TRIANGLE3 = 4,
			[Serialize("GFX_GRID_MOD_PULSE_PALIER1"  )] PALIER1 = 5,
			[Serialize("GFX_GRID_MOD_PULSE_PALIER2"  )] PALIER2 = 6,
			[Serialize("GFX_GRID_MOD_PULSE_PALIER3"  )] PALIER3 = 7
		}
	}
}

