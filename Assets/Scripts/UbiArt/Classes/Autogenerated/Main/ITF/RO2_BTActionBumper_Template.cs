using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionBumper_Template : BTAction_Template {
		public float jumpForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpForce = s.Serialize<float>(jumpForce, name: "jumpForce");
		}
		public override uint? ClassCRC => 0x54569C51;
	}
}

