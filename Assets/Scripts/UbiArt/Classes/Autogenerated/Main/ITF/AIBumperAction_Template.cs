using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIBumperAction_Template : AIAction_Template {
		[Serialize("jumpForce")] public float jumpForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpForce));
		}
		public override uint? ClassCRC => 0x3DA0F136;
	}
}

