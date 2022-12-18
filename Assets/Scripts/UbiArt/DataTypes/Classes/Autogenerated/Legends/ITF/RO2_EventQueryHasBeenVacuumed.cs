namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventQueryHasBeenVacuumed : CSerializable {
		public int hasBeenVacuumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hasBeenVacuumed = s.Serialize<int>(hasBeenVacuumed, name: "hasBeenVacuumed");
		}
		public override uint? ClassCRC => 0x58E6FE8E;
	}
}

