using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIShooterProjectileAction_Template : AIAction_Template {
		[Serialize("basicBullet")] public Placeholder basicBullet;
		[Serialize("posOffset"  )] public Vector2 posOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(posOffset));
		}
		public override uint? ClassCRC => 0x7D025735;
	}
}

