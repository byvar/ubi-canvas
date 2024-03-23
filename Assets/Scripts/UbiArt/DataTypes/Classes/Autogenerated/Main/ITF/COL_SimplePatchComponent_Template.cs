namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SimplePatchComponent_Template : PatchCurveComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1490F5D2;
	}
}

