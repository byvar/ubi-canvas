using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_GeyserPlatformAIComponent : GraphicComponent {
		[Serialize("startOpen"     )] public int startOpen;
		[Serialize("platformHeight")] public float platformHeight;
		[Serialize("angle"         )] public float angle;
		[Serialize("width"         )] public float width;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
				SerializeField(s, nameof(platformHeight));
				SerializeField(s, nameof(angle));
				SerializeField(s, nameof(width));
			}
		}
		public override uint? ClassCRC => 0x4890020D;
	}
}

