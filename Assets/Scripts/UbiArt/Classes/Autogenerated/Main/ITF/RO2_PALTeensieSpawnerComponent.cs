using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PALTeensieSpawnerComponent : ActorComponent {
		[Serialize("raycastLength")] public float raycastLength;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(raycastLength));
		}
		public override uint? ClassCRC => 0x0C9783AF;
	}
}

