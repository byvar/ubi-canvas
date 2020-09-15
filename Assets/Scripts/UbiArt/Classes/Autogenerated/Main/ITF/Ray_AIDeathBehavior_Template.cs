using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIDeathBehavior_Template : AIDeathBehavior_Template {
		public Generic<Ray_EventSpawnReward> reward;
		public Path soul;
		public CArray<uint> numRewards;
		public int spawnOnMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward = s.SerializeObject<Generic<Ray_EventSpawnReward>>(reward, name: "reward");
			soul = s.SerializeObject<Path>(soul, name: "soul");
			numRewards = s.SerializeObject<CArray<uint>>(numRewards, name: "numRewards");
			spawnOnMarker = s.Serialize<int>(spawnOnMarker, name: "spawnOnMarker");
		}
		public override uint? ClassCRC => 0x7D1F295C;
	}
}

