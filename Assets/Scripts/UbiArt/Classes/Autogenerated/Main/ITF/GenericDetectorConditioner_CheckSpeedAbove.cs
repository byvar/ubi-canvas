using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GenericDetectorConditioner_CheckSpeedAbove : GenericDetectorConditioner {
		public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
		}
		public override uint? ClassCRC => 0x20E0DBB5;
	}
}

