namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventSaveSession : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6F9B9897;
	}
}

