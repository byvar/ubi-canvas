namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventDiggingGeneration : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x11F2D0AD;
	}
}

