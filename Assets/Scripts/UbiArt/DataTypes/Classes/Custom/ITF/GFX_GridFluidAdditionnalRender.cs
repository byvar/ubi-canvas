namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GFX_GridFluidAdditionnalRender : CSerializable {
		public Vec3d RenderOffset;
		public Color FluidCol;
		public Path ColorTex;
		public GFX_BLEND BlendMode;
		public GFX_GridFluidFlowTex FlowTexture;
		public GFX_GridFluidDuDvTex DuDvTexture;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				RenderOffset = s.SerializeObject<Vec3d>(RenderOffset, name: "RenderOffset");
				FluidCol = s.SerializeObject<Color>(FluidCol, name: "FluidCol");
				ColorTex = s.SerializeObject<Path>(ColorTex, name: "ColorTex");
				BlendMode = s.Serialize<GFX_BLEND>(BlendMode, name: "BlendMode");
				FlowTexture = s.SerializeObject<GFX_GridFluidFlowTex>(FlowTexture, name: "FlowTexture");
				DuDvTexture = s.SerializeObject<GFX_GridFluidDuDvTex>(DuDvTexture, name: "DuDvTexture");
			}
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
		public override uint? ClassCRC => 0xD0ECFF81;
	}
}

