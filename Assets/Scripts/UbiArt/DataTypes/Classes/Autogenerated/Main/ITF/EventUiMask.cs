namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventUiMask : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6CA3E2DA;
	}
}

