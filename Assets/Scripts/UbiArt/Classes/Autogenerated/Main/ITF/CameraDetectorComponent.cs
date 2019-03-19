using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RFR)]
	public partial class CameraDetectorComponent : ShapeDetectorComponent {
		[Serialize("remote")] public bool remote;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
			} else {
				SerializeField(s, nameof(remote));
			}
		}
		public override uint? ClassCRC => 0x75AA523D;
	}
}

