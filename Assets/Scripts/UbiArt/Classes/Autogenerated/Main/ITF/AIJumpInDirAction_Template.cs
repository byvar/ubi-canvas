using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIJumpInDirAction_Template : AIAction_Template {
		[Serialize("jumpForce"    )] public Vector2 jumpForce;
		[Serialize("flipDirection")] public bool flipDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpForce));
			SerializeField(s, nameof(flipDirection));
		}
		public override uint? ClassCRC => 0xF5977E04;
	}
}

