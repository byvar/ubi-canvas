using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WalkingBulletAIComponent_Template : Ray_BulletAIComponent_Template {
		[Serialize("stickForce")] public float stickForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stickForce));
		}
		public override uint? ClassCRC => 0xBB70C027;
	}
}

