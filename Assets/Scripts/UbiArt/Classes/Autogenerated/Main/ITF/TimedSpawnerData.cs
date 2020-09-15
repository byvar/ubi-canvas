using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RL)]
	public partial class TimedSpawnerData : CSerializable {
		public float spawnDelay;
		public float spawnRate;
		public int burstElementsCount;
		public int burstCount;
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

