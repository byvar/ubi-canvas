namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventQueryCanBeAttacked : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0xD4472ADF;
	}
}

