namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventCanBeVacuum : Event {
		public int canBeVaccumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			canBeVaccumed = s.Serialize<int>(canBeVaccumed, name: "canBeVaccumed");
		}
		public override uint? ClassCRC => 0x2E2C5C21;
	}
}

