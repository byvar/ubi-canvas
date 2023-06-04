namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventStopSession : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE4CE2AD1;
	}
}

