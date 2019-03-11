using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossCameraComponent : BaseCameraComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA83B4A55;
	}
}

