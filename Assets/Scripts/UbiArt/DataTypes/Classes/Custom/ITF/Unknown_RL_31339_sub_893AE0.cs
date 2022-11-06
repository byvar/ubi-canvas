namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_31339_sub_893AE0 : CSerializable {
		public Unknown_RL_31303_sub_892AF0 lums;
		public Unknown_RL_31303_sub_892AF0 distance;
		public Unknown_RL_31303_sub_892AF0 kills;
		public Unknown_RL_31303_sub_892AF0 jumps;
		public Unknown_RL_31303_sub_892AF0 deaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				lums = s.SerializeObject<Unknown_RL_31303_sub_892AF0>(lums, name: "lums");
				distance = s.SerializeObject<Unknown_RL_31303_sub_892AF0>(distance, name: "distance");
				kills = s.SerializeObject<Unknown_RL_31303_sub_892AF0>(kills, name: "kills");
				jumps = s.SerializeObject<Unknown_RL_31303_sub_892AF0>(jumps, name: "jumps");
				deaths = s.SerializeObject<Unknown_RL_31303_sub_892AF0>(deaths, name: "deaths");
			}
		}

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_31303_sub_892AF0 : CSerializable {
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
