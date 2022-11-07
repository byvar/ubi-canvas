namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WaterHandsAIComponent_Template : Ray_AIComponent_Template {
		public AABB enemyDetectionRange;
		public Path spawnHandPath;
		public float speedAttack;
		public float speedReturn;
		public float timeWaitOnPlayerEscape;
		public float timeWaitAfterCaught;
		public float timeAnticip;
		public int useRadiusMaxAttack;
		public int linearMode;
		public float distMaxCharge;
		public int randomHands;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<AABB>(enemyDetectionRange, name: "enemyDetectionRange");
			spawnHandPath = s.SerializeObject<Path>(spawnHandPath, name: "spawnHandPath");
			speedAttack = s.Serialize<float>(speedAttack, name: "speedAttack");
			speedReturn = s.Serialize<float>(speedReturn, name: "speedReturn");
			timeWaitOnPlayerEscape = s.Serialize<float>(timeWaitOnPlayerEscape, name: "timeWaitOnPlayerEscape");
			timeWaitAfterCaught = s.Serialize<float>(timeWaitAfterCaught, name: "timeWaitAfterCaught");
			timeAnticip = s.Serialize<float>(timeAnticip, name: "timeAnticip");
			useRadiusMaxAttack = s.Serialize<int>(useRadiusMaxAttack, name: "useRadiusMaxAttack");
			linearMode = s.Serialize<int>(linearMode, name: "linearMode");
			distMaxCharge = s.Serialize<float>(distMaxCharge, name: "distMaxCharge");
			randomHands = s.Serialize<int>(randomHands, name: "randomHands");
		}
		public override uint? ClassCRC => 0x0EDB7ED5;
	}
}

