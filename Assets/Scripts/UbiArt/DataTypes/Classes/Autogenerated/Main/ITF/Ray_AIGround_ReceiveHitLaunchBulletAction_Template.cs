using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIGround_ReceiveHitLaunchBulletAction_Template : Ray_AIGround_ReceiveNormalHitAction_Template {
		public Path bulletPath;
		public StringID launcherBoneName;
		public StringID launcherMarker;
		public float bulletSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bulletPath = s.SerializeObject<Path>(bulletPath, name: "bulletPath");
			launcherBoneName = s.SerializeObject<StringID>(launcherBoneName, name: "launcherBoneName");
			launcherMarker = s.SerializeObject<StringID>(launcherMarker, name: "launcherMarker");
			bulletSpeed = s.Serialize<float>(bulletSpeed, name: "bulletSpeed");
		}
		public override uint? ClassCRC => 0x26A78D57;
	}
}

