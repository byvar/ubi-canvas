using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class FollowCamComponent : ActorComponent {
		public Vec3d offsetFromCam;
		public bool ignoreCamZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					offsetFromCam = s.SerializeObject<Vec3d>(offsetFromCam, name: "offsetFromCam");
				}
				ignoreCamZ = s.Serialize<bool>(ignoreCamZ, name: "ignoreCamZ");
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					offsetFromCam = s.SerializeObject<Vec3d>(offsetFromCam, name: "offsetFromCam");
				}
				ignoreCamZ = s.Serialize<bool>(ignoreCamZ, name: "ignoreCamZ");
			}
		}
		public override uint? ClassCRC => 0x03300214;
	}
}

