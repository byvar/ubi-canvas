namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGameOver : Event {
		public Enum_VH_0 Enum_VH_0__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0x7F0105E0;
	}
}

