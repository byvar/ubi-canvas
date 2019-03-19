using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepGroup_Template : CSerializable {
		[Serialize("concurrent")] public bool concurrent;
		[Serialize("operator"  )] public Enum_operator _operator;
		[Serialize("count"     )] public uint count;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(concurrent), boolAsByte: true);
			SerializeField(s, nameof(_operator));
			SerializeField(s, nameof(count));
		}
		public enum Enum_operator {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xD100B1D5;
	}
}

