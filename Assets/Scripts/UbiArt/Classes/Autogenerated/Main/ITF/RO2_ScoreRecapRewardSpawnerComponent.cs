using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScoreRecapRewardSpawnerComponent : ActorComponent {
		public Vec3d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			offset = s.SerializeObject<Vec3d>(offset, name: "offset");
		}
		public override uint? ClassCRC => 0x84722B13;
	}
}

