namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierBranchBaseRendererComponent_Template : BezierBranchComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF0076B3E;
	}
}

