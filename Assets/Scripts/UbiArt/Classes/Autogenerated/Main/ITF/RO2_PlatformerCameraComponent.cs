using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlatformerCameraComponent : InGameCameraComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBBB3476A;
	}
}

