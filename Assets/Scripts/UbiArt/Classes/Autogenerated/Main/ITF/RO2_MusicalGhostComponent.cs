using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicalGhostComponent : ActorComponent {
		[Serialize("lifeTime")] public float lifeTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lifeTime));
		}
		public override uint? ClassCRC => 0xA667026A;
	}
}

