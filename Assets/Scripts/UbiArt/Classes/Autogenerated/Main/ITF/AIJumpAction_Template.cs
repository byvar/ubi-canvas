using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIJumpAction_Template : AIAction_Template {
		[Serialize("jumpForce")] public float jumpForce;
		[Serialize("minXSpeed")] public float minXSpeed;
		[Serialize("maxXSpeed")] public float maxXSpeed;
		[Serialize("minXForce")] public float minXForce;
		[Serialize("maxXForce")] public float maxXForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpForce));
			SerializeField(s, nameof(minXSpeed));
			SerializeField(s, nameof(maxXSpeed));
			SerializeField(s, nameof(minXForce));
			SerializeField(s, nameof(maxXForce));
		}
		public override uint? ClassCRC => 0x4072E059;
	}
}

