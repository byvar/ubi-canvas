using UnityEngine;

namespace UbiArt.ITF {
	public partial class TimedSpawnerComponent : ActorComponent {
		[Serialize("spawnDelay"        )] public float spawnDelay;
		[Serialize("spawnRate"         )] public float spawnRate;
		[Serialize("burstElementsCount")] public int burstElementsCount;
		[Serialize("burstCount"        )] public int burstCount;
		[Serialize("burstDelay"        )] public float burstDelay;
		[Serialize("burstElementsCount")] public bool burstElementsCount;
		[Serialize("burstCount"        )] public bool burstCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(spawnDelay));
				SerializeField(s, nameof(spawnRate));
				SerializeField(s, nameof(burstElementsCount));
				SerializeField(s, nameof(burstCount));
				SerializeField(s, nameof(burstDelay));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(spawnDelay));
				SerializeField(s, nameof(spawnRate));
				SerializeField(s, nameof(burstElementsCount));
				SerializeField(s, nameof(burstCount));
				SerializeField(s, nameof(burstDelay));
			} else {
				SerializeField(s, nameof(spawnDelay));
				SerializeField(s, nameof(spawnRate));
				SerializeField(s, nameof(burstElementsCount));
				SerializeField(s, nameof(burstCount));
				SerializeField(s, nameof(burstDelay));
			}
		}
		public override uint? ClassCRC => 0xC67FA43A;
	}
}

