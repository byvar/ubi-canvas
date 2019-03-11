using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_CreditsComponent_Template : CreditsComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x61B7278C;
	}
}

