using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SeekingJellyfishAIComponent : ActorComponent {
		[Serialize("autoStart")] public bool autoStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(autoStart));
			}
		}
		public override uint? ClassCRC => 0xB7E47051;
	}
}

