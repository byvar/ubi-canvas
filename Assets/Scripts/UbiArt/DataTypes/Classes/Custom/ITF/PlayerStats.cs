namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class PlayerStats : CSerializable {
		public PlayerStat lums;
		public PlayerStat distance;
		public PlayerStat kills;
		public PlayerStat jumps;
		public PlayerStat deaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				lums = s.SerializeObject<PlayerStat>(lums, name: "lums");
				distance = s.SerializeObject<PlayerStat>(distance, name: "distance");
				kills = s.SerializeObject<PlayerStat>(kills, name: "kills");
				jumps = s.SerializeObject<PlayerStat>(jumps, name: "jumps");
				deaths = s.SerializeObject<PlayerStat>(deaths, name: "deaths");
			}
		}

		[Games(GameFlags.RL)]
		public partial class PlayerStat : CSerializable {
			public float value;
			public uint rank;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					value = s.Serialize<float>(value, name: "value");
					rank = s.Serialize<uint>(rank, name: "rank");
				}
			}
		}
	}
}
