using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidAdditionnalRender : CSerializable {
		[Serialize("RenderOffset"     )] public Vector3 RenderOffset;
		[Serialize("FluidCol"         )] public Color FluidCol;
		[Serialize("ColorTex"         )] public Path ColorTex;
		[Serialize("BlendMode"        )] public GFX_BLEND BlendMode;
		[Serialize("FlowTexture"      )] public GFX_GridFluidFlowTex FlowTexture;
		[Serialize("DuDvTexture"      )] public GFX_GridFluidDuDvTex DuDvTexture;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(RenderOffset));
				SerializeField(s, nameof(FluidCol));
				SerializeField(s, nameof(ColorTex));
				SerializeField(s, nameof(BlendMode));
				SerializeField(s, nameof(FlowTexture));
				SerializeField(s, nameof(DuDvTexture));
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
	}
}

