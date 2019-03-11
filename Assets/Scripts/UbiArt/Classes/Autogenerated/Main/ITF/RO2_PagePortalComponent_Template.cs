using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PagePortalComponent_Template : RO2_TeleportPortalComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x33D4045D;
	}
}

