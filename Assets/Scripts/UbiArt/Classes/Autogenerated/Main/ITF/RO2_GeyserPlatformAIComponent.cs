using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_GeyserPlatformAIComponent : GraphicComponent {
		[Serialize("platformHeight")] public float platformHeight;
		[Serialize("angle"         )] public float angle;
		[Serialize("width"         )] public float width;
		[Serialize("startOpen"     )] public Placeholder startOpen;
		[Serialize("startOpen"     )] public bool startOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(startOpen));
					SerializeField(s, nameof(startOpen));
					SerializeField(s, nameof(platformHeight));
					SerializeField(s, nameof(angle));
					SerializeField(s, nameof(width));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(platformHeight));
					SerializeField(s, nameof(angle));
					SerializeField(s, nameof(width));
				}
			}
		}
		public override uint? ClassCRC => 0x4890020D;
	}
}

