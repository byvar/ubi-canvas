using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicalGhostComponent : ActorComponent {
		public float lifeTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lifeTime = s.Serialize<float>(lifeTime, name: "lifeTime");
		}
		public override uint? ClassCRC => 0xA667026A;
	}
}

