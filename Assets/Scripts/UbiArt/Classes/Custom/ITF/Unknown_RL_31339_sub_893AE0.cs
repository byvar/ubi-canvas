namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_31339_sub_893AE0 : CSerializable {
		[Serialize("lums"    )] public Unknown_RL_31303_sub_892AF0 lums;
		[Serialize("distance")] public Unknown_RL_31303_sub_892AF0 distance;
		[Serialize("kills"   )] public Unknown_RL_31303_sub_892AF0 kills;
		[Serialize("jumps"   )] public Unknown_RL_31303_sub_892AF0 jumps;
		[Serialize("deaths"  )] public Unknown_RL_31303_sub_892AF0 deaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(lums));
				SerializeField(s, nameof(distance));
				SerializeField(s, nameof(kills));
				SerializeField(s, nameof(jumps));
				SerializeField(s, nameof(deaths));
			}
		}

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_31303_sub_892AF0 : CSerializable {
			[Serialize("value")] public float value;
			[Serialize("rank" )] public uint rank;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(value));
					SerializeField(s, nameof(rank));
				}
			}
		}
	}
}