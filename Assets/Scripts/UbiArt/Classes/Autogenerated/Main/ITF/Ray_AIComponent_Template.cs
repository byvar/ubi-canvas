using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIComponent_Template : AIComponent_Template {
		public int reactivateOnCheckpoint;
		public int customCheckpointHandling;
		public float softCollisionRadius;
		public Generic<Ray_EventSpawnReward> reward;
		public int invincibleToDangerousMaterial;
		public int alsoCheckEncroachedDangerousMaterials;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reactivateOnCheckpoint = s.Serialize<int>(reactivateOnCheckpoint, name: "reactivateOnCheckpoint");
			customCheckpointHandling = s.Serialize<int>(customCheckpointHandling, name: "customCheckpointHandling");
			softCollisionRadius = s.Serialize<float>(softCollisionRadius, name: "softCollisionRadius");
			reward = s.SerializeObject<Generic<Ray_EventSpawnReward>>(reward, name: "reward");
			invincibleToDangerousMaterial = s.Serialize<int>(invincibleToDangerousMaterial, name: "invincibleToDangerousMaterial");
			alsoCheckEncroachedDangerousMaterials = s.Serialize<int>(alsoCheckEncroachedDangerousMaterials, name: "alsoCheckEncroachedDangerousMaterials");
		}
		public override uint? ClassCRC => 0xF7791A7F;
	}
}

