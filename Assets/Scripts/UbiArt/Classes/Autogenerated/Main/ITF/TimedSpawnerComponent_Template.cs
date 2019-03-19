using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TimedSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("actorToSpawn"      )] public Path actorToSpawn;
		[Serialize("spawnDelay"        )] public float spawnDelay;
		[Serialize("spawnRate"         )] public float spawnRate;
		[Serialize("burstElementsCount")] public int burstElementsCount;
		[Serialize("burstCount"        )] public int burstCount;
		[Serialize("burstDelay"        )] public float burstDelay;
		[Serialize("useInstanceValues" )] public bool useInstanceValues;
		[Serialize("recycling"         )] public bool recycling;
		[Serialize("startEvent"        )] public Generic<Event> startEvent;
		[Serialize("stopEvent"         )] public Generic<Event> stopEvent;
		[Serialize("onSpawnEvent"      )] public Generic<Event> onSpawnEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorToSpawn));
			SerializeField(s, nameof(spawnDelay));
			SerializeField(s, nameof(spawnRate));
			SerializeField(s, nameof(burstElementsCount));
			SerializeField(s, nameof(burstCount));
			SerializeField(s, nameof(burstDelay));
			SerializeField(s, nameof(useInstanceValues));
			SerializeField(s, nameof(recycling));
			SerializeField(s, nameof(startEvent));
			SerializeField(s, nameof(stopEvent));
			SerializeField(s, nameof(onSpawnEvent));
		}
		public override uint? ClassCRC => 0x050E278A;
	}
}

