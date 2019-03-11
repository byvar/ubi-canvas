using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ShooterDoorComponent : EventReceivePlayAnimComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x04BAD7E4;
	}
}

