using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MusicScoreAIBranchComponent : RO2_BezierBranchComponent {
		[Serialize("startOpen")] public bool startOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
			}
		}
		public override uint? ClassCRC => 0xDB2FA652;
	}
}

