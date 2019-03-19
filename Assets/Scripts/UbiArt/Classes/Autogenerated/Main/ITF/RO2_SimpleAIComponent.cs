using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SimpleAIComponent : RO2_AIComponent {
		[Serialize("isDead" )] public bool isDead;
		[Serialize("isStuck")] public bool isStuck;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isDead));
				SerializeField(s, nameof(isStuck));
			}
		}
		public override uint? ClassCRC => 0x8A326704;
	}
}

