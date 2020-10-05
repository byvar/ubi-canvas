using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionConditionGroup_Template : CSerializable {
		public Enum_operator _operator;
		public uint count;
		public bool negated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			_operator = s.Serialize<Enum_operator>(_operator, name: "operator");
			count = s.Serialize<uint>(count, name: "count");
			negated = s.Serialize<bool>(negated, name: "negated", options: CSerializerObject.Options.BoolAsByte);
		}
		public enum Enum_operator {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xFCA2102A;
	}
}

