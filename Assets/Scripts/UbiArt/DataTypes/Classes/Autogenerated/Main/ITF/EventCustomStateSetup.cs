namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventCustomStateSetup : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA01631D7;
	}
}

