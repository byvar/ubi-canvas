using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_GeyserPlatformAIComponent : GraphicComponent {
		public int startOpen;
		public float platformHeight;
		public float angle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startOpen = s.Serialize<int>(startOpen, name: "startOpen");
				platformHeight = s.Serialize<float>(platformHeight, name: "platformHeight");
				angle = s.Serialize<float>(angle, name: "angle");
			}
		}
		public override uint? ClassCRC => 0x0A876239;
	}
}

