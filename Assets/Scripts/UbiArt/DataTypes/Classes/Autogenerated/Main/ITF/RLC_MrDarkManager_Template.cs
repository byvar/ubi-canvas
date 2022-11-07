namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_MrDarkManager_Template : CSerializable {
		public Path scoreRecapPath;
		public Placeholder nonLethalLevelsWorldIndexes;
		public Placeholder nonLethalLevelsMapIndexes;
		public Placeholder firstHalfLevelsWorldIndexes;
		public Placeholder firstHalfLevelsMapIndexes;
		public Placeholder secondHalfLevelsWorldIndexes;
		public Placeholder secondHalfLevelsMapIndexes;
		public Placeholder bossAndBonusLevelsWorldIndexes;
		public Placeholder bossAndBonusLevelsMapIndexes;
		public Placeholder settingsPerAwesomenessLevelChallengeReach;
		public Placeholder settingsPerAwesomenessLevelChallengeLums;
		public Placeholder settingsPerAwesomenessLevelAdventureFinish;
		public Placeholder settingsPerAwesomenessLevelAdventureFind;
		public Placeholder settingsPerAwesomenessLevelMusicalTasks;
		public Placeholder settingsPerAwesomenessLevelMarathonTasks;
		public byte numberMapsMusical;
		public Placeholder modifiersUserFriendly;
		public Placeholder challengeModifiersUserFriendly;
		public Placeholder objectsToFindUserFriendly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scoreRecapPath = s.SerializeObject<Path>(scoreRecapPath, name: "scoreRecapPath");
			nonLethalLevelsWorldIndexes = s.SerializeObject<Placeholder>(nonLethalLevelsWorldIndexes, name: "nonLethalLevelsWorldIndexes");
			nonLethalLevelsMapIndexes = s.SerializeObject<Placeholder>(nonLethalLevelsMapIndexes, name: "nonLethalLevelsMapIndexes");
			firstHalfLevelsWorldIndexes = s.SerializeObject<Placeholder>(firstHalfLevelsWorldIndexes, name: "firstHalfLevelsWorldIndexes");
			firstHalfLevelsMapIndexes = s.SerializeObject<Placeholder>(firstHalfLevelsMapIndexes, name: "firstHalfLevelsMapIndexes");
			secondHalfLevelsWorldIndexes = s.SerializeObject<Placeholder>(secondHalfLevelsWorldIndexes, name: "secondHalfLevelsWorldIndexes");
			secondHalfLevelsMapIndexes = s.SerializeObject<Placeholder>(secondHalfLevelsMapIndexes, name: "secondHalfLevelsMapIndexes");
			bossAndBonusLevelsWorldIndexes = s.SerializeObject<Placeholder>(bossAndBonusLevelsWorldIndexes, name: "bossAndBonusLevelsWorldIndexes");
			bossAndBonusLevelsMapIndexes = s.SerializeObject<Placeholder>(bossAndBonusLevelsMapIndexes, name: "bossAndBonusLevelsMapIndexes");
			settingsPerAwesomenessLevelChallengeReach = s.SerializeObject<Placeholder>(settingsPerAwesomenessLevelChallengeReach, name: "settingsPerAwesomenessLevelChallengeReach");
			settingsPerAwesomenessLevelChallengeLums = s.SerializeObject<Placeholder>(settingsPerAwesomenessLevelChallengeLums, name: "settingsPerAwesomenessLevelChallengeLums");
			settingsPerAwesomenessLevelAdventureFinish = s.SerializeObject<Placeholder>(settingsPerAwesomenessLevelAdventureFinish, name: "settingsPerAwesomenessLevelAdventureFinish");
			settingsPerAwesomenessLevelAdventureFind = s.SerializeObject<Placeholder>(settingsPerAwesomenessLevelAdventureFind, name: "settingsPerAwesomenessLevelAdventureFind");
			settingsPerAwesomenessLevelMusicalTasks = s.SerializeObject<Placeholder>(settingsPerAwesomenessLevelMusicalTasks, name: "settingsPerAwesomenessLevelMusicalTasks");
			settingsPerAwesomenessLevelMarathonTasks = s.SerializeObject<Placeholder>(settingsPerAwesomenessLevelMarathonTasks, name: "settingsPerAwesomenessLevelMarathonTasks");
			numberMapsMusical = s.Serialize<byte>(numberMapsMusical, name: "numberMapsMusical");
			modifiersUserFriendly = s.SerializeObject<Placeholder>(modifiersUserFriendly, name: "modifiersUserFriendly");
			challengeModifiersUserFriendly = s.SerializeObject<Placeholder>(challengeModifiersUserFriendly, name: "challengeModifiersUserFriendly");
			objectsToFindUserFriendly = s.SerializeObject<Placeholder>(objectsToFindUserFriendly, name: "objectsToFindUserFriendly");
		}
		public override uint? ClassCRC => 0xD63C0714;
	}
}

