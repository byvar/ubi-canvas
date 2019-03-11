using UnityEngine;

namespace UbiArt.ITF {
	public partial class FollowCamComponent : ActorComponent {
		[Serialize("offsetFromCam")] public Vector3 offsetFromCam;
		[Serialize("ignoreCamZ"   )] public bool ignoreCamZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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

