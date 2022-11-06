using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_BasicBullet_Template : CSerializable {
		public Generic<PhysShape> Generic_PhysShape__0;
		public Enum_RJR_0 Enum_RJR_0__1;
		public float float__2;
		public uint uint__3;
		public int int__4;
		public Enum_RJR_1 Enum_RJR_1__5;
		public uint uint__6;
		public int int__7;
		public int int__8;
		public int int__9;
		public int int__10;
		public Vec2d Vector2__11;
		public float float__12;
		public int int__13;
		public uint uint__14;
		public int int__15;
		public int int__16;
		public float float__17;
		public float float__18;
		public float float__19;
		public Angle Angle__20;
		public StringID StringID__21;
		public StringID StringID__22;
		public StringID StringID__23;
		public StringID StringID__24;
		public int int__25;
		public Generic<PhysShape> Generic_PhysShape__26;
		public Enum_RFR_0 Enum_RFR_0__27;
		public float float__28;
		public uint uint__29;
		public int int__30;
		public Enum_RFR_1 Enum_RFR_1__31;
		public uint uint__32;
		public int int__33;
		public int int__34;
		public int int__35;
		public int int__36;
		public Vec2d Vector2__37;
		public float float__38;
		public int int__39;
		public uint uint__40;
		public int int__41;
		public int int__42;
		public float float__43;
		public float float__44;
		public float float__45;
		public Angle Angle__46;
		public StringID StringID__47;
		public StringID StringID__48;
		public StringID StringID__49;
		public StringID StringID__50;
		public int int__51;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR) {
				Generic_PhysShape__26 = s.SerializeObject<Generic<PhysShape>>(Generic_PhysShape__26, name: "Generic<PhysShape>__26");
				Enum_RFR_0__27 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__27, name: "Enum_RFR_0__27");
				float__28 = s.Serialize<float>(float__28, name: "float__28");
				uint__29 = s.Serialize<uint>(uint__29, name: "uint__29");
				int__30 = s.Serialize<int>(int__30, name: "int__30");
				Enum_RFR_1__31 = s.Serialize<Enum_RFR_1>(Enum_RFR_1__31, name: "Enum_RFR_1__31");
				uint__32 = s.Serialize<uint>(uint__32, name: "uint__32");
				int__33 = s.Serialize<int>(int__33, name: "int__33");
				int__34 = s.Serialize<int>(int__34, name: "int__34");
				int__35 = s.Serialize<int>(int__35, name: "int__35");
				int__36 = s.Serialize<int>(int__36, name: "int__36");
				Vector2__37 = s.SerializeObject<Vec2d>(Vector2__37, name: "Vector2__37");
				float__38 = s.Serialize<float>(float__38, name: "float__38");
				int__39 = s.Serialize<int>(int__39, name: "int__39");
				uint__40 = s.Serialize<uint>(uint__40, name: "uint__40");
				int__41 = s.Serialize<int>(int__41, name: "int__41");
				int__42 = s.Serialize<int>(int__42, name: "int__42");
				float__43 = s.Serialize<float>(float__43, name: "float__43");
				float__44 = s.Serialize<float>(float__44, name: "float__44");
				float__45 = s.Serialize<float>(float__45, name: "float__45");
				Angle__46 = s.SerializeObject<Angle>(Angle__46, name: "Angle__46");
				StringID__47 = s.SerializeObject<StringID>(StringID__47, name: "StringID__47");
				StringID__48 = s.SerializeObject<StringID>(StringID__48, name: "StringID__48");
				StringID__49 = s.SerializeObject<StringID>(StringID__49, name: "StringID__49");
				StringID__50 = s.SerializeObject<StringID>(StringID__50, name: "StringID__50");
				int__51 = s.Serialize<int>(int__51, name: "int__51");
			} else {
				Generic_PhysShape__0 = s.SerializeObject<Generic<PhysShape>>(Generic_PhysShape__0, name: "Generic<PhysShape>__0");
				Enum_RJR_0__1 = s.Serialize<Enum_RJR_0>(Enum_RJR_0__1, name: "Enum_RJR_0__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
				int__4 = s.Serialize<int>(int__4, name: "int__4");
				Enum_RJR_1__5 = s.Serialize<Enum_RJR_1>(Enum_RJR_1__5, name: "Enum_RJR_1__5");
				uint__6 = s.Serialize<uint>(uint__6, name: "uint__6");
				int__7 = s.Serialize<int>(int__7, name: "int__7");
				int__8 = s.Serialize<int>(int__8, name: "int__8");
				int__9 = s.Serialize<int>(int__9, name: "int__9");
				int__10 = s.Serialize<int>(int__10, name: "int__10");
				Vector2__11 = s.SerializeObject<Vec2d>(Vector2__11, name: "Vector2__11");
				float__12 = s.Serialize<float>(float__12, name: "float__12");
				int__13 = s.Serialize<int>(int__13, name: "int__13");
				uint__14 = s.Serialize<uint>(uint__14, name: "uint__14");
				int__15 = s.Serialize<int>(int__15, name: "int__15");
				int__16 = s.Serialize<int>(int__16, name: "int__16");
				float__17 = s.Serialize<float>(float__17, name: "float__17");
				float__18 = s.Serialize<float>(float__18, name: "float__18");
				float__19 = s.Serialize<float>(float__19, name: "float__19");
				Angle__20 = s.SerializeObject<Angle>(Angle__20, name: "Angle__20");
				StringID__21 = s.SerializeObject<StringID>(StringID__21, name: "StringID__21");
				StringID__22 = s.SerializeObject<StringID>(StringID__22, name: "StringID__22");
				StringID__23 = s.SerializeObject<StringID>(StringID__23, name: "StringID__23");
				StringID__24 = s.SerializeObject<StringID>(StringID__24, name: "StringID__24");
				int__25 = s.Serialize<int>(int__25, name: "int__25");
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

