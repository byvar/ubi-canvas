namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventStartSession : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7CE748C6;
	}
}

