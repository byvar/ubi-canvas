namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class TimedSpawnerData : CSerializable {
		public float spawnDelay;
		public float spawnRate = 1f;
		public int burstElementsCount = -1;
		public int burstCount = -1;
		public float burstDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spawnDelay = s.Serialize<float>(spawnDelay, name: "spawnDelay");
			spawnRate = s.Serialize<float>(spawnRate, name: "spawnRate");
			burstElementsCount = s.Serialize<int>(burstElementsCount, name: "burstElementsCount");
			burstCount = s.Serialize<int>(burstCount, name: "burstCount");
			burstDelay = s.Serialize<float>(burstDelay, name: "burstDelay");
		}
	}
}

