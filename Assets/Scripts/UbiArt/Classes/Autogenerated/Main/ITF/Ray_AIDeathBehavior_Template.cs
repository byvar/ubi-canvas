using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIDeathBehavior_Template : AIDeathBehavior_Template {
		public Generic<Ray_EventSpawnReward> reward;
		public Path soul;
		public CArrayP<uint> numRewards;
		public int spawnOnMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward = s.SerializeObject<Generic<Ray_EventSpawnReward>>(reward, name: "reward");
			soul = s.SerializeObject<Path>(soul, name: "soul");
			numRewards = s.SerializeObject<CArrayP<uint>>(numRewards, name: "numRewards");
			spawnOnMarker = s.Serialize<int>(spawnOnMarker, name: "spawnOnMarker");
		}
		public override uint? ClassCRC => 0x7D1F295C;
	}
}

