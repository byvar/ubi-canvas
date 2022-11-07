namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventStopMoving : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0F79B036;
	}
}

