using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFX_GridFluidObjParam : CSerializable {
		[Serialize("BasicRender"     )] public bool BasicRender;
		[Serialize("EmitterIntensity")] public float EmitterIntensity;
		[Serialize("Mode"            )] public GFX_GRID_MOD_MODE Mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(BasicRender));
			SerializeField(s, nameof(EmitterIntensity));
			SerializeField(s, nameof(Mode));
		}
		public enum GFX_GRID_MOD_MODE {
			[Serialize("GFX_GRID_MOD_MODE_NONE"       )] NONE = 0,
			[Serialize("GFX_GRID_MOD_MODE_FLUID"      )] FLUID = 1,
			[Serialize("GFX_GRID_MOD_MODE_FORCE"      )] FORCE = 2,
			[Serialize("GFX_GRID_MOD_MODE_BLOCKER"    )] BLOCKER = 4,
			[Serialize("GFX_GRID_MOD_MODE_FLUID_FORCE")] FLUID_FORCE = 3,
		}
	}
}

