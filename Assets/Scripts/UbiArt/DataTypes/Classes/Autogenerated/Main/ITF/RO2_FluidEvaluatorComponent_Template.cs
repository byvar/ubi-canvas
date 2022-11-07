namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_FluidEvaluatorComponent_Template : ActorComponent_Template {
		public bool DrawRasterization;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DrawRasterization = s.Serialize<bool>(DrawRasterization, name: "DrawRasterization");
		}
		public override uint? ClassCRC => 0x22232221;
	}
}

