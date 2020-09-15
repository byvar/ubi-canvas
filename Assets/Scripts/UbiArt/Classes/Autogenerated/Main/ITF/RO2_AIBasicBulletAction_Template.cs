using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIBasicBulletAction_Template : AIAction_Template {
		public RO2_BasicBullet_Template basicBullet;
		public bool hasOwner;
		public bool useThrownAnim;
		public StringID thrownAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			basicBullet = s.SerializeObject<RO2_BasicBullet_Template>(basicBullet, name: "basicBullet");
			hasOwner = s.Serialize<bool>(hasOwner, name: "hasOwner");
			useThrownAnim = s.Serialize<bool>(useThrownAnim, name: "useThrownAnim");
			thrownAnim = s.SerializeObject<StringID>(thrownAnim, name: "thrownAnim");
		}
		public override uint? ClassCRC => 0xF68F4429;
	}
}

