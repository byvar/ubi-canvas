namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractiveObjectComponent_Template : COL_BaseInteractiveComponentNew_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x442EC083;
	}
}

