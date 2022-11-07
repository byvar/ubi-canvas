namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventDisableDRCInteraction : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x97F35493;
	}
}

