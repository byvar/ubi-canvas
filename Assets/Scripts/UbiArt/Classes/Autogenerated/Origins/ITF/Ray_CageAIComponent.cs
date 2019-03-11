using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_CageAIComponent : Ray_BigMamaAIComponent {
		[Serialize("CageIndex"         )] public bool CageIndex;
		[Serialize("wasBrokenInSession")] public bool wasBrokenInSession;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(CageIndex));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(wasBrokenInSession));
			}
		}
		public override uint? ClassCRC => 0x1F1365D4;
	}
}

