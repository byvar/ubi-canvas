using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GridFluidComponent : ActorComponent {
		public uint NbIter;
		public float PressureDiffusion;
		public float PressureIntensity;
		public Vec2d BoxSize;
		public Vec3d PosOffset;
		public float Inertia;
		public Vec3d RenderOffset;
		public bool Reinit;
		public bool Active;
		public bool Pause;
		public bool AcceptOnlyOwner;
		public ushort ParticleTexSizeX;
		public ushort ParticleTexSizeY;
		public ushort SpeedTexSizeX;
		public ushort SpeedTexSizeY;
		public float Weight;
		public float Viscosity;
		public float FluidDiffusion;
		public float FluidLoss;
		public float ColorLoss;
		public float VelocityLoss;
		public GFX_GridFluidNoise FluidNoise;
		public GFX_GridFluidNoise VelocityNoise;
		public GFX_GridFluidRefractionTex RefractionParam;
		public GFX_GridFluidEmitterFactors EmitterFactors;
		public GFX_GridFluidLightingParam LightingParam;
		public uint RequiredFilter;
		public uint RejectFilter;
		public GRDFLD RenderMode;
		public GFX_BLEND BlendMode;
		public Color FluidCol;
		public Path ColorTex;
		public Path MaskTexture;
		public bool UseRGBFluid;
		public Color NeutralColor;
		public GFX_GridFluidFlowTex FlowTexture;
		public GFX_GridFluidDuDvTex DuDvTexture;
		public CListO<GFX_GridFluidAdditionnalRender> AdditionnalRender;
		public GFXPrimitiveParam PrimitiveParam;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				NbIter = s.Serialize<uint>(NbIter, name: "NbIter");
				PressureDiffusion = s.Serialize<float>(PressureDiffusion, name: "PressureDiffusion");
				PressureIntensity = s.Serialize<float>(PressureIntensity, name: "PressureIntensity");
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				BoxSize = s.SerializeObject<Vec2d>(BoxSize, name: "BoxSize");
				PosOffset = s.SerializeObject<Vec3d>(PosOffset, name: "PosOffset");
				Inertia = s.Serialize<float>(Inertia, name: "Inertia");
				RenderOffset = s.SerializeObject<Vec3d>(RenderOffset, name: "RenderOffset");
				Reinit = s.Serialize<bool>(Reinit, name: "Reinit");
				Active = s.Serialize<bool>(Active, name: "Active");
				Pause = s.Serialize<bool>(Pause, name: "Pause");
				AcceptOnlyOwner = s.Serialize<bool>(AcceptOnlyOwner, name: "AcceptOnlyOwner");
				ParticleTexSizeX = s.Serialize<ushort>(ParticleTexSizeX, name: "ParticleTexSizeX");
				ParticleTexSizeY = s.Serialize<ushort>(ParticleTexSizeY, name: "ParticleTexSizeY");
				SpeedTexSizeX = s.Serialize<ushort>(SpeedTexSizeX, name: "SpeedTexSizeX");
				SpeedTexSizeY = s.Serialize<ushort>(SpeedTexSizeY, name: "SpeedTexSizeY");
				Weight = s.Serialize<float>(Weight, name: "Weight");
				Viscosity = s.Serialize<float>(Viscosity, name: "Viscosity");
				FluidDiffusion = s.Serialize<float>(FluidDiffusion, name: "FluidDiffusion");
				FluidLoss = s.Serialize<float>(FluidLoss, name: "FluidLoss");
				ColorLoss = s.Serialize<float>(ColorLoss, name: "ColorLoss");
				VelocityLoss = s.Serialize<float>(VelocityLoss, name: "VelocityLoss");
				FluidNoise = s.SerializeObject<GFX_GridFluidNoise>(FluidNoise, name: "FluidNoise");
				VelocityNoise = s.SerializeObject<GFX_GridFluidNoise>(VelocityNoise, name: "VelocityNoise");
				RefractionParam = s.SerializeObject<GFX_GridFluidRefractionTex>(RefractionParam, name: "RefractionParam");
				EmitterFactors = s.SerializeObject<GFX_GridFluidEmitterFactors>(EmitterFactors, name: "EmitterFactors");
				LightingParam = s.SerializeObject<GFX_GridFluidLightingParam>(LightingParam, name: "LightingParam");
				RequiredFilter = s.Serialize<uint>(RequiredFilter, name: "RequiredFilter");
				RejectFilter = s.Serialize<uint>(RejectFilter, name: "RejectFilter");
				RenderMode = s.Serialize<GRDFLD>(RenderMode, name: "RenderMode");
				BlendMode = s.Serialize<GFX_BLEND>(BlendMode, name: "BlendMode");
				FluidCol = s.SerializeObject<Color>(FluidCol, name: "FluidCol");
				ColorTex = s.SerializeObject<Path>(ColorTex, name: "ColorTex");
				MaskTexture = s.SerializeObject<Path>(MaskTexture, name: "MaskTexture");
				UseRGBFluid = s.Serialize<bool>(UseRGBFluid, name: "UseRGBFluid");
				NeutralColor = s.SerializeObject<Color>(NeutralColor, name: "NeutralColor");
				FlowTexture = s.SerializeObject<GFX_GridFluidFlowTex>(FlowTexture, name: "FlowTexture");
				DuDvTexture = s.SerializeObject<GFX_GridFluidDuDvTex>(DuDvTexture, name: "DuDvTexture");
				AdditionnalRender = s.SerializeObject<CListO<GFX_GridFluidAdditionnalRender>>(AdditionnalRender, name: "AdditionnalRender");
				PrimitiveParam = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParam, name: "PrimitiveParam");
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

