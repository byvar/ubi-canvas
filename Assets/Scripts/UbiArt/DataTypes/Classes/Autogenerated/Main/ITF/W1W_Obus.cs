namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Obus : ActorComponent {
		public float float__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public bool bool__7;
		public float float__8;
		public float float__9;
		public Path Path__10;
		public bool bool__11;
		public bool bool__12;
		public float float__13;
		public float float__14;
		public Angle Angle__15;
		public float float__16;
		public float float__17;
		public float float__18;
		public Vec2d Vector2__19;
		public Vec2d Vector2__20;
		public Enum_VH_0 Enum_VH_0__21;
		public Enum_VH_1 Enum_VH_1__22;
		public Enum_VH_2 Enum_VH_2__23;
		public StringID StringID__24;
		public bool bool__25;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
				float__9 = s.Serialize<float>(float__9, name: "float__9");
				Path__10 = s.SerializeObject<Path>(Path__10, name: "Path__10");
				bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
				bool__12 = s.Serialize<bool>(bool__12, name: "bool__12");
				float__13 = s.Serialize<float>(float__13, name: "float__13");
				float__14 = s.Serialize<float>(float__14, name: "float__14");
				Angle__15 = s.SerializeObject<Angle>(Angle__15, name: "Angle__15");
				float__16 = s.Serialize<float>(float__16, name: "float__16");
				float__17 = s.Serialize<float>(float__17, name: "float__17");
				float__18 = s.Serialize<float>(float__18, name: "float__18");
				Vector2__19 = s.SerializeObject<Vec2d>(Vector2__19, name: "Vector2__19");
				Vector2__20 = s.SerializeObject<Vec2d>(Vector2__20, name: "Vector2__20");
				Enum_VH_0__21 = s.Serialize<Enum_VH_0>(Enum_VH_0__21, name: "Enum_VH_0__21");
				Enum_VH_1__22 = s.Serialize<Enum_VH_1>(Enum_VH_1__22, name: "Enum_VH_1__22");
				Enum_VH_2__23 = s.Serialize<Enum_VH_2>(Enum_VH_2__23, name: "Enum_VH_2__23");
				StringID__24 = s.SerializeObject<StringID>(StringID__24, name: "StringID__24");
				bool__25 = s.Serialize<bool>(bool__25, name: "bool__25");
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_1 {
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
		public enum Enum_VH_2 {
			[Serialize("Value_0"   )] Value_0 = 0,
			[Serialize("Value_1038")] Value_1038 = 1038,
			[Serialize("Value_4"   )] Value_4 = 4,
			[Serialize("Value_2"   )] Value_2 = 2,
			[Serialize("Value_8"   )] Value_8 = 8,
		}
		public override uint? ClassCRC => 0xFB548025;
	}
}

