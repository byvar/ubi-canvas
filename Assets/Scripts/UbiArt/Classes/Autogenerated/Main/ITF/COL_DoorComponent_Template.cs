using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DoorComponent_Template : CSerializable {
		[Serialize("startOpen")] public int startOpen;
		[Serialize("openSpeed")] public float openSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startOpen));
			SerializeField(s, nameof(openSpeed));
		}
		public override uint? ClassCRC => 0x27B03C33;
	}
}

