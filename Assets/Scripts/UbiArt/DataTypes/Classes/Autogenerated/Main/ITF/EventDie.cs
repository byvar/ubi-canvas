namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventDie : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x771044C1;
	}
}

