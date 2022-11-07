namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventHitReceived : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2362F0BD;
	}
}

