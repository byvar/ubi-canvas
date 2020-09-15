using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class RewardTrigger_Event : RewardTrigger_Base {
		public StringID eventID;
		public Enum_conditionType conditionType;
		public float floatValue;
		public StringID stringValue;
		public CArray<StringID> stringArrayValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eventID = s.SerializeObject<StringID>(eventID, name: "eventID");
			conditionType = s.Serialize<Enum_conditionType>(conditionType, name: "conditionType");
			floatValue = s.Serialize<float>(floatValue, name: "floatValue");
			stringValue = s.SerializeObject<StringID>(stringValue, name: "stringValue");
			stringArrayValue = s.SerializeObject<CArray<StringID>>(stringArrayValue, name: "stringArrayValue");
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

