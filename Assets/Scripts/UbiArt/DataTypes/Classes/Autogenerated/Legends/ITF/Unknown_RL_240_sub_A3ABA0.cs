namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_240_sub_A3ABA0 : CSerializable {
		public int influenced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			influenced = s.Serialize<int>(influenced, name: "influenced");
		}
		public override uint? ClassCRC => 0xB6919914;
	}
}

