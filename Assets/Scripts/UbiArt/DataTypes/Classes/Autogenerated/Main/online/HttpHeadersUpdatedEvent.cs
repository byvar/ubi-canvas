namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class HttpHeadersUpdatedEvent : ITF.Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x93936BAB;
	}
}

