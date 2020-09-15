using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidModifier : CSerializable {
		public Vec3d BoxOffset;
		public Vec2d BoxSize;
		public Vec2d Force;
		public float ForceTexFactor;
		public GFX_GRID_MOD_MODE Mode;
		public float Intensity;
		public Color FluidColor;
		public bool Active;
		public bool SpeedToForce;
		public Path Texture;
		public float LifeTime;
		public float StartDelay;
		public float FadeInLength;
		public float FadeOutLength;
		public Vec2d ScaleInit;
		public Vec2d ScaleEnd;
		public float RotationInit;
		public float RotationEnd;
		public Vec2d Speed;
		public uint EmitterFilter;
		public GFX_GRID_MOD_PULSE PulseMode;
		public float PulseFreq;
		public float PulsePhase;
		public float PulseAmplitude;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				BoxOffset = s.SerializeObject<Vec3d>(BoxOffset, name: "BoxOffset");
				BoxSize = s.SerializeObject<Vec2d>(BoxSize, name: "BoxSize");
				Force = s.SerializeObject<Vec2d>(Force, name: "Force");
				ForceTexFactor = s.Serialize<float>(ForceTexFactor, name: "ForceTexFactor");
				Mode = s.Serialize<GFX_GRID_MOD_MODE>(Mode, name: "Mode");
				Intensity = s.Serialize<float>(Intensity, name: "Intensity");
				FluidColor = s.SerializeObject<Color>(FluidColor, name: "FluidColor");
				Active = s.Serialize<bool>(Active, name: "Active");
				SpeedToForce = s.Serialize<bool>(SpeedToForce, name: "SpeedToForce");
				Texture = s.SerializeObject<Path>(Texture, name: "Texture");
				LifeTime = s.Serialize<float>(LifeTime, name: "LifeTime");
				StartDelay = s.Serialize<float>(StartDelay, name: "StartDelay");
				FadeInLength = s.Serialize<float>(FadeInLength, name: "FadeInLength");
				FadeOutLength = s.Serialize<float>(FadeOutLength, name: "FadeOutLength");
				ScaleInit = s.SerializeObject<Vec2d>(ScaleInit, name: "ScaleInit");
				ScaleEnd = s.SerializeObject<Vec2d>(ScaleEnd, name: "ScaleEnd");
				RotationInit = s.Serialize<float>(RotationInit, name: "RotationInit");
				RotationEnd = s.Serialize<float>(RotationEnd, name: "RotationEnd");
				Speed = s.SerializeObject<Vec2d>(Speed, name: "Speed");
				EmitterFilter = s.Serialize<uint>(EmitterFilter, name: "EmitterFilter");
				PulseMode = s.Serialize<GFX_GRID_MOD_PULSE>(PulseMode, name: "PulseMode");
				PulseFreq = s.Serialize<float>(PulseFreq, name: "PulseFreq");
				PulsePhase = s.Serialize<float>(PulsePhase, name: "PulsePhase");
				PulseAmplitude = s.Serialize<float>(PulseAmplitude, name: "PulseAmplitude");
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

