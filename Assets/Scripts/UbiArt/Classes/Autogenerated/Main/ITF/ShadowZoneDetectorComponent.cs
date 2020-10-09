using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ShadowZoneDetectorComponent : ShapeDetectorComponent {
		public bool detectInLight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectInLight = s.Serialize<bool>(detectInLight, name: "detectInLight");
		}
		public override uint? ClassCRC => 0x46B5C939;
	}
}

