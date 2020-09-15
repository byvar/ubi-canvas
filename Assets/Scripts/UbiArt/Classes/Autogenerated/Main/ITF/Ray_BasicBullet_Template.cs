using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_BasicBullet_Template : CSerializable {
		[Serialize("Generic<PhysShape>__0" )] public Generic<PhysShape> Generic_PhysShape__0;
		[Serialize("Enum_RJR_0__1"         )] public Enum_RJR_0 Enum_RJR_0__1;
		[Serialize("float__2"              )] public float float__2;
		[Serialize("uint__3"               )] public uint uint__3;
		[Serialize("int__4"                )] public int int__4;
		[Serialize("Enum_RJR_1__5"         )] public Enum_RJR_1 Enum_RJR_1__5;
		[Serialize("uint__6"               )] public uint uint__6;
		[Serialize("int__7"                )] public int int__7;
		[Serialize("int__8"                )] public int int__8;
		[Serialize("int__9"                )] public int int__9;
		[Serialize("int__10"               )] public int int__10;
		[Serialize("Vector2__11"           )] public Vec2d Vector2__11;
		[Serialize("float__12"             )] public float float__12;
		[Serialize("int__13"               )] public int int__13;
		[Serialize("uint__14"              )] public uint uint__14;
		[Serialize("int__15"               )] public int int__15;
		[Serialize("int__16"               )] public int int__16;
		[Serialize("float__17"             )] public float float__17;
		[Serialize("float__18"             )] public float float__18;
		[Serialize("float__19"             )] public float float__19;
		[Serialize("Angle__20"             )] public Angle Angle__20;
		[Serialize("StringID__21"          )] public StringID StringID__21;
		[Serialize("StringID__22"          )] public StringID StringID__22;
		[Serialize("StringID__23"          )] public StringID StringID__23;
		[Serialize("StringID__24"          )] public StringID StringID__24;
		[Serialize("int__25"               )] public int int__25;
		[Serialize("Generic<PhysShape>__26")] public Generic<PhysShape> Generic_PhysShape__26;
		[Serialize("Enum_RFR_0__27"        )] public Enum_RFR_0 Enum_RFR_0__27;
		[Serialize("float__28"             )] public float float__28;
		[Serialize("uint__29"              )] public uint uint__29;
		[Serialize("int__30"               )] public int int__30;
		[Serialize("Enum_RFR_1__31"        )] public Enum_RFR_1 Enum_RFR_1__31;
		[Serialize("uint__32"              )] public uint uint__32;
		[Serialize("int__33"               )] public int int__33;
		[Serialize("int__34"               )] public int int__34;
		[Serialize("int__35"               )] public int int__35;
		[Serialize("int__36"               )] public int int__36;
		[Serialize("Vector2__37"           )] public Vec2d Vector2__37;
		[Serialize("float__38"             )] public float float__38;
		[Serialize("int__39"               )] public int int__39;
		[Serialize("uint__40"              )] public uint uint__40;
		[Serialize("int__41"               )] public int int__41;
		[Serialize("int__42"               )] public int int__42;
		[Serialize("float__43"             )] public float float__43;
		[Serialize("float__44"             )] public float float__44;
		[Serialize("float__45"             )] public float float__45;
		[Serialize("Angle__46"             )] public Angle Angle__46;
		[Serialize("StringID__47"          )] public StringID StringID__47;
		[Serialize("StringID__48"          )] public StringID StringID__48;
		[Serialize("StringID__49"          )] public StringID StringID__49;
		[Serialize("StringID__50"          )] public StringID StringID__50;
		[Serialize("int__51"               )] public int int__51;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Generic_PhysShape__26));
				SerializeField(s, nameof(Enum_RFR_0__27));
				SerializeField(s, nameof(float__28));
				SerializeField(s, nameof(uint__29));
				SerializeField(s, nameof(int__30));
				SerializeField(s, nameof(Enum_RFR_1__31));
				SerializeField(s, nameof(uint__32));
				SerializeField(s, nameof(int__33));
				SerializeField(s, nameof(int__34));
				SerializeField(s, nameof(int__35));
				SerializeField(s, nameof(int__36));
				SerializeField(s, nameof(Vector2__37));
				SerializeField(s, nameof(float__38));
				SerializeField(s, nameof(int__39));
				SerializeField(s, nameof(uint__40));
				SerializeField(s, nameof(int__41));
				SerializeField(s, nameof(int__42));
				SerializeField(s, nameof(float__43));
				SerializeField(s, nameof(float__44));
				SerializeField(s, nameof(float__45));
				SerializeField(s, nameof(Angle__46));
				SerializeField(s, nameof(StringID__47));
				SerializeField(s, nameof(StringID__48));
				SerializeField(s, nameof(StringID__49));
				SerializeField(s, nameof(StringID__50));
				SerializeField(s, nameof(int__51));
			} else {
				SerializeField(s, nameof(Generic_PhysShape__0));
				SerializeField(s, nameof(Enum_RJR_0__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(uint__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(Enum_RJR_1__5));
				SerializeField(s, nameof(uint__6));
				SerializeField(s, nameof(int__7));
				SerializeField(s, nameof(int__8));
				SerializeField(s, nameof(int__9));
				SerializeField(s, nameof(int__10));
				SerializeField(s, nameof(Vector2__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(int__13));
				SerializeField(s, nameof(uint__14));
				SerializeField(s, nameof(int__15));
				SerializeField(s, nameof(int__16));
				SerializeField(s, nameof(float__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(float__19));
				SerializeField(s, nameof(Angle__20));
				SerializeField(s, nameof(StringID__21));
				SerializeField(s, nameof(StringID__22));
				SerializeField(s, nameof(StringID__23));
				SerializeField(s, nameof(StringID__24));
				SerializeField(s, nameof(int__25));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value__1")] Value__1 = -1,
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
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_20")] Value_20 = 20,
			[Serialize("Value_21")] Value_21 = 21,
			[Serialize("Value_22")] Value_22 = 22,
			[Serialize("Value_23")] Value_23 = 23,
		}
		public enum Enum_RJR_1 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value__1")] Value__1 = -1,
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
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_20")] Value_20 = 20,
			[Serialize("Value_21")] Value_21 = 21,
			[Serialize("Value_22")] Value_22 = 22,
			[Serialize("Value_23")] Value_23 = 23,
		}
		public enum Enum_RFR_1 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public override uint? ClassCRC => 0xC00229D2;
	}
}

