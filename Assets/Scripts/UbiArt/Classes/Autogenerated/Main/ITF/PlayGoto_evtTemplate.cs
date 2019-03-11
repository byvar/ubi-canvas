using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayGoto_evtTemplate : SequenceEvent_Template {
		[Serialize("Label"      )] public string Label;
		[Serialize("WaitForFact")] public StringID WaitForFact;
		[Serialize("value"      )] public string value;
		[Serialize("type"       )] public EValueType type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Label));
			SerializeField(s, nameof(WaitForFact));
			SerializeField(s, nameof(value));
			SerializeField(s, nameof(type));
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

