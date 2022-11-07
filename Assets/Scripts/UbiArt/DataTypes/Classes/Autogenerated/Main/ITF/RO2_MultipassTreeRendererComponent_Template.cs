namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_MultipassTreeRendererComponent_Template : GraphicComponent_Template {
		public CListO<RO2_BezierBranchRendererPass_Template> passes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			passes = s.SerializeObject<CListO<RO2_BezierBranchRendererPass_Template>>(passes, name: "passes");
		}
		public override uint? ClassCRC => 0x3D64B146;
	}
}

