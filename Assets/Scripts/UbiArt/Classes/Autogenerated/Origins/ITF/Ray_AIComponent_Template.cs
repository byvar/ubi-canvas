using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIComponent_Template : AIComponent_Template {
		[Serialize("reactivateOnCheckpoint"               )] public bool reactivateOnCheckpoint;
		[Serialize("customCheckpointHandling"             )] public bool customCheckpointHandling;
		[Serialize("softCollisionRadius"                  )] public float softCollisionRadius;
		[Serialize("reward"                               )] public Placeholder reward;
		[Serialize("invincibleToDangerousMaterial"        )] public bool invincibleToDangerousMaterial;
		[Serialize("alsoCheckEncroachedDangerousMaterials")] public bool alsoCheckEncroachedDangerousMaterials;
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

