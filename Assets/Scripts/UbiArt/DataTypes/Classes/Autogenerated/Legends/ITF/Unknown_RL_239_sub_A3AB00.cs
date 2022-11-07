namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_239_sub_A3AB00 : CSerializable {
		public int canBeVaccumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			canBeVaccumed = s.Serialize<int>(canBeVaccumed, name: "canBeVaccumed");
		}
		public override uint? ClassCRC => 0xCCA2EAC8;
	}
}

