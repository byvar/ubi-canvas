namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventCustomStateCheck : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDEAA60F6;
	}
}

