namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventHighlightActor : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA80A7249;
	}
}

