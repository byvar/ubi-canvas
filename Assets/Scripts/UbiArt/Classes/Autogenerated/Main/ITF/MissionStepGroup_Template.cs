using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepGroup_Template : CSerializable {
		public bool concurrent;
		public Enum_operator _operator;
		public uint count;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			concurrent = s.Serialize<bool>(concurrent, name: "concurrent", options: CSerializerObject.Options.BoolAsByte);
			_operator = s.Serialize<Enum_operator>(_operator, name: "_operator");
			count = s.Serialize<uint>(count, name: "count");
		}
		public enum Enum_operator {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xD100B1D5;
	}
}

