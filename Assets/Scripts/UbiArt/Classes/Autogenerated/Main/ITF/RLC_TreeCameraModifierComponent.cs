using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_TreeCameraModifierComponent : ScrollableCameraModifierComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7D1AB286;
	}
}

