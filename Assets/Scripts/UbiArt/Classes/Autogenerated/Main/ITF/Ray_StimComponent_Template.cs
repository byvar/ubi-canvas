using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_StimComponent_Template : ShapeComponent_Template {
		[Serialize("faction"            )] public Enum_RJR_0 faction;
		[Serialize("useFixedAngle"      )] public int useFixedAngle;
		[Serialize("fixedAngle"         )] public Angle fixedAngle;
		[Serialize("localAngleOffset"   )] public Angle localAngleOffset;
		[Serialize("hitType"            )] public Enum_RJR_1 hitType;
		[Serialize("hitLevel"           )] public uint hitLevel;
		[Serialize("hitRadial"          )] public int hitRadial;
		[Serialize("useNormal"          )] public int useNormal;
		[Serialize("registerToAIManager")] public int registerToAIManager;
		[Serialize("useOutOfScreenOptim")] public int useOutOfScreenOptim;
		[Serialize("hitEnemiesOnce"     )] public int hitEnemiesOnce;
		[Serialize("Enum_RFR_0__0"      )] public Enum_RFR_0 Enum_RFR_0__0;
		[Serialize("int__1"             )] public int int__1;
		[Serialize("Angle__2"           )] public Angle Angle__2;
		[Serialize("Angle__3"           )] public Angle Angle__3;
		[Serialize("Enum_RFR_1__4"      )] public Enum_RFR_1 Enum_RFR_1__4;
		[Serialize("uint__5"            )] public uint uint__5;
		[Serialize("int__6"             )] public int int__6;
		[Serialize("int__7"             )] public int int__7;
		[Serialize("int__8"             )] public int int__8;
		[Serialize("int__9"             )] public int int__9;
		[Serialize("int__10"            )] public int int__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Enum_RFR_0__0));
				SerializeField(s, nameof(int__1));
				SerializeField(s, nameof(Angle__2));
				SerializeField(s, nameof(Angle__3));
				SerializeField(s, nameof(Enum_RFR_1__4));
				SerializeField(s, nameof(uint__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(int__7));
				SerializeField(s, nameof(int__8));
				SerializeField(s, nameof(int__9));
				SerializeField(s, nameof(int__10));
			} else {
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(useFixedAngle));
				SerializeField(s, nameof(fixedAngle));
				SerializeField(s, nameof(localAngleOffset));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(hitRadial));
				SerializeField(s, nameof(useNormal));
				SerializeField(s, nameof(registerToAIManager));
				SerializeField(s, nameof(useOutOfScreenOptim));
				SerializeField(s, nameof(hitEnemiesOnce));
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
		public override uint? ClassCRC => 0xF8C4A1EE;
	}
}

