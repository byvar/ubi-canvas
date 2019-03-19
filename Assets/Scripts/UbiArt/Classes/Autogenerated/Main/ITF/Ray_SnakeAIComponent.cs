using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SnakeAIComponent : ActorComponent {
		[Serialize("activeMode")] public Enum_RFR_0 activeMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activeMode));
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x34A561B8;
	}
}

