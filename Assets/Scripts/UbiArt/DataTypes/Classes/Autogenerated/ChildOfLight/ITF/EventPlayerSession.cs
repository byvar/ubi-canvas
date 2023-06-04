namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RM)]
	public partial class EventPlayerSession : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0x72DE1623;
	}
}

