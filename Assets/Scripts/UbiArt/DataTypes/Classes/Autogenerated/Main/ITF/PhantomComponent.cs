namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PhantomComponent : ShapeComponent {
		public CArrayP<float> depthOffsets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.VH || s.Settings.Game == Game.RA || s.Settings.Game == Game.RM) {
				depthOffsets = s.SerializeObject<CArrayP<float>>(depthOffsets, name: "depthOffsets");
			}
		}
		public override uint? ClassCRC => 0x2B541820;
	}
}

