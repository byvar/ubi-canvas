namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventBubblePrizePicked : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3A06AC17;
	}
}

