namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSequenceActorReady : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5F6FAF29;
	}
}

