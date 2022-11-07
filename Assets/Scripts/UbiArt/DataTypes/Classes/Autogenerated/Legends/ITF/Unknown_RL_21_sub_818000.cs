namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_21_sub_818000 : CSerializable {
		public float modeDuration;
		public float respawnDuration;
		public float retryDelay;
		public float spawnPointDeactivationDuration;
		public int allowCrushInMidAir;
		public float scoreChangeBlinkDuration;
		public float timeOutBlinkDuration;
		public int onlineWanted;
		public Color scoreColorTeamA;
		public Color scoreColorTeamB;
		public float scoreAlpha;
		public float newPlayerTimer;
		public float countDownTimer;
		public float loadTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			modeDuration = s.Serialize<float>(modeDuration, name: "modeDuration");
			respawnDuration = s.Serialize<float>(respawnDuration, name: "respawnDuration");
			retryDelay = s.Serialize<float>(retryDelay, name: "retryDelay");
			spawnPointDeactivationDuration = s.Serialize<float>(spawnPointDeactivationDuration, name: "spawnPointDeactivationDuration");
			allowCrushInMidAir = s.Serialize<int>(allowCrushInMidAir, name: "allowCrushInMidAir");
			scoreChangeBlinkDuration = s.Serialize<float>(scoreChangeBlinkDuration, name: "scoreChangeBlinkDuration");
			timeOutBlinkDuration = s.Serialize<float>(timeOutBlinkDuration, name: "timeOutBlinkDuration");
			onlineWanted = s.Serialize<int>(onlineWanted, name: "onlineWanted");
			scoreColorTeamA = s.SerializeObject<Color>(scoreColorTeamA, name: "scoreColorTeamA");
			scoreColorTeamB = s.SerializeObject<Color>(scoreColorTeamB, name: "scoreColorTeamB");
			scoreAlpha = s.Serialize<float>(scoreAlpha, name: "scoreAlpha");
			newPlayerTimer = s.Serialize<float>(newPlayerTimer, name: "newPlayerTimer");
			countDownTimer = s.Serialize<float>(countDownTimer, name: "countDownTimer");
			loadTime = s.Serialize<float>(loadTime, name: "loadTime");
		}
		public override uint? ClassCRC => 0x39850EED;
	}
}

