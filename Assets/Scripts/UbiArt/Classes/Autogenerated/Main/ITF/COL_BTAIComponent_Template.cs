using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTAIComponent_Template : BTAIComponent_Template {
		public Enum_defaultOrientation defaultOrientation;
		public float groundCheckDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				defaultOrientation = s.Serialize<Enum_defaultOrientation>(defaultOrientation, name: "defaultOrientation");
				groundCheckDistance = s.Serialize<float>(groundCheckDistance, name: "groundCheckDistance");
			}
		}
		public enum Enum_defaultOrientation {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xBCCC85E8;
	}
}

