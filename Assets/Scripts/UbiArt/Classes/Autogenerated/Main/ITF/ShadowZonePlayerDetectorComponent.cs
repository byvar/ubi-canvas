using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ShadowZonePlayerDetectorComponent : DetectorComponent {
		[Serialize("detectInLight")] public bool detectInLight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectInLight));
		}
		public override uint? ClassCRC => 0xF3DEFDFD;
	}
}

