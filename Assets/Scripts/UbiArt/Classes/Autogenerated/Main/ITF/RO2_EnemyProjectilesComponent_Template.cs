using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnemyProjectilesComponent_Template : ActorComponent_Template {
		public RO2_EnemyBullet_Template basicBullet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			basicBullet = s.SerializeObject<RO2_EnemyBullet_Template>(basicBullet, name: "basicBullet");
		}
		public override uint? ClassCRC => 0xFA468076;
	}
}

