using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScoreRecapRewardSpawnerComponent : ActorComponent {
		[Serialize("offset")] public Vec3d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0x84722B13;
	}
}

