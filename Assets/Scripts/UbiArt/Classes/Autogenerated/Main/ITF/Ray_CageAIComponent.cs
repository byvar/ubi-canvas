using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CageAIComponent : Ray_FixedAIComponent {
		[Serialize("CageIndex"         )] public int CageIndex;
		[Serialize("wasBrokenInSession")] public int wasBrokenInSession;
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

