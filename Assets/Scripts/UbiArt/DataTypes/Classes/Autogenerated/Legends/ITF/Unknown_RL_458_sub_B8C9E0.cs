using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_458_sub_B8C9E0 : AIAction_Template {
		public RO2_BasicBullet_Template basicBullet;
		public Vec2d posOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			basicBullet = s.SerializeObject<RO2_BasicBullet_Template>(basicBullet, name: "basicBullet");
			posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
		}
		public override uint? ClassCRC => 0x2B5B95B0;
	}
}

