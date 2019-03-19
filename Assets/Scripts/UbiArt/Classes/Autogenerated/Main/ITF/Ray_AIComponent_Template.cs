using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIComponent_Template : AIComponent_Template {
		[Serialize("reactivateOnCheckpoint"               )] public int reactivateOnCheckpoint;
		[Serialize("customCheckpointHandling"             )] public int customCheckpointHandling;
		[Serialize("softCollisionRadius"                  )] public float softCollisionRadius;
		[Serialize("reward"                               )] public Generic<Ray_EventSpawnReward> reward;
		[Serialize("invincibleToDangerousMaterial"        )] public int invincibleToDangerousMaterial;
		[Serialize("alsoCheckEncroachedDangerousMaterials")] public int alsoCheckEncroachedDangerousMaterials;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(reactivateOnCheckpoint));
			SerializeField(s, nameof(customCheckpointHandling));
			SerializeField(s, nameof(softCollisionRadius));
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(invincibleToDangerousMaterial));
			SerializeField(s, nameof(alsoCheckEncroachedDangerousMaterials));
		}
		public override uint? ClassCRC => 0xF7791A7F;
	}
}

