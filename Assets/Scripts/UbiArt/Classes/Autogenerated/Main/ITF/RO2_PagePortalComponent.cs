using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PagePortalComponent : RO2_TeleportPortalComponent {
		[Serialize("enterExitDist")] public float enterExitDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(enterExitDist));
			}
		}
		public override uint? ClassCRC => 0x69DC1680;
	}
}

