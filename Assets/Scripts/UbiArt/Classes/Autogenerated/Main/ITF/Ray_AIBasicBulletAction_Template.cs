using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIBasicBulletAction_Template : AIAction_Template {
		public Ray_BasicBullet_Template basicBullet;
		public int hasOwner;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			basicBullet = s.SerializeObject<Ray_BasicBullet_Template>(basicBullet, name: "basicBullet");
			hasOwner = s.Serialize<int>(hasOwner, name: "hasOwner");
		}
		public override uint? ClassCRC => 0xA21A7EA5;
	}
}

