namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventDigging : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEB41D273;
	}
}

