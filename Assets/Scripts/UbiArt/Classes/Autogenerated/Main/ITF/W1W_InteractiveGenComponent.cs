using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_InteractiveGenComponent : ActorComponent {
		public Enum_VH_0 Enum_VH_0__0;
		public StringID StringID__1;
		public Enum_VH_1 Enum_VH_1__2;
		public StringID StringID__3;
		public StringID StringID__4;
		public StringID StringID__5;
		public StringID StringID__6;
		public Enum_VH_2 Enum_VH_2__7;
		public bool bool__8;
		public Enum_VH_3 Enum_VH_3__9;
		public float float__10;
		public float float__11;
		public float float__12;
		public float float__13;
		public bool bool__14;
		public bool bool__15;
		public bool bool__16;
		public float float__17;
		public bool bool__18;
		public bool bool__19;
		public Generic<Event> Generic_Event__20;
		public Generic<Event> Generic_Event__21;
		public EventSender EventSender__22;
		public EventSender EventSender__23;
		public EventSender EventSender__24;
		public EventSender EventSender__25;
		public uint uint__26;
		public bool bool__27;
		public float float__28;
		public float float__29;
		public float float__30;
		public float float__31;
		public float float__32;
		public bool bool__33;
		public bool bool__34;
		public bool bool__35;
		public Enum_VH_4 Enum_VH_4__36;
		public float float__37;
		public Angle Angle__38;
		public Enum_VH_5 Enum_VH_5__39;
		public bool bool__40;
		public float float__41;
		public float float__42;
		public float float__43;
		public float float__44;
		public float float__45;
		public float float__46;
		public bool bool__47;
		public bool bool__48;
		public float float__49;
		public bool bool__50;
		public bool bool__51;
		public bool bool__52;
		public bool bool__53;
		public bool bool__54;
		public float float__55;
		public bool bool__56;
		public uint uint__57;
		public float float__58;
		public float float__59;
		public Enum_VH_5 Enum_VH_5__60;
		public Vec2d Vector2__61;
		public bool bool__62;
		public Enum_VH_6 Enum_VH_6__63;
		public bool bool__64;
		public Enum_VH_7 Enum_VH_7__65;
		public float float__66;
		public Path Path__67;
		public float float__68;
		public float float__69;
		public float float__70;
		public float float__71;
		public float float__72;
		public float float__73;
		public Vec2d Vector2__74;
		public float float__75;
		public Enum_VH_8 Enum_VH_8__76;
		public Enum_VH_9 Enum_VH_9__77;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			Enum_VH_1__2 = s.Serialize<Enum_VH_1>(Enum_VH_1__2, name: "Enum_VH_1__2");
			StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
			StringID__4 = s.SerializeObject<StringID>(StringID__4, name: "StringID__4");
			StringID__5 = s.SerializeObject<StringID>(StringID__5, name: "StringID__5");
			StringID__6 = s.SerializeObject<StringID>(StringID__6, name: "StringID__6");
			Enum_VH_2__7 = s.Serialize<Enum_VH_2>(Enum_VH_2__7, name: "Enum_VH_2__7");
			bool__8 = s.Serialize<bool>(bool__8, name: "bool__8");
			Enum_VH_3__9 = s.Serialize<Enum_VH_3>(Enum_VH_3__9, name: "Enum_VH_3__9");
			float__10 = s.Serialize<float>(float__10, name: "float__10");
			float__11 = s.Serialize<float>(float__11, name: "float__11");
			float__12 = s.Serialize<float>(float__12, name: "float__12");
			float__13 = s.Serialize<float>(float__13, name: "float__13");
			bool__14 = s.Serialize<bool>(bool__14, name: "bool__14");
			bool__15 = s.Serialize<bool>(bool__15, name: "bool__15");
			bool__16 = s.Serialize<bool>(bool__16, name: "bool__16");
			float__17 = s.Serialize<float>(float__17, name: "float__17");
			bool__18 = s.Serialize<bool>(bool__18, name: "bool__18");
			bool__19 = s.Serialize<bool>(bool__19, name: "bool__19");
			Generic_Event__20 = s.SerializeObject<Generic<Event>>(Generic_Event__20, name: "Generic_Event__20");
			Generic_Event__21 = s.SerializeObject<Generic<Event>>(Generic_Event__21, name: "Generic_Event__21");
			EventSender__22 = s.SerializeObject<EventSender>(EventSender__22, name: "EventSender__22");
			EventSender__23 = s.SerializeObject<EventSender>(EventSender__23, name: "EventSender__23");
			EventSender__24 = s.SerializeObject<EventSender>(EventSender__24, name: "EventSender__24");
			EventSender__25 = s.SerializeObject<EventSender>(EventSender__25, name: "EventSender__25");
			uint__26 = s.Serialize<uint>(uint__26, name: "uint__26");
			bool__27 = s.Serialize<bool>(bool__27, name: "bool__27");
			float__28 = s.Serialize<float>(float__28, name: "float__28");
			float__29 = s.Serialize<float>(float__29, name: "float__29");
			float__30 = s.Serialize<float>(float__30, name: "float__30");
			float__31 = s.Serialize<float>(float__31, name: "float__31");
			float__32 = s.Serialize<float>(float__32, name: "float__32");
			bool__33 = s.Serialize<bool>(bool__33, name: "bool__33");
			bool__34 = s.Serialize<bool>(bool__34, name: "bool__34");
			bool__35 = s.Serialize<bool>(bool__35, name: "bool__35");
			Enum_VH_4__36 = s.Serialize<Enum_VH_4>(Enum_VH_4__36, name: "Enum_VH_4__36");
			float__37 = s.Serialize<float>(float__37, name: "float__37");
			Angle__38 = s.SerializeObject<Angle>(Angle__38, name: "Angle__38");
			Enum_VH_5__39 = s.Serialize<Enum_VH_5>(Enum_VH_5__39, name: "Enum_VH_5__39");
			bool__40 = s.Serialize<bool>(bool__40, name: "bool__40");
			float__41 = s.Serialize<float>(float__41, name: "float__41");
			float__42 = s.Serialize<float>(float__42, name: "float__42");
			float__43 = s.Serialize<float>(float__43, name: "float__43");
			float__44 = s.Serialize<float>(float__44, name: "float__44");
			float__45 = s.Serialize<float>(float__45, name: "float__45");
			float__46 = s.Serialize<float>(float__46, name: "float__46");
			bool__47 = s.Serialize<bool>(bool__47, name: "bool__47");
			bool__48 = s.Serialize<bool>(bool__48, name: "bool__48");
			float__49 = s.Serialize<float>(float__49, name: "float__49");
			bool__50 = s.Serialize<bool>(bool__50, name: "bool__50");
			bool__51 = s.Serialize<bool>(bool__51, name: "bool__51");
			bool__52 = s.Serialize<bool>(bool__52, name: "bool__52");
			bool__53 = s.Serialize<bool>(bool__53, name: "bool__53");
			bool__54 = s.Serialize<bool>(bool__54, name: "bool__54");
			float__55 = s.Serialize<float>(float__55, name: "float__55");
			bool__56 = s.Serialize<bool>(bool__56, name: "bool__56");
			uint__57 = s.Serialize<uint>(uint__57, name: "uint__57");
			float__58 = s.Serialize<float>(float__58, name: "float__58");
			float__59 = s.Serialize<float>(float__59, name: "float__59");
			Enum_VH_5__60 = s.Serialize<Enum_VH_5>(Enum_VH_5__60, name: "Enum_VH_5__60");
			Vector2__61 = s.SerializeObject<Vec2d>(Vector2__61, name: "Vector2__61");
			bool__62 = s.Serialize<bool>(bool__62, name: "bool__62");
			Enum_VH_6__63 = s.Serialize<Enum_VH_6>(Enum_VH_6__63, name: "Enum_VH_6__63");
			bool__64 = s.Serialize<bool>(bool__64, name: "bool__64");
			Enum_VH_7__65 = s.Serialize<Enum_VH_7>(Enum_VH_7__65, name: "Enum_VH_7__65");
			float__66 = s.Serialize<float>(float__66, name: "float__66");
			Path__67 = s.SerializeObject<Path>(Path__67, name: "Path__67");
			float__68 = s.Serialize<float>(float__68, name: "float__68");
			float__69 = s.Serialize<float>(float__69, name: "float__69");
			float__70 = s.Serialize<float>(float__70, name: "float__70");
			float__71 = s.Serialize<float>(float__71, name: "float__71");
			float__72 = s.Serialize<float>(float__72, name: "float__72");
			float__73 = s.Serialize<float>(float__73, name: "float__73");
			Vector2__74 = s.SerializeObject<Vec2d>(Vector2__74, name: "Vector2__74");
			float__75 = s.Serialize<float>(float__75, name: "float__75");
			Enum_VH_8__76 = s.Serialize<Enum_VH_8>(Enum_VH_8__76, name: "Enum_VH_8__76");
			Enum_VH_9__77 = s.Serialize<Enum_VH_9>(Enum_VH_9__77, name: "Enum_VH_9__77");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_18")] Value_18 = 18,
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_20")] Value_20 = 20,
			[Serialize("Value_21")] Value_21 = 21,
			[Serialize("Value_22")] Value_22 = 22,
			[Serialize("Value_23")] Value_23 = 23,
			[Serialize("Value_24")] Value_24 = 24,
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
		public enum Enum_VH_2 {
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_3 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_VH_4 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_VH_5 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_VH_6 {
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
		}
		public enum Enum_VH_7 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
		}
		public enum Enum_VH_8 {
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
		public enum Enum_VH_9 {
			[Serialize("Value__1")] Value__1 = -1,
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
		}
		public override uint? ClassCRC => 0x0192CEB0;
	}
}

