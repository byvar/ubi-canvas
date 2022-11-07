namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatData : CSerializable {
		public bool allPlayers;
		public uint playerId;
		public CMap<string, StatValue> stats;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			allPlayers = s.Serialize<bool>(allPlayers, name: "allPlayers");
			playerId = s.Serialize<uint>(playerId, name: "playerId");
			stats = s.SerializeObject<CMap<string, StatValue>>(stats, name: "stats");
		}
	}
}

