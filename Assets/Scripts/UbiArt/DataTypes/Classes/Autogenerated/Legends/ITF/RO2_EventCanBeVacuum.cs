namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventCanBeVacuum : CSerializable {
		public int canBeVaccumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			canBeVaccumed = s.Serialize<int>(canBeVaccumed, name: "canBeVaccumed");
		}
		public override uint? ClassCRC => 0xCCA2EAC8;
	}
}

