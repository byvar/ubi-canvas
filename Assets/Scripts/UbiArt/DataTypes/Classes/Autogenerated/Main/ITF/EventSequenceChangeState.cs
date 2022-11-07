namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventSequenceChangeState : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA8F041B1;
	}
}

