namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventGhostTrigger : Event {
		public uint recordType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			recordType = s.Serialize<uint>(recordType, name: "recordType");
		}
		public override uint? ClassCRC => 0x7130EB99;
	}
}

