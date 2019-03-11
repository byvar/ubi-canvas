using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SkullCoinBTAIComponent : BTAIComponent {
		[Serialize("exploded")] public bool exploded;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(exploded));
			}
		}
		public override uint? ClassCRC => 0xDD1D9FC2;
	}
}

