using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GridFluidComponent : ActorComponent {
		[Serialize("NbIter"           )] public uint NbIter;
		[Serialize("PressureDiffusion")] public float PressureDiffusion;
		[Serialize("PressureIntensity")] public float PressureIntensity;
		[Serialize("BoxSize"          )] public Vec2d BoxSize;
		[Serialize("PosOffset"        )] public Vec3d PosOffset;
		[Serialize("Inertia"          )] public float Inertia;
		[Serialize("RenderOffset"     )] public Vec3d RenderOffset;
		[Serialize("Reinit"           )] public bool Reinit;
		[Serialize("Active"           )] public bool Active;
		[Serialize("Pause"            )] public bool Pause;
		[Serialize("AcceptOnlyOwner"  )] public bool AcceptOnlyOwner;
		[Serialize("ParticleTexSizeX" )] public ushort ParticleTexSizeX;
		[Serialize("ParticleTexSizeY" )] public ushort ParticleTexSizeY;
		[Serialize("SpeedTexSizeX"    )] public ushort SpeedTexSizeX;
		[Serialize("SpeedTexSizeY"    )] public ushort SpeedTexSizeY;
		[Serialize("Weight"           )] public float Weight;
		[Serialize("Viscosity"        )] public float Viscosity;
		[Serialize("FluidDiffusion"   )] public float FluidDiffusion;
		[Serialize("FluidLoss"        )] public float FluidLoss;
		[Serialize("ColorLoss"        )] public float ColorLoss;
		[Serialize("VelocityLoss"     )] public float VelocityLoss;
		[Serialize("FluidNoise"       )] public GFX_GridFluidNoise FluidNoise;
		[Serialize("VelocityNoise"    )] public GFX_GridFluidNoise VelocityNoise;
		[Serialize("RefractionParam"  )] public GFX_GridFluidRefractionTex RefractionParam;
		[Serialize("EmitterFactors"   )] public GFX_GridFluidEmitterFactors EmitterFactors;
		[Serialize("LightingParam"    )] public GFX_GridFluidLightingParam LightingParam;
		[Serialize("RequiredFilter"   )] public uint RequiredFilter;
		[Serialize("RejectFilter"     )] public uint RejectFilter;
		[Serialize("RenderMode"       )] public GRDFLD RenderMode;
		[Serialize("BlendMode"        )] public GFX_BLEND BlendMode;
		[Serialize("FluidCol"         )] public Color FluidCol;
		[Serialize("ColorTex"         )] public Path ColorTex;
		[Serialize("MaskTexture"      )] public Path MaskTexture;
		[Serialize("UseRGBFluid"      )] public bool UseRGBFluid;
		[Serialize("NeutralColor"     )] public Color NeutralColor;
		[Serialize("FlowTexture"      )] public GFX_GridFluidFlowTex FlowTexture;
		[Serialize("DuDvTexture"      )] public GFX_GridFluidDuDvTex DuDvTexture;
		[Serialize("AdditionnalRender")] public CList<GFX_GridFluidAdditionnalRender> AdditionnalRender;
		[Serialize("PrimitiveParam"   )] public GFXPrimitiveParam PrimitiveParam;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(NbIter));
				SerializeField(s, nameof(PressureDiffusion));
				SerializeField(s, nameof(PressureIntensity));
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(BoxSize));
				SerializeField(s, nameof(PosOffset));
				SerializeField(s, nameof(Inertia));
				SerializeField(s, nameof(RenderOffset));
				SerializeField(s, nameof(Reinit));
				SerializeField(s, nameof(Active));
				SerializeField(s, nameof(Pause));
				SerializeField(s, nameof(AcceptOnlyOwner));
				SerializeField(s, nameof(ParticleTexSizeX));
				SerializeField(s, nameof(ParticleTexSizeY));
				SerializeField(s, nameof(SpeedTexSizeX));
				SerializeField(s, nameof(SpeedTexSizeY));
				SerializeField(s, nameof(Weight));
				SerializeField(s, nameof(Viscosity));
				SerializeField(s, nameof(FluidDiffusion));
				SerializeField(s, nameof(FluidLoss));
				SerializeField(s, nameof(ColorLoss));
				SerializeField(s, nameof(VelocityLoss));
				SerializeField(s, nameof(FluidNoise));
				SerializeField(s, nameof(VelocityNoise));
				SerializeField(s, nameof(RefractionParam));
				SerializeField(s, nameof(EmitterFactors));
				SerializeField(s, nameof(LightingParam));
				SerializeField(s, nameof(RequiredFilter));
				SerializeField(s, nameof(RejectFilter));
				SerializeField(s, nameof(RenderMode));
				SerializeField(s, nameof(BlendMode));
				SerializeField(s, nameof(FluidCol));
				SerializeField(s, nameof(ColorTex));
				SerializeField(s, nameof(MaskTexture));
				SerializeField(s, nameof(UseRGBFluid));
				SerializeField(s, nameof(NeutralColor));
				SerializeField(s, nameof(FlowTexture));
				SerializeField(s, nameof(DuDvTexture));
				SerializeField(s, nameof(AdditionnalRender));
				SerializeField(s, nameof(PrimitiveParam));
			}
		}

		public enum GRDFLD {
			[Serialize("GRDFLD_FluidTransp"       )] FluidTransp        = 0,
			[Serialize("GRDFLD_FluidOpaque"       )] FluidOpaque        = 1,
			[Serialize("GRDFLD_FluidOpaqueEmitter")] FluidOpaqueEmitter = 2,
			[Serialize("GRDFLD_Velocity"          )] Velocity           = 3,
			[Serialize("GRDFLD_VelocityEmitter"   )] VelocityEmitter    = 4,
			[Serialize("GRDFLD_Pressure"          )] Pressure           = 5,
		}
	
		public enum GFX_BLEND {
			[Serialize("GFX_BLEND_COPY"        )] COPY         = 1,
			[Serialize("GFX_BLEND_ALPHA"       )] ALPHA        = 2,
			[Serialize("GFX_BLEND_ADDALPHA"    )] ADDALPHA     = 7,
			[Serialize("GFX_BLEND_SUBALPHA"    )] SUBALPHA     = 8,
			[Serialize("GFX_BLEND_MUL"         )] MUL          = 10,
			[Serialize("GFX_BLEND_MUL2X"       )] MUL2X        = 17,
			[Serialize("GFX_BLEND_ADDSMOOTH"   )] ADDSMOOTH    = 22,
			[Serialize("GFX_BLEND_ALPHAPREMULT")] ALPHAPREMULT = 3,
		}


		public override uint? ClassCRC => 0x615DA3F8;
	}
}

