using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_JalapenoKingAiComponent : AIComponent {
		[Serialize("dead")] public bool dead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(dead));
			}
		}
		public override uint? ClassCRC => 0x02CCB5E2;
	}
}

