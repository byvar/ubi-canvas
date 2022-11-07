namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventActivateCheckpoint : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x413AB0C1;
	}
}

