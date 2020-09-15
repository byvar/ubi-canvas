using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_JalapenoKingAiComponent : AIComponent {
		public int dead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				dead = s.Serialize<int>(dead, name: "dead");
			}
		}
		public override uint? ClassCRC => 0x7E24CD77;
	}
}

