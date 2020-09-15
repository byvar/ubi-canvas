using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DoorComponent_Template : CSerializable {
		public int startOpen;
		public float openSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startOpen = s.Serialize<int>(startOpen, name: "startOpen");
			openSpeed = s.Serialize<float>(openSpeed, name: "openSpeed");
		}
		public override uint? ClassCRC => 0x27B03C33;
	}
}

