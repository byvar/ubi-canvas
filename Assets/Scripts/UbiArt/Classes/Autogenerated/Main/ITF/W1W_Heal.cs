using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Heal : W1W_InteractiveGenComponent {
		public uint uint__0;
		public uint uint__1;
		public uint uint__2;
		public EventSender EventSender__3;
		public EventSender EventSender__4;
		public CArray<EventSender> CArray_EventSender__5;
		public CArray<EventSender> CArray_EventSender__6;
		public CArray<EventSender> CArray_EventSender__7;
		public StringID StringID__8;
		public StringID StringID__9;
		public StringID StringID__10;
		public StringID StringID__11;
		public Enum_VH_0_2 Enum_VH_0__12;
		public bool bool__13;
		public Vec2d Vector2__14;
		public Vec2d Vector2__15;
		public float float__16;
		public float float__17_2;
		public float float__18;
		public float float__19;
		public float float__20;
		public float float__21;
		public bool bool__22;
		public Enum_VH_1_2 Enum_VH_1__23;
		public Enum_VH_2 Enum_VH_2__24;
		public bool bool__25;
		public bool bool__26;
		public bool bool__27_2;
		public float float__28_2;
		public float float__29_2;
		public float float__30_2;
		public float float__31_2;
		public bool bool__32;
		public uint uint__33;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
			EventSender__3 = s.SerializeObject<EventSender>(EventSender__3, name: "EventSender__3");
			EventSender__4 = s.SerializeObject<EventSender>(EventSender__4, name: "EventSender__4");
			CArray_EventSender__5 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__5, name: "CArray_EventSender__5");
			CArray_EventSender__6 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__6, name: "CArray_EventSender__6");
			CArray_EventSender__7 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__7, name: "CArray_EventSender__7");
			StringID__8 = s.SerializeObject<StringID>(StringID__8, name: "StringID__8");
			StringID__9 = s.SerializeObject<StringID>(StringID__9, name: "StringID__9");
			StringID__10 = s.SerializeObject<StringID>(StringID__10, name: "StringID__10");
			StringID__11 = s.SerializeObject<StringID>(StringID__11, name: "StringID__11");
			Enum_VH_0__12 = s.Serialize<Enum_VH_0_2>(Enum_VH_0__12, name: "Enum_VH_0__12");
			bool__13 = s.Serialize<bool>(bool__13, name: "bool__13");
			Vector2__14 = s.SerializeObject<Vec2d>(Vector2__14, name: "Vector2__14");
			Vector2__15 = s.SerializeObject<Vec2d>(Vector2__15, name: "Vector2__15");
			float__16 = s.Serialize<float>(float__16, name: "float__16");
			float__17_2 = s.Serialize<float>(float__17_2, name: "float__17_2");
			float__18 = s.Serialize<float>(float__18, name: "float__18");
			float__19 = s.Serialize<float>(float__19, name: "float__19");
			float__20 = s.Serialize<float>(float__20, name: "float__20");
			float__21 = s.Serialize<float>(float__21, name: "float__21");
			bool__22 = s.Serialize<bool>(bool__22, name: "bool__22");
			Enum_VH_1__23 = s.Serialize<Enum_VH_1_2>(Enum_VH_1__23, name: "Enum_VH_1__23");
			Enum_VH_2__24 = s.Serialize<Enum_VH_2>(Enum_VH_2__24, name: "Enum_VH_2__24");
			bool__25 = s.Serialize<bool>(bool__25, name: "bool__25");
			bool__26 = s.Serialize<bool>(bool__26, name: "bool__26");
			bool__27_2 = s.Serialize<bool>(bool__27_2, name: "bool__27_2");
			float__28_2 = s.Serialize<float>(float__28_2, name: "float__28_2");
			float__29_2 = s.Serialize<float>(float__29_2, name: "float__29_2");
			float__30_2 = s.Serialize<float>(float__30_2, name: "float__30_2");
			float__31_2 = s.Serialize<float>(float__31_2, name: "float__31_2");
			bool__32 = s.Serialize<bool>(bool__32, name: "bool__32");
			uint__33 = s.Serialize<uint>(uint__33, name: "uint__33");
		}
		public enum Enum_VH_0_2 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_VH_1_2 {
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
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_18")] Value_18 = 18,
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_20")] Value_20 = 20,
			[Serialize("Value_21")] Value_21 = 21,
			[Serialize("Value_22")] Value_22 = 22,
			[Serialize("Value_23")] Value_23 = 23,
			[Serialize("Value_24")] Value_24 = 24,
			[Serialize("Value_25")] Value_25 = 25,
			[Serialize("Value_26")] Value_26 = 26,
			[Serialize("Value_27")] Value_27 = 27,
			[Serialize("Value_28")] Value_28 = 28,
			[Serialize("Value_29")] Value_29 = 29,
			[Serialize("Value_30")] Value_30 = 30,
			[Serialize("Value_31")] Value_31 = 31,
			[Serialize("Value_32")] Value_32 = 32,
			[Serialize("Value_33")] Value_33 = 33,
			[Serialize("Value_34")] Value_34 = 34,
			[Serialize("Value_35")] Value_35 = 35,
			[Serialize("Value_36")] Value_36 = 36,
			[Serialize("Value_37")] Value_37 = 37,
			[Serialize("Value_38")] Value_38 = 38,
			[Serialize("Value_39")] Value_39 = 39,
			[Serialize("Value_40")] Value_40 = 40,
			[Serialize("Value_41")] Value_41 = 41,
			[Serialize("Value_42")] Value_42 = 42,
			[Serialize("Value_43")] Value_43 = 43,
			[Serialize("Value_44")] Value_44 = 44,
			[Serialize("Value_45")] Value_45 = 45,
			[Serialize("Value_46")] Value_46 = 46,
			[Serialize("Value_47")] Value_47 = 47,
			[Serialize("Value_48")] Value_48 = 48,
			[Serialize("Value_49")] Value_49 = 49,
			[Serialize("Value_50")] Value_50 = 50,
			[Serialize("Value_51")] Value_51 = 51,
			[Serialize("Value_52")] Value_52 = 52,
			[Serialize("Value_53")] Value_53 = 53,
			[Serialize("Value_55")] Value_55 = 55,
			[Serialize("Value_56")] Value_56 = 56,
			[Serialize("Value_54")] Value_54 = 54,
			[Serialize("Value_58")] Value_58 = 58,
			[Serialize("Value_59")] Value_59 = 59,
			[Serialize("Value_60")] Value_60 = 60,
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0x2A80D24F;
	}
}

