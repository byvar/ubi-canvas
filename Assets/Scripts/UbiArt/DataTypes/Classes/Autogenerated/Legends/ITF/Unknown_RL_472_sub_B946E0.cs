namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_472_sub_B946E0 : CSerializable {
		public float distanceFromSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			distanceFromSide = s.Serialize<float>(distanceFromSide, name: "distanceFromSide");
		}
		public override uint? ClassCRC => 0xB98E4D8D;
	}
}

