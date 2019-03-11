using UnityEngine;

namespace UbiArt.ITF {
	public partial class RewardTrigger_Event : RewardTrigger_Base {
		[Serialize("eventID"         )] public StringID eventID;
		[Serialize("conditionType"   )] public Enum_conditionType conditionType;
		[Serialize("floatValue"      )] public float floatValue;
		[Serialize("stringValue"     )] public StringID stringValue;
		[Serialize("stringArrayValue")] public CArray<StringID> stringArrayValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eventID));
			SerializeField(s, nameof(conditionType));
			SerializeField(s, nameof(floatValue));
			SerializeField(s, nameof(stringValue));
			SerializeField(s, nameof(stringArrayValue));
		}
		public enum Enum_conditionType {
			[Serialize("Triggered"       )] Triggered = 0,
			[Serialize("EqualsToString"  )] EqualsToString = 1,
			[Serialize("GreaterThanFloat")] GreaterThanFloat = 2,
			[Serialize("LesserThanFloat" )] LesserThanFloat = 3,
		}
		public override uint? ClassCRC => 0x30704FC0;
	}
}

