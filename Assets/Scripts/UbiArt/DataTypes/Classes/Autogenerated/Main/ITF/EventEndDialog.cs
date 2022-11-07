namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventEndDialog : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA16EC00D;
	}
}

