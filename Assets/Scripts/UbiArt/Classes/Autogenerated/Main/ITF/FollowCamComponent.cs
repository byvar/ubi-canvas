using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class FollowCamComponent : ActorComponent {
		[Serialize("offsetFromCam")] public Vector3 offsetFromCam;
		[Serialize("ignoreCamZ"   )] public bool ignoreCamZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(offsetFromCam));
				}
				SerializeField(s, nameof(ignoreCamZ));
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(offsetFromCam));
				}
				SerializeField(s, nameof(ignoreCamZ));
			}
		}
		public override uint? ClassCRC => 0x03300214;
	}
}

