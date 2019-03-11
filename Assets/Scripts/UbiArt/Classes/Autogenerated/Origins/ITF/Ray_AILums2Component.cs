using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AILums2Component : Ray_BigMamaAIComponent {
		[Serialize("IsTaken")] public bool IsTaken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(IsTaken));
			}
		}
		public override uint? ClassCRC => 0x04F1036C;
	}
}

