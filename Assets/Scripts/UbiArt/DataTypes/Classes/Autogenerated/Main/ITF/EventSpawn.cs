namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class EventSpawn : Event {
		public EventSpawn__e spawnMode;
		public float waveDelay;
		public float waveGroupDelay;
		public int minSimultaneousPerGroup;
		public int totalStock;
		public float minRespawnDelay;
		public float maxRespawnDelay;
		public EventSpawn__eWaveType waveType;
		public int waveCount;
		public bool useTarget;
		public bool BindToParent;
		public Enum_VH_0 Enum_VH_0__0;
		public int int__1;
		public float float__2;
		public float float__3;
		public bool bool__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
				int__1 = s.Serialize<int>(int__1, name: "int__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
			} else {
				spawnMode = s.Serialize<EventSpawn__e>(spawnMode, name: "spawnMode");
				waveDelay = s.Serialize<float>(waveDelay, name: "waveDelay");
				waveGroupDelay = s.Serialize<float>(waveGroupDelay, name: "waveGroupDelay");
				if (s.HasFlags(SerializeFlags.Default)) {
					minSimultaneousPerGroup = s.Serialize<int>(minSimultaneousPerGroup, name: "minSimultaneousPerGroup");
					totalStock = s.Serialize<int>(totalStock, name: "totalStock");
					minRespawnDelay = s.Serialize<float>(minRespawnDelay, name: "minRespawnDelay");
					maxRespawnDelay = s.Serialize<float>(maxRespawnDelay, name: "maxRespawnDelay");
					waveType = s.Serialize<EventSpawn__eWaveType>(waveType, name: "waveType");
					waveCount = s.Serialize<int>(waveCount, name: "waveCount");
				}
				useTarget = s.Serialize<bool>(useTarget, name: "useTarget");
				BindToParent = s.Serialize<bool>(BindToParent, name: "BindToParent");
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

