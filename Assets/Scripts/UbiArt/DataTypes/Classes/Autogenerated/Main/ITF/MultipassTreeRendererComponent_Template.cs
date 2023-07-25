namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class MultipassTreeRendererComponent_Template : GraphicComponent_Template {
		public CListO<BezierBranchRendererPass_Template> passes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			passes = s.SerializeObject<CListO<BezierBranchRendererPass_Template>>(passes, name: "passes");
		}
		public override uint? ClassCRC => 0x4DC93411;
	}
}

