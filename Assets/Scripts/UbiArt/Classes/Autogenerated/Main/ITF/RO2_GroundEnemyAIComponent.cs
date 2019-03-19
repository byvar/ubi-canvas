using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GroundEnemyAIComponent : RO2_AIComponent {
		[Serialize("useRaycast")] public bool useRaycast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useRaycast));
		}
		public override uint? ClassCRC => 0xCAAFC949;
	}
}

