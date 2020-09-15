using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_InteractiveGenComponent : ActorComponent {
		[Serialize("Enum_VH_0__0"      )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("StringID__1"       )] public StringID StringID__1;
		[Serialize("Enum_VH_1__2"      )] public Enum_VH_1 Enum_VH_1__2;
		[Serialize("StringID__3"       )] public StringID StringID__3;
		[Serialize("StringID__4"       )] public StringID StringID__4;
		[Serialize("StringID__5"       )] public StringID StringID__5;
		[Serialize("StringID__6"       )] public StringID StringID__6;
		[Serialize("Enum_VH_2__7"      )] public Enum_VH_2 Enum_VH_2__7;
		[Serialize("bool__8"           )] public bool bool__8;
		[Serialize("Enum_VH_3__9"      )] public Enum_VH_3 Enum_VH_3__9;
		[Serialize("float__10"         )] public float float__10;
		[Serialize("float__11"         )] public float float__11;
		[Serialize("float__12"         )] public float float__12;
		[Serialize("float__13"         )] public float float__13;
		[Serialize("bool__14"          )] public bool bool__14;
		[Serialize("bool__15"          )] public bool bool__15;
		[Serialize("bool__16"          )] public bool bool__16;
		[Serialize("float__17"         )] public float float__17;
		[Serialize("bool__18"          )] public bool bool__18;
		[Serialize("bool__19"          )] public bool bool__19;
		[Serialize("Generic<Event>__20")] public Generic<Event> Generic_Event__20;
		[Serialize("Generic<Event>__21")] public Generic<Event> Generic_Event__21;
		[Serialize("EventSender__22"   )] public EventSender EventSender__22;
		[Serialize("EventSender__23"   )] public EventSender EventSender__23;
		[Serialize("EventSender__24"   )] public EventSender EventSender__24;
		[Serialize("EventSender__25"   )] public EventSender EventSender__25;
		[Serialize("uint__26"          )] public uint uint__26;
		[Serialize("bool__27"          )] public bool bool__27;
		[Serialize("float__28"         )] public float float__28;
		[Serialize("float__29"         )] public float float__29;
		[Serialize("float__30"         )] public float float__30;
		[Serialize("float__31"         )] public float float__31;
		[Serialize("float__32"         )] public float float__32;
		[Serialize("bool__33"          )] public bool bool__33;
		[Serialize("bool__34"          )] public bool bool__34;
		[Serialize("bool__35"          )] public bool bool__35;
		[Serialize("Enum_VH_4__36"     )] public Enum_VH_4 Enum_VH_4__36;
		[Serialize("float__37"         )] public float float__37;
		[Serialize("Angle__38"         )] public Angle Angle__38;
		[Serialize("Enum_VH_5__39"     )] public Enum_VH_5 Enum_VH_5__39;
		[Serialize("bool__40"          )] public bool bool__40;
		[Serialize("float__41"         )] public float float__41;
		[Serialize("float__42"         )] public float float__42;
		[Serialize("float__43"         )] public float float__43;
		[Serialize("float__44"         )] public float float__44;
		[Serialize("float__45"         )] public float float__45;
		[Serialize("float__46"         )] public float float__46;
		[Serialize("bool__47"          )] public bool bool__47;
		[Serialize("bool__48"          )] public bool bool__48;
		[Serialize("float__49"         )] public float float__49;
		[Serialize("bool__50"          )] public bool bool__50;
		[Serialize("bool__51"          )] public bool bool__51;
		[Serialize("bool__52"          )] public bool bool__52;
		[Serialize("bool__53"          )] public bool bool__53;
		[Serialize("bool__54"          )] public bool bool__54;
		[Serialize("float__55"         )] public float float__55;
		[Serialize("bool__56"          )] public bool bool__56;
		[Serialize("uint__57"          )] public uint uint__57;
		[Serialize("float__58"         )] public float float__58;
		[Serialize("float__59"         )] public float float__59;
		[Serialize("Enum_VH_5__60"     )] public Enum_VH_5 Enum_VH_5__60;
		[Serialize("Vector2__61"       )] public Vec2d Vector2__61;
		[Serialize("bool__62"          )] public bool bool__62;
		[Serialize("Enum_VH_6__63"     )] public Enum_VH_6 Enum_VH_6__63;
		[Serialize("bool__64"          )] public bool bool__64;
		[Serialize("Enum_VH_7__65"     )] public Enum_VH_7 Enum_VH_7__65;
		[Serialize("float__66"         )] public float float__66;
		[Serialize("Path__67"          )] public Path Path__67;
		[Serialize("float__68"         )] public float float__68;
		[Serialize("float__69"         )] public float float__69;
		[Serialize("float__70"         )] public float float__70;
		[Serialize("float__71"         )] public float float__71;
		[Serialize("float__72"         )] public float float__72;
		[Serialize("float__73"         )] public float float__73;
		[Serialize("Vector2__74"       )] public Vec2d Vector2__74;
		[Serialize("float__75"         )] public float float__75;
		[Serialize("Enum_VH_8__76"     )] public Enum_VH_8 Enum_VH_8__76;
		[Serialize("Enum_VH_9__77"     )] public Enum_VH_9 Enum_VH_9__77;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_VH_0__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(Enum_VH_1__2));
			SerializeField(s, nameof(StringID__3));
			SerializeField(s, nameof(StringID__4));
			SerializeField(s, nameof(StringID__5));
			SerializeField(s, nameof(StringID__6));
			SerializeField(s, nameof(Enum_VH_2__7));
			SerializeField(s, nameof(bool__8));
			SerializeField(s, nameof(Enum_VH_3__9));
			SerializeField(s, nameof(float__10));
			SerializeField(s, nameof(float__11));
			SerializeField(s, nameof(float__12));
			SerializeField(s, nameof(float__13));
			SerializeField(s, nameof(bool__14));
			SerializeField(s, nameof(bool__15));
			SerializeField(s, nameof(bool__16));
			SerializeField(s, nameof(float__17));
			SerializeField(s, nameof(bool__18));
			SerializeField(s, nameof(bool__19));
			SerializeField(s, nameof(Generic_Event__20));
			SerializeField(s, nameof(Generic_Event__21));
			SerializeField(s, nameof(EventSender__22));
			SerializeField(s, nameof(EventSender__23));
			SerializeField(s, nameof(EventSender__24));
			SerializeField(s, nameof(EventSender__25));
			SerializeField(s, nameof(uint__26));
			SerializeField(s, nameof(bool__27));
			SerializeField(s, nameof(float__28));
			SerializeField(s, nameof(float__29));
			SerializeField(s, nameof(float__30));
			SerializeField(s, nameof(float__31));
			SerializeField(s, nameof(float__32));
			SerializeField(s, nameof(bool__33));
			SerializeField(s, nameof(bool__34));
			SerializeField(s, nameof(bool__35));
			SerializeField(s, nameof(Enum_VH_4__36));
			SerializeField(s, nameof(float__37));
			SerializeField(s, nameof(Angle__38));
			SerializeField(s, nameof(Enum_VH_5__39));
			SerializeField(s, nameof(bool__40));
			SerializeField(s, nameof(float__41));
			SerializeField(s, nameof(float__42));
			SerializeField(s, nameof(float__43));
			SerializeField(s, nameof(float__44));
			SerializeField(s, nameof(float__45));
			SerializeField(s, nameof(float__46));
			SerializeField(s, nameof(bool__47));
			SerializeField(s, nameof(bool__48));
			SerializeField(s, nameof(float__49));
			SerializeField(s, nameof(bool__50));
			SerializeField(s, nameof(bool__51));
			SerializeField(s, nameof(bool__52));
			SerializeField(s, nameof(bool__53));
			SerializeField(s, nameof(bool__54));
			SerializeField(s, nameof(float__55));
			SerializeField(s, nameof(bool__56));
			SerializeField(s, nameof(uint__57));
			SerializeField(s, nameof(float__58));
			SerializeField(s, nameof(float__59));
			SerializeField(s, nameof(Enum_VH_5__60));
			SerializeField(s, nameof(Vector2__61));
			SerializeField(s, nameof(bool__62));
			SerializeField(s, nameof(Enum_VH_6__63));
			SerializeField(s, nameof(bool__64));
			SerializeField(s, nameof(Enum_VH_7__65));
			SerializeField(s, nameof(float__66));
			SerializeField(s, nameof(Path__67));
			SerializeField(s, nameof(float__68));
			SerializeField(s, nameof(float__69));
			SerializeField(s, nameof(float__70));
			SerializeField(s, nameof(float__71));
			SerializeField(s, nameof(float__72));
			SerializeField(s, nameof(float__73));
			SerializeField(s, nameof(Vector2__74));
			SerializeField(s, nameof(float__75));
			SerializeField(s, nameof(Enum_VH_8__76));
			SerializeField(s, nameof(Enum_VH_9__77));
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

