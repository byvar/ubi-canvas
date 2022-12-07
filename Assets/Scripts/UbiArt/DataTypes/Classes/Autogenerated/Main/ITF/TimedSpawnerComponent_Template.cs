namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TimedSpawnerComponent_Template : ActorComponent_Template {
		public Path actorToSpawn;
		public float spawnDelay;
		public float spawnRate = 1f;
		public int burstElementsCount = -1;
		public int burstCount = -1;
		public float burstDelay;
		public bool useInstanceValues;
		public bool recycling;
		public Generic<Event> startEvent;
		public Generic<Event> stopEvent;
		public Generic<Event> onSpawnEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorToSpawn = s.SerializeObject<Path>(actorToSpawn, name: "actorToSpawn");
			spawnDelay = s.Serialize<float>(spawnDelay, name: "spawnDelay");
			spawnRate = s.Serialize<float>(spawnRate, name: "spawnRate");
			burstElementsCount = s.Serialize<int>(burstElementsCount, name: "burstElementsCount");
			burstCount = s.Serialize<int>(burstCount, name: "burstCount");
			burstDelay = s.Serialize<float>(burstDelay, name: "burstDelay");
			useInstanceValues = s.Serialize<bool>(useInstanceValues, name: "useInstanceValues");
			recycling = s.Serialize<bool>(recycling, name: "recycling");
			startEvent = s.SerializeObject<Generic<Event>>(startEvent, name: "startEvent");
			stopEvent = s.SerializeObject<Generic<Event>>(stopEvent, name: "stopEvent");
			onSpawnEvent = s.SerializeObject<Generic<Event>>(onSpawnEvent, name: "onSpawnEvent");
		}
		public override uint? ClassCRC => 0x050E278A;
	}
}

