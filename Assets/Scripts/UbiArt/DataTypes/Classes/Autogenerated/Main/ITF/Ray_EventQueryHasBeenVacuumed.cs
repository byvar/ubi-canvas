namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventQueryHasBeenVacuumed : Event {
		public int hasBeenVacuumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hasBeenVacuumed = s.Serialize<int>(hasBeenVacuumed, name: "hasBeenVacuumed");
		}
		public override uint? ClassCRC => 0x88EF74D6;
	}
}

