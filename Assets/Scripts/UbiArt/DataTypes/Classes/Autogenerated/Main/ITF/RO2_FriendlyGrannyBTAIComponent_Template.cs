namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FriendlyGrannyBTAIComponent_Template : RO2_FriendlyBTAIComponent_Template {
		public int health = 100;
		public int hitHealthMalus = 100;
		public bool ignoreRehit = true;
		public float earthquakeBounceMultiplier = 1f;
		public float crushBounceMultiplier = 1f;
		public RO2_SoftCollision_Template softCollision;
		public bool enableAutoSpawnOnCheckpoint = true;
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

