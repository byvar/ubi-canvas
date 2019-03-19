using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIDeathBehavior_Template : AIDeathBehavior_Template {
		[Serialize("reward"       )] public Generic<RO2_EventSpawnReward> reward;
		[Serialize("soul"         )] public Path soul;
		[Serialize("numRewards"   )] public CList<uint> numRewards;
		[Serialize("spawnOnMarker")] public bool spawnOnMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(soul));
			SerializeField(s, nameof(numRewards));
			SerializeField(s, nameof(spawnOnMarker));
		}
		public override uint? ClassCRC => 0x54BE1D59;
	}
}

