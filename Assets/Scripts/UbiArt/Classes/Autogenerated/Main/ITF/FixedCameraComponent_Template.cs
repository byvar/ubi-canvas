using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class FixedCameraComponent_Template : BaseCameraComponent_Template {
		public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			} else {
			}
		}
		public override uint? ClassCRC => 0xC4B49CE8;
	}
}

