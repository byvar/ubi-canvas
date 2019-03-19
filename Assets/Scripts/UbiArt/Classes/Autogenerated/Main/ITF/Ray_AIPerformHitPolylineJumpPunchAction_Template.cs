using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIPerformHitPolylineJumpPunchAction_Template : Ray_AIPerformHitPolylinePunchAction_Template {
		[Serialize("jumpForce"   )] public float jumpForce;
		[Serialize("jumpXForce"  )] public float jumpXForce;
		[Serialize("antiGravTime")] public float antiGravTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpForce));
			SerializeField(s, nameof(jumpXForce));
			SerializeField(s, nameof(antiGravTime));
		}
		public override uint? ClassCRC => 0x4C4C0B6D;
	}
}

