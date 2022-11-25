namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_AIComponent_Template : AIComponent_Template {
		public bool reactivateOnCheckpoint = true;
		public bool customCheckpointHandling;
		public float softCollisionRadius;
		public Generic<RO2_EventSpawnReward> reward;
		public bool invincibleToDangerousMaterial;
		public bool alsoCheckEncroachedDangerousMaterials;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reactivateOnCheckpoint = s.Serialize<bool>(reactivateOnCheckpoint, name: "reactivateOnCheckpoint");
			customCheckpointHandling = s.Serialize<bool>(customCheckpointHandling, name: "customCheckpointHandling");
			softCollisionRadius = s.Serialize<float>(softCollisionRadius, name: "softCollisionRadius");
			reward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(reward, name: "reward");
			invincibleToDangerousMaterial = s.Serialize<bool>(invincibleToDangerousMaterial, name: "invincibleToDangerousMaterial");
			alsoCheckEncroachedDangerousMaterials = s.Serialize<bool>(alsoCheckEncroachedDangerousMaterials, name: "alsoCheckEncroachedDangerousMaterials");
		}
		public override uint? ClassCRC => 0xD08BF2E1;
	}
}

