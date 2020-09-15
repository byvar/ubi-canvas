namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_31371_sub_894F80 : CSerializable {
		public int pid;
		public string name;
		public uint statusIcon;
		public int country;
		public uint globalMedalsRank;
		public uint globalMedalsMaxRank;
		public uint diamondMedals;
		public uint goldMedals;
		public uint silverMedals;
		public uint bronzeMedals;
		public Unknown_RL_31339_sub_893AE0 playerStats;
		public uint costume;
		public uint totalChallengePlayed;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				pid = s.Serialize<int>(pid, name: "pid");
				name = s.Serialize<string>(name, name: "name");
				statusIcon = s.Serialize<uint>(statusIcon, name: "statusIcon");
				country = s.Serialize<int>(country, name: "country");
				globalMedalsRank = s.Serialize<uint>(globalMedalsRank, name: "globalMedalsRank");
				globalMedalsMaxRank = s.Serialize<uint>(globalMedalsMaxRank, name: "globalMedalsMaxRank");
				diamondMedals = s.Serialize<uint>(diamondMedals, name: "diamondMedals");
				goldMedals = s.Serialize<uint>(goldMedals, name: "goldMedals");
				silverMedals = s.Serialize<uint>(silverMedals, name: "silverMedals");
				bronzeMedals = s.Serialize<uint>(bronzeMedals, name: "bronzeMedals");
				playerStats = s.SerializeObject<Unknown_RL_31339_sub_893AE0>(playerStats, name: "playerStats");
				costume = s.Serialize<uint>(costume, name: "costume");
				totalChallengePlayed = s.Serialize<uint>(totalChallengePlayed, name: "totalChallengePlayed");
			}
		}
	}
}
