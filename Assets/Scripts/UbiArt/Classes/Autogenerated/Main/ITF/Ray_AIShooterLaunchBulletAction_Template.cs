using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIShooterLaunchBulletAction_Template : Ray_AIPerformHitAction_Template {
		public StringID bulletExitBone;
		public int useBonesEnd;
		public Path bullet;
		public float offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bulletExitBone = s.SerializeObject<StringID>(bulletExitBone, name: "bulletExitBone");
			useBonesEnd = s.Serialize<int>(useBonesEnd, name: "useBonesEnd");
			bullet = s.SerializeObject<Path>(bullet, name: "bullet");
			offset = s.Serialize<float>(offset, name: "offset");
		}
		public override uint? ClassCRC => 0x208CF8B5;
	}
}

