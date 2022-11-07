namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class PhoenixCheckpointComponent : ActorComponent {
		public Enum_RFR_0 Enum_RFR_0__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Enum_RFR_0__0 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__0, name: "Enum_RFR_0__0");
			}
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_9")] Value_9 = 9,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x2A56289E;
	}
}

