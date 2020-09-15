using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIShooterProjectileAction_Template : AIAction_Template {
		[Serialize("basicBullet")] public Ray_BasicBullet_Template basicBullet;
		[Serialize("posOffset"  )] public Vec2d posOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(posOffset));
		}
		public override uint? ClassCRC => 0x7D025735;
	}
}

