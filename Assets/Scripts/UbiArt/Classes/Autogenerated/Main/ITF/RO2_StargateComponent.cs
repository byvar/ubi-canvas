using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_StargateComponent : ActorComponent {
		public Vec2d doorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				doorOffset = s.SerializeObject<Vec2d>(doorOffset, name: "doorOffset");
			}
		}
		public override uint? ClassCRC => 0x683BEF32;
	}
}

