using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FriendlyGrannyBTAIComponent_Template : RO2_FriendlyBTAIComponent_Template {
		public int health;
		public int hitHealthMalus;
		public bool ignoreRehit;
		public float earthquakeBounceMultiplier;
		public float crushBounceMultiplier;
		public RO2_SoftCollision_Template softCollision;
		public bool enableAutoSpawnOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			health = s.Serialize<int>(health, name: "health");
			hitHealthMalus = s.Serialize<int>(hitHealthMalus, name: "hitHealthMalus");
			ignoreRehit = s.Serialize<bool>(ignoreRehit, name: "ignoreRehit");
			earthquakeBounceMultiplier = s.Serialize<float>(earthquakeBounceMultiplier, name: "earthquakeBounceMultiplier");
			crushBounceMultiplier = s.Serialize<float>(crushBounceMultiplier, name: "crushBounceMultiplier");
			softCollision = s.SerializeObject<RO2_SoftCollision_Template>(softCollision, name: "softCollision");
			enableAutoSpawnOnCheckpoint = s.Serialize<bool>(enableAutoSpawnOnCheckpoint, name: "enableAutoSpawnOnCheckpoint");
		}
		public override uint? ClassCRC => 0x8CCD6E30;
	}
}

