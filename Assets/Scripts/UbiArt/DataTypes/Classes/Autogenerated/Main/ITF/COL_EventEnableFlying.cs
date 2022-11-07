namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventEnableFlying : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x489E1B79;
	}
}

