namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventWaitForActor : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x339EE4AA;
	}
}

