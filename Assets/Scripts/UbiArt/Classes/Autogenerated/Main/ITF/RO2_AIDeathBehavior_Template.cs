using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIDeathBehavior_Template : AIDeathBehavior_Template {
		public Generic<RO2_EventSpawnReward> reward;
		public Path soul;
		public CListP<uint> numRewards;
		public bool spawnOnMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(reward, name: "reward");
			soul = s.SerializeObject<Path>(soul, name: "soul");
			numRewards = s.SerializeObject<CListP<uint>>(numRewards, name: "numRewards");
			spawnOnMarker = s.Serialize<bool>(spawnOnMarker, name: "spawnOnMarker");
		}
		public override uint? ClassCRC => 0x54BE1D59;
	}
}

