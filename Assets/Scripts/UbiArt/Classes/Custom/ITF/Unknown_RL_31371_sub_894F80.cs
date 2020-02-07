namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_31371_sub_894F80 : CSerializable {
		[Serialize("pid"                 )] public int pid;
		[Serialize("name"                )] public string name;
		[Serialize("statusIcon"          )] public uint statusIcon;
		[Serialize("country"             )] public int country;
		[Serialize("globalMedalsRank"    )] public uint globalMedalsRank;
		[Serialize("globalMedalsMaxRank" )] public uint globalMedalsMaxRank;
		[Serialize("diamondMedals"       )] public uint diamondMedals;
		[Serialize("goldMedals"          )] public uint goldMedals;
		[Serialize("silverMedals"        )] public uint silverMedals;
		[Serialize("bronzeMedals"        )] public uint bronzeMedals;
		[Serialize("playerStats"         )] public Unknown_RL_31339_sub_893AE0 playerStats;
		[Serialize("costume"             )] public uint costume;
		[Serialize("totalChallengePlayed")] public uint totalChallengePlayed;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(pid));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(statusIcon));
				SerializeField(s, nameof(country));
				SerializeField(s, nameof(globalMedalsRank));
				SerializeField(s, nameof(globalMedalsMaxRank));
				SerializeField(s, nameof(diamondMedals));
				SerializeField(s, nameof(goldMedals));
				SerializeField(s, nameof(silverMedals));
				SerializeField(s, nameof(bronzeMedals));
				SerializeField(s, nameof(playerStats));
				SerializeField(s, nameof(costume));
				SerializeField(s, nameof(totalChallengePlayed));
			}
		}
	}
}