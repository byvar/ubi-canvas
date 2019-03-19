using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LeafsComponent : ActorComponent {
		[Serialize("triggered")] public bool triggered;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(triggered));
			}
		}
		public override uint? ClassCRC => 0x6B0FCCDB;
	}
}

