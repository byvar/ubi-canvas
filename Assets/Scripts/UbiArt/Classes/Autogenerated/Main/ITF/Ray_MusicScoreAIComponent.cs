using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MusicScoreAIComponent : GraphicComponent {
		[Serialize("startOpen")] public int startOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
			}
		}
		public override uint? ClassCRC => 0x42FB0CC5;
	}
}

