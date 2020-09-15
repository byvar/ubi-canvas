using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionConditionState_Template : CSerializable {
		public StringID mission;
		public bool negated;
		public Enum_state state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mission = s.SerializeObject<StringID>(mission, name: "mission");
			negated = s.Serialize<bool>(negated, name: "negated", options: CSerializerObject.Options.BoolAsByte);
			state = s.Serialize<Enum_state>(state, name: "state");
		}
		public enum Enum_state {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xFC341D28;
	}
}

