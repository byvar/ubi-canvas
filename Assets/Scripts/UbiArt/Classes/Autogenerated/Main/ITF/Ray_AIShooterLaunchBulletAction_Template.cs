using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIShooterLaunchBulletAction_Template : Ray_AIPerformHitAction_Template {
		[Serialize("bulletExitBone")] public StringID bulletExitBone;
		[Serialize("useBonesEnd"   )] public int useBonesEnd;
		[Serialize("bullet"        )] public Path bullet;
		[Serialize("offset"        )] public float offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bulletExitBone));
			SerializeField(s, nameof(useBonesEnd));
			SerializeField(s, nameof(bullet));
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0x208CF8B5;
	}
}

