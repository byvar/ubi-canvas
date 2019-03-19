using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AILums2Component : Ray_FixedAIComponent {
		[Serialize("IsTaken")] public int IsTaken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(IsTaken));
			}
		}
		public override uint? ClassCRC => 0x04F1036C;
	}
}

