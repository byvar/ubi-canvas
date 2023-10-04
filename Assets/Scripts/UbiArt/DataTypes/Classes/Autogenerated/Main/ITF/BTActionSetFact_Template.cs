namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionSetFact_Template : BTAction_Template {
		public StringID fact;
		public string value;
		public EValueType typeRA = EValueType.StringId;
		public SetFactOperationType operation = SetFactOperationType.Set;
		public EValueType2 type = EValueType2.StringId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO || s.Settings.Game == Game.VH || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				fact = s.SerializeObject<StringID>(fact, name: "fact");
				value = s.Serialize<string>(value, name: "value");
				type = s.Serialize<EValueType2>(type, name: "type");
			} else {
				fact = s.SerializeObject<StringID>(fact, name: "fact");
				value = s.Serialize<string>(value, name: "value");
				typeRA = s.Serialize<EValueType>(typeRA, name: "type");
				operation = s.Serialize<SetFactOperationType>(operation, name: "operation");
			}
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
		public enum SetFactOperationType {
			[Serialize("SetFactOperationType_Set")] Set = 0,
			[Serialize("SetFactOperationType_Add")] Add = 1,
		}
		public enum EValueType2 {
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
		public override uint? ClassCRC => 0x802B1CD5;
	}
}

