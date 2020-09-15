using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PlayGoto_evtTemplate : SequenceEvent_Template {
		public string Label;
		public StringID WaitForFact;
		public string value;
		public EValueType type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Label = s.Serialize<string>(Label, name: "Label");
			WaitForFact = s.SerializeObject<StringID>(WaitForFact, name: "WaitForFact");
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
		public override uint? ClassCRC => 0x692F74C0;
	}
}

