using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FishingRodComponent : ActorComponent {
		public bool isDead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				isDead = s.Serialize<bool>(isDead, name: "isDead");
			}
		}
		public override uint? ClassCRC => 0x5C0B28A8;
	}
}

