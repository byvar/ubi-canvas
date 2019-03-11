using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CameraLimiterComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB227E11E;
	}
}

