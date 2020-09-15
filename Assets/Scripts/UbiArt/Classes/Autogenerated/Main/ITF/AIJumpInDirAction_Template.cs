using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIJumpInDirAction_Template : AIAction_Template {
		public Vec2d jumpForce;
		public bool flipDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpForce = s.SerializeObject<Vec2d>(jumpForce, name: "jumpForce");
			flipDirection = s.Serialize<bool>(flipDirection, name: "flipDirection");
		}
		public override uint? ClassCRC => 0xF5977E04;
	}
}

