namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_470_sub_B94660 : CSerializable {
		public Placeholder stepDamageList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stepDamageList = s.SerializeObject<Placeholder>(stepDamageList, name: "stepDamageList");
		}
		public override uint? ClassCRC => 0x8F9D3BCF;
	}
}

