namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventPadRumbleStop : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x86461DD9;
	}
}

