using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIJumpAngleAction_Template : AIAction_Template {
		[Serialize("jumpForce")] public float jumpForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpForce));
		}
		public override uint? ClassCRC => 0xB8B3E40D;
	}
}

