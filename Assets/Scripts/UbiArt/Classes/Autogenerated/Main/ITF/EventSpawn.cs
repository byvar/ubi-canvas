using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSpawn : Event {
		[Serialize("spawnMode"              )] public EventSpawn__e spawnMode;
		[Serialize("waveDelay"              )] public float waveDelay;
		[Serialize("waveGroupDelay"         )] public float waveGroupDelay;
		[Serialize("minSimultaneousPerGroup")] public int minSimultaneousPerGroup;
		[Serialize("totalStock"             )] public int totalStock;
		[Serialize("minRespawnDelay"        )] public float minRespawnDelay;
		[Serialize("maxRespawnDelay"        )] public float maxRespawnDelay;
		[Serialize("waveType"               )] public EventSpawn__eWaveType waveType;
		[Serialize("waveCount"              )] public int waveCount;
		[Serialize("useTarget"              )] public bool useTarget;
		[Serialize("BindToParent"           )] public bool BindToParent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnMode));
			SerializeField(s, nameof(waveDelay));
			SerializeField(s, nameof(waveGroupDelay));
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(minSimultaneousPerGroup));
				SerializeField(s, nameof(totalStock));
				SerializeField(s, nameof(minRespawnDelay));
				SerializeField(s, nameof(maxRespawnDelay));
				SerializeField(s, nameof(waveType));
				SerializeField(s, nameof(waveCount));
			}
			SerializeField(s, nameof(useTarget));
			SerializeField(s, nameof(BindToParent));
		}
		public enum EventSpawn__e {
			[Serialize("EventSpawn::eWave"        )] Wave = 0,
			[Serialize("EventSpawn::eSimultaneous")] Simultaneous = 1,
		}
		public enum EventSpawn__eWaveType {
			[Serialize("EventSpawn::eWaveTypeOneWay"    )] OneWay = 0,
			[Serialize("EventSpawn::eWaveTypeRoundTrip" )] RoundTrip = 1,
			[Serialize("EventSpawn::eWaveTypeInverseWay")] InverseWay = 2,
		}
		public override uint? ClassCRC => 0xAF8D415D;
	}
}

