namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventBreakDialog : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x86E1AA5C;
	}
}

