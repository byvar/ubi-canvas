using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
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
		[Serialize("Enum_VH_0__0"           )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("int__1"                 )] public int int__1;
		[Serialize("float__2"               )] public float float__2;
		[Serialize("float__3"               )] public float float__3;
		[Serialize("bool__4"                )] public bool bool__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Enum_VH_0__0));
				SerializeField(s, nameof(int__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(bool__4));
			} else {
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
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xAF8D415D;
	}
}

