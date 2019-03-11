using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionSetFact_Template : BTAction_Template {
		[Serialize("fact"     )] public StringID fact;
		[Serialize("value"    )] public string value;
		[Serialize("type"     )] public EValueType type;
		[Serialize("operation")] public SetFactOperationType operation;
		[Serialize("type"     )] public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(type));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(type));
			} else {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(operation));
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
		public enum EValueType {
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
		public enum Enum_type {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_8")] Value_8 = 8,
			[Serialize("Value_9")] Value_9 = 9,
		}
		public override uint? ClassCRC => 0x802B1CD5;
	}
}

