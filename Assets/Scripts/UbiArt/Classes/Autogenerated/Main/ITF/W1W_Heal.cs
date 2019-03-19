using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Heal : W1W_InteractiveGenComponent {
		[Serialize("uint__0"               )] public uint uint__0;
		[Serialize("uint__1"               )] public uint uint__1;
		[Serialize("uint__2"               )] public uint uint__2;
		[Serialize("EventSender__3"        )] public EventSender EventSender__3;
		[Serialize("EventSender__4"        )] public EventSender EventSender__4;
		[Serialize("CArray<EventSender>__5")] public CArray<EventSender> CArray_EventSender__5;
		[Serialize("CArray<EventSender>__6")] public CArray<EventSender> CArray_EventSender__6;
		[Serialize("CArray<EventSender>__7")] public CArray<EventSender> CArray_EventSender__7;
		[Serialize("StringID__8"           )] public StringID StringID__8;
		[Serialize("StringID__9"           )] public StringID StringID__9;
		[Serialize("StringID__10"          )] public StringID StringID__10;
		[Serialize("StringID__11"          )] public StringID StringID__11;
		[Serialize("Enum_VH_0__12"         )] public Enum_VH_0_2 Enum_VH_0__12;
		[Serialize("bool__13"              )] public bool bool__13;
		[Serialize("Vector2__14"           )] public Vector2 Vector2__14;
		[Serialize("Vector2__15"           )] public Vector2 Vector2__15;
		[Serialize("float__16"             )] public float float__16;
		[Serialize("float__17"             )] public float float__17_2;
		[Serialize("float__18"             )] public float float__18;
		[Serialize("float__19"             )] public float float__19;
		[Serialize("float__20"             )] public float float__20;
		[Serialize("float__21"             )] public float float__21;
		[Serialize("bool__22"              )] public bool bool__22;
		[Serialize("Enum_VH_1__23"         )] public Enum_VH_1_2 Enum_VH_1__23;
		[Serialize("Enum_VH_2__24"         )] public Enum_VH_2 Enum_VH_2__24;
		[Serialize("bool__25"              )] public bool bool__25;
		[Serialize("bool__26"              )] public bool bool__26;
		[Serialize("bool__27"              )] public bool bool__27_2;
		[Serialize("float__28"             )] public float float__28_2;
		[Serialize("float__29"             )] public float float__29_2;
		[Serialize("float__30"             )] public float float__30_2;
		[Serialize("float__31"             )] public float float__31_2;
		[Serialize("bool__32"              )] public bool bool__32;
		[Serialize("uint__33"              )] public uint uint__33;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(uint__2));
			SerializeField(s, nameof(EventSender__3));
			SerializeField(s, nameof(EventSender__4));
			SerializeField(s, nameof(CArray_EventSender__5));
			SerializeField(s, nameof(CArray_EventSender__6));
			SerializeField(s, nameof(CArray_EventSender__7));
			SerializeField(s, nameof(StringID__8));
			SerializeField(s, nameof(StringID__9));
			SerializeField(s, nameof(StringID__10));
			SerializeField(s, nameof(StringID__11));
			SerializeField(s, nameof(Enum_VH_0__12));
			SerializeField(s, nameof(bool__13));
			SerializeField(s, nameof(Vector2__14));
			SerializeField(s, nameof(Vector2__15));
			SerializeField(s, nameof(float__16));
			SerializeField(s, nameof(float__17_2));
			SerializeField(s, nameof(float__18));
			SerializeField(s, nameof(float__19));
			SerializeField(s, nameof(float__20));
			SerializeField(s, nameof(float__21));
			SerializeField(s, nameof(bool__22));
			SerializeField(s, nameof(Enum_VH_1__23));
			SerializeField(s, nameof(Enum_VH_2__24));
			SerializeField(s, nameof(bool__25));
			SerializeField(s, nameof(bool__26));
			SerializeField(s, nameof(bool__27_2));
			SerializeField(s, nameof(float__28_2));
			SerializeField(s, nameof(float__29_2));
			SerializeField(s, nameof(float__30_2));
			SerializeField(s, nameof(float__31_2));
			SerializeField(s, nameof(bool__32));
			SerializeField(s, nameof(uint__33));
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

