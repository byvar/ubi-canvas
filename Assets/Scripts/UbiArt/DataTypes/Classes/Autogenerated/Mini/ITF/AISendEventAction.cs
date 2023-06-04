namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AISendEventAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA579F4D8;
	}
}

