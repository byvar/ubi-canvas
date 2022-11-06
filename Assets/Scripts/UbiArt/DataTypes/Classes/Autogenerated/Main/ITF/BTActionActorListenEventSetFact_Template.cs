using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BTActionActorListenEventSetFact_Template : BTAction_Template {
		public StringID factOnOff;
		public Generic<Event> ListenEvent;
		public string value;
		public EValueType type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factOnOff = s.SerializeObject<StringID>(factOnOff, name: "factOnOff");
			ListenEvent = s.SerializeObject<Generic<Event>>(ListenEvent, name: "ListenEvent");
			value = s.Serialize<string>(value, name: "value");
			type = s.Serialize<EValueType>(type, name: "type");
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
		public override uint? ClassCRC => 0x3A7D50F6;
	}
}

