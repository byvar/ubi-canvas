namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventDestroyRequest : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1E7663EF;
	}
}

