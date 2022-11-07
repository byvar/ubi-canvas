namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Vehicle : W1W_InteractiveGenComponent {
		public uint uint__0;
		public bool bool__1;
		public Enum_VH_0_1 Enum_VH_0__2;
		public bool bool__3;
		public bool bool__4;
		public bool bool__5;
		public float float__6;
		public float float__7;
		public int int__8;
		public uint uint__9;
		public uint uint__10;
		public uint uint__11;
		public uint uint__12;
		public bool bool__13;
		public float float__14;
		public float float__15;
		public float float__16;
		public float float__17_2;
		public float float__18;
		public float float__19;
		public float float__20;
		public float float__21;
		public float float__22;
		public float float__23;
		public float float__24;
		public Path Path__25;
		public Path Path__26;
		public float float__27;
		public bool bool__28;
		public bool bool__29;
		public bool bool__30;
		public bool bool__31;
		public bool bool__32;
		public float float__33;
		public float float__34;
		public uint uint__35;
		public float float__36;
		public Enum_VH_0_2 Enum_VH_0__37;
		public EventSender EventSender__38;
		public EventSender EventSender__39;
		public EventSender EventSender__40;
		public EventSender EventSender__41;
		public EventSender EventSender__42;
		public float float__43_2;
		public float float__44_2;
		public float float__45_2;
		public float float__46_2;
		public float float__47;
		public float float__48;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				float__14 = s.Serialize<float>(float__14, name: "float__14");
				float__15 = s.Serialize<float>(float__15, name: "float__15");
				float__16 = s.Serialize<float>(float__16, name: "float__16");
				float__17_2 = s.Serialize<float>(float__17_2, name: "float__17");
				float__18 = s.Serialize<float>(float__18, name: "float__18");
				float__19 = s.Serialize<float>(float__19, name: "float__19");
				float__20 = s.Serialize<float>(float__20, name: "float__20");
				float__21 = s.Serialize<float>(float__21, name: "float__21");
				float__22 = s.Serialize<float>(float__22, name: "float__22");
				float__23 = s.Serialize<float>(float__23, name: "float__23");
				float__24 = s.Serialize<float>(float__24, name: "float__24");
				Path__25 = s.SerializeObject<Path>(Path__25, name: "Path__25");
				Path__26 = s.SerializeObject<Path>(Path__26, name: "Path__26");
				float__27 = s.Serialize<float>(float__27, name: "float__27");
				bool__28 = s.Serialize<bool>(bool__28, name: "bool__28");
				bool__29 = s.Serialize<bool>(bool__29, name: "bool__29");
				bool__30 = s.Serialize<bool>(bool__30, name: "bool__30");
				bool__31 = s.Serialize<bool>(bool__31, name: "bool__31");
				bool__32 = s.Serialize<bool>(bool__32, name: "bool__32");
				float__33 = s.Serialize<float>(float__33, name: "float__33");
				float__34 = s.Serialize<float>(float__34, name: "float__34");
				uint__35 = s.Serialize<uint>(uint__35, name: "uint__35");
				float__36 = s.Serialize<float>(float__36, name: "float__36");
				Enum_VH_0__37 = s.Serialize<Enum_VH_0_2>(Enum_VH_0__37, name: "Enum_VH_0__37");
				EventSender__38 = s.SerializeObject<EventSender>(EventSender__38, name: "EventSender__38");
				EventSender__39 = s.SerializeObject<EventSender>(EventSender__39, name: "EventSender__39");
				EventSender__40 = s.SerializeObject<EventSender>(EventSender__40, name: "EventSender__40");
				EventSender__41 = s.SerializeObject<EventSender>(EventSender__41, name: "EventSender__41");
				EventSender__42 = s.SerializeObject<EventSender>(EventSender__42, name: "EventSender__42");
				float__43_2 = s.Serialize<float>(float__43_2, name: "float__43");
				float__44_2 = s.Serialize<float>(float__44_2, name: "float__44");
				float__45_2 = s.Serialize<float>(float__45_2, name: "float__45");
				float__46_2 = s.Serialize<float>(float__46_2, name: "float__46");
				float__47 = s.Serialize<float>(float__47, name: "float__47");
				float__48 = s.Serialize<float>(float__48, name: "float__48");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				Enum_VH_0__2 = s.Serialize<Enum_VH_0_1>(Enum_VH_0__2, name: "Enum_VH_0__2");
				bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
				bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
				bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				int__8 = s.Serialize<int>(int__8, name: "int__8");
				uint__9 = s.Serialize<uint>(uint__9, name: "uint__9");
				uint__10 = s.Serialize<uint>(uint__10, name: "uint__10");
				uint__11 = s.Serialize<uint>(uint__11, name: "uint__11");
				uint__12 = s.Serialize<uint>(uint__12, name: "uint__12");
				bool__13 = s.Serialize<bool>(bool__13, name: "bool__13");
			}
		}
		public enum Enum_VH_0_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_0_2 {
			[Serialize("Value_0"  )] Value_0 = 0,
			[Serialize("Value_1"  )] Value_1 = 1,
			[Serialize("Value_2"  )] Value_2 = 2,
			[Serialize("Value_4"  )] Value_4 = 4,
			[Serialize("Value_8"  )] Value_8 = 8,
			[Serialize("Value_12" )] Value_12 = 12,
			[Serialize("Value_14" )] Value_14 = 14,
			[Serialize("Value_16" )] Value_16 = 16,
			[Serialize("Value_32" )] Value_32 = 32,
			[Serialize("Value_33" )] Value_33 = 33,
			[Serialize("Value_64" )] Value_64 = 64,
			[Serialize("Value_128")] Value_128 = 128,
			[Serialize("Value__1" )] Value__1 = -1,
		}
		public override uint? ClassCRC => 0x84019D6E;
	}
}

