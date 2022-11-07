namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventPauseMenu : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3309A7C6;
	}
}

