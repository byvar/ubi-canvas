namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidObjParam : CSerializable {
		public bool BasicRender = true;
		public float EmitterIntensity = 1f;
		public GFX_GRID_MOD_MODE Mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			BasicRender = s.Serialize<bool>(BasicRender, name: "BasicRender");
			EmitterIntensity = s.Serialize<float>(EmitterIntensity, name: "EmitterIntensity");
			Mode = s.Serialize<GFX_GRID_MOD_MODE>(Mode, name: "Mode");
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

