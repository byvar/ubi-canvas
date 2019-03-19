using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIBasicBulletAction_Template : AIAction_Template {
		[Serialize("basicBullet")] public Ray_BasicBullet_Template basicBullet;
		[Serialize("hasOwner"   )] public int hasOwner;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(hasOwner));
		}
		public override uint? ClassCRC => 0xA21A7EA5;
	}
}

