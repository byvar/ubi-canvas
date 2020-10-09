using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_AIShooterProjectileAction_Template : AIAction_Template {
		public Ray_BasicBullet_Template basicBullet;
		public Vec2d posOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			basicBullet = s.SerializeObject<Ray_BasicBullet_Template>(basicBullet, name: "basicBullet");
			posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
		}
		public override uint? ClassCRC => 0x7D025735;
	}
}

