using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionNewGamePlus_Template : CSerializable {
		public uint numPlaythroughs;
		public Enum_operator _operator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			numPlaythroughs = s.Serialize<uint>(numPlaythroughs, name: "numPlaythroughs");
			_operator = s.Serialize<Enum_operator>(_operator, name: "operator");
		}
		public enum Enum_operator {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x6D035C29;
	}
}

