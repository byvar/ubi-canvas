namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_DisguiseScreen : W1W_InteractiveGenComponent {
		public Enum_VH_0_1 Enum_VH_0__0_1;
		public Enum_VH_0_2 Enum_VH_0__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Enum_VH_0__1 = s.Serialize<Enum_VH_0_2>(Enum_VH_0__1, name: "Enum_VH_0__1");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				Enum_VH_0__0_1 = s.Serialize<Enum_VH_0_1>(Enum_VH_0__0_1, name: "Enum_VH_0__0");
			}
		}
		public enum Enum_VH_0_1 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public enum Enum_VH_0_2 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x50FC42D8;
	}
}

