namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventStartDialog : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x21FF855F;
	}
}

