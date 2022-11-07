namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Weapon : W1W_InteractiveGenComponent {
		public bool bool__0;
		public bool bool__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public Path Path__6;
		public Path Path__7;
		public float float__8;
		public Enum_VH_0_ Enum_VH_0__9;
		public Enum_VH_1_ Enum_VH_1__10;
		public bool bool__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				Path__6 = s.SerializeObject<Path>(Path__6, name: "Path__6");
				Path__7 = s.SerializeObject<Path>(Path__7, name: "Path__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
				Enum_VH_0__9 = s.Serialize<Enum_VH_0_>(Enum_VH_0__9, name: "Enum_VH_0__9");
				Enum_VH_1__10 = s.Serialize<Enum_VH_1_>(Enum_VH_1__10, name: "Enum_VH_1__10");
				bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
			}
		}
		public enum Enum_VH_0_ {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_1_ {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
		}
		public override uint? ClassCRC => 0xBAB6B8D2;
	}
}

