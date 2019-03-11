using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIGround_ReceiveHitLaunchBulletAction_Template : Ray_AIGround_ReceiveNormalHitAction_Template {
		[Serialize("bulletPath"      )] public Path bulletPath;
		[Serialize("launcherBoneName")] public StringID launcherBoneName;
		[Serialize("launcherMarker"  )] public StringID launcherMarker;
		[Serialize("bulletSpeed"     )] public float bulletSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bulletPath));
			SerializeField(s, nameof(launcherBoneName));
			SerializeField(s, nameof(launcherMarker));
			SerializeField(s, nameof(bulletSpeed));
		}
		public override uint? ClassCRC => 0x26A78D57;
	}
}

