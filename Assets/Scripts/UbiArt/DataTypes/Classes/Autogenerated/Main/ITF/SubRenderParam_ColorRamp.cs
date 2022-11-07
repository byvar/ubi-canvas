namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SubRenderParam_ColorRamp : SubRenderParam {
		public Path ColorRampPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ColorRampPath = s.SerializeObject<Path>(ColorRampPath, name: "ColorRampPath");
		}
		public override uint? ClassCRC => 0x1B6979E9;
	}
}

