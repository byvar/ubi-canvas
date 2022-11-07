namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CustomAnimComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x21A50779;
	}
}

