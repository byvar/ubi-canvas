namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GridFluidModifierComponent : ActorComponent {
		public bool Reinit;
		public GFX_GridFluidModifierList FluidModifier;
		public AABB Margin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Reinit = s.Serialize<bool>(Reinit, name: "Reinit");
				FluidModifier = s.SerializeObject<GFX_GridFluidModifierList>(FluidModifier, name: "FluidModifier");
				Margin = s.SerializeObject<AABB>(Margin, name: "Margin");
			}
		}

		public override uint? ClassCRC => 0xB8D8FE0C;
	}
}

