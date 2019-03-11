using UnityEngine;

namespace UbiArt.ITF {
	public partial class FixedCameraComponent_Template : BaseCameraComponent_Template {
		[Serialize("zOffset")] public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(zOffset));
			} else {
			}
		}
		public override uint? ClassCRC => 0xC4B49CE8;
	}
}

