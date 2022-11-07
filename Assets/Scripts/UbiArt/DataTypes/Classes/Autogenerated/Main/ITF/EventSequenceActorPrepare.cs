namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSequenceActorPrepare : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBD746187;
	}
}

