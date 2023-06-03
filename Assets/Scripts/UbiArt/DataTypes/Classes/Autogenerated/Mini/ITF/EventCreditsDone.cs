namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventCreditsDone : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF7EF62A8;
	}
}

