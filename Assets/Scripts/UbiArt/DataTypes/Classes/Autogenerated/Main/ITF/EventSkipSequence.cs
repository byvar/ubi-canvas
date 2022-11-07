namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSkipSequence : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFD335546;
	}
}

