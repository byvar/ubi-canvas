using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PlayerControllerComponent : CSerializable {
		public bool displayDebug;
		public Enum_defaultStateId defaultStateId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			displayDebug = s.Serialize<bool>(displayDebug, name: "displayDebug", options: CSerializerObject.Options.BoolAsByte);
			defaultStateId = s.Serialize<Enum_defaultStateId>(defaultStateId, name: "defaultStateId");
		}
		public enum Enum_defaultStateId {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
		}
		public override uint? ClassCRC => 0x103E707C;
	}
}

