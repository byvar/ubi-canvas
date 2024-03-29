namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTDeciderFactEqual_Template : BTDecider_Template {
		public StringID fact;
		public string value;
		public EValueTypeRA typeRA;
		public EValueType type;
		public bool superior;
		public bool inferior;
		public EValueType superiorEnum;
		public EValueType inferiorEnum;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO) {
				fact = s.SerializeObject<StringID>(fact, name: "fact");
				value = s.Serialize<string>(value, name: "value");
				type = s.Serialize<EValueType>(type, name: "type");
			} else if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				fact = s.SerializeObject<StringID>(fact, name: "fact");
				value = s.Serialize<string>(value, name: "value");
				type = s.Serialize<EValueType>(type, name: "type");
				superiorEnum = s.Serialize<EValueType>(superiorEnum, name: "superior");
				inferiorEnum = s.Serialize<EValueType>(inferiorEnum, name: "inferior");
			} else {
				fact = s.SerializeObject<StringID>(fact, name: "fact");
				value = s.Serialize<string>(value, name: "value");
				typeRA = s.Serialize<EValueTypeRA>(typeRA, name: "type");
				superior = s.Serialize<bool>(superior, name: "superior");
				inferior = s.Serialize<bool>(inferior, name: "inferior");
			}
		}
		public enum EValueTypeRA {
			[Serialize("EValueType_Unknown"   )] Unknown = 0,
			[Serialize("EValueType_Boolean"   )] Boolean = 1,
			[Serialize("EValueType_Integer32" )] Integer32 = 2,
			[Serialize("EValueType_UInteger32")] UInteger32 = 3,
			[Serialize("EValueType_Float"     )] Float = 4,
			[Serialize("EValueType_StringId"  )] StringId = 5,
			[Serialize("EValueType_Vec2"      )] Vec2 = 6,
			[Serialize("EValueType_Vec3"      )] Vec3 = 7,
			[Serialize("EValueType_ObjectRef" )] ObjectRef = 8,
			[Serialize("EValueType_Event"     )] Event = 9,
		}
		public enum EValueType {
			[Serialize("EValueType_Unknown"   )] Unknown = 0,
			[Serialize("EValueType_Boolean"   )] Boolean = 1,
			[Serialize("EValueType_Integer32" )] Integer32 = 2,
			[Serialize("EValueType_UInteger32")] UInteger32 = 3,
			[Serialize("EValueType_Float"     )] Float = 4,
			[Serialize("EValueType_StringId"  )] StringId = 5,
			[Serialize("EValueType_Vec2"      )] Vec2 = 6,
			[Serialize("EValueType_Vec3"      )] Vec3 = 7,
			[Serialize("EValueType_ObjectRef" )] ObjectRef = 8,
			[Serialize("EValueType_Event"     )] Event = 9,
		}
		public override uint? ClassCRC => 0xE1129F90;
	}
}

