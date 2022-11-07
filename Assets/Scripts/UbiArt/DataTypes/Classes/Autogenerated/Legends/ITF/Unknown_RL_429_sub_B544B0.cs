namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_429_sub_B544B0 : CSerializable {
		public int SpawnLimitNb;
		public uint WaveSpawnNb;
		public uint NbToRespawn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SpawnLimitNb = s.Serialize<int>(SpawnLimitNb, name: "SpawnLimitNb");
				WaveSpawnNb = s.Serialize<uint>(WaveSpawnNb, name: "WaveSpawnNb");
				NbToRespawn = s.Serialize<uint>(NbToRespawn, name: "NbToRespawn");
			}
		}
		public override uint? ClassCRC => 0xDF60AF3D;
	}
}

