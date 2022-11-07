namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_22_sub_71F740 : CSerializable {
		public Path ballPath;
		public uint goalLumCount;
		public uint goalOnFireLumCount;
		public float goalRespawnDelay;
		public float ballDestroyDelay;
		public float maxBallCount;
		public float multiBallCooldown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ballPath = s.SerializeObject<Path>(ballPath, name: "ballPath");
			goalLumCount = s.Serialize<uint>(goalLumCount, name: "goalLumCount");
			goalOnFireLumCount = s.Serialize<uint>(goalOnFireLumCount, name: "goalOnFireLumCount");
			goalRespawnDelay = s.Serialize<float>(goalRespawnDelay, name: "goalRespawnDelay");
			ballDestroyDelay = s.Serialize<float>(ballDestroyDelay, name: "ballDestroyDelay");
			maxBallCount = s.Serialize<float>(maxBallCount, name: "maxBallCount");
			multiBallCooldown = s.Serialize<float>(multiBallCooldown, name: "multiBallCooldown");
		}
		public override uint? ClassCRC => 0x345EABDC;
	}
}

