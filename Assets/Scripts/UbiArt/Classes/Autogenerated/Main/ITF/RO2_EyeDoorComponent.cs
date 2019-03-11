using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EyeDoorComponent : RO2_DoorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6A7E35C1;
	}
}

