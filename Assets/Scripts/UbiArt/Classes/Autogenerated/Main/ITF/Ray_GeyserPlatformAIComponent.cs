using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_GeyserPlatformAIComponent : GraphicComponent {
		[Serialize("startOpen"     )] public int startOpen;
		[Serialize("platformHeight")] public float platformHeight;
		[Serialize("angle"         )] public float angle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
				SerializeField(s, nameof(platformHeight));
				SerializeField(s, nameof(angle));
			}
		}
		public override uint? ClassCRC => 0x0A876239;
	}
}

