using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionConditionGroup_Template : CSerializable {
		[Serialize("operator")] public Enum_operator _operator;
		[Serialize("count"   )] public uint count;
		[Serialize("negated" )] public bool negated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(_operator));
			SerializeField(s, nameof(count));
			SerializeField(s, nameof(negated), boolAsByte: true);
		}
		public enum Enum_operator {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x30DD49CC;
	}
}

