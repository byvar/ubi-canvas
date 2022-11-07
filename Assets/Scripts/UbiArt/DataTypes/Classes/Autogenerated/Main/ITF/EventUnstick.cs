namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventUnstick : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x03385B1A;
	}
}

