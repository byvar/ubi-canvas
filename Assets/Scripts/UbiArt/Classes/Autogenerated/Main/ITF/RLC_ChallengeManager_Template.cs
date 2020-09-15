using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ChallengeManager_Template : TemplateObj {
		public float lumScoreMult;
		public float distScoreMult;
		public Path challengeMainPath;
		public Path tombActorPath;
		public Path challengeTokenIconSmall;
		public uint maxTombs;
		public uint forcedChallengeParamID;
		public uint adventureSequenceMin;
		public Path leaderboardPlayerScenePath;
		public Path leaderboardRewardScenePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumScoreMult = s.Serialize<float>(lumScoreMult, name: "lumScoreMult");
			distScoreMult = s.Serialize<float>(distScoreMult, name: "distScoreMult");
			challengeMainPath = s.SerializeObject<Path>(challengeMainPath, name: "challengeMainPath");
			tombActorPath = s.SerializeObject<Path>(tombActorPath, name: "tombActorPath");
			challengeTokenIconSmall = s.SerializeObject<Path>(challengeTokenIconSmall, name: "challengeTokenIconSmall");
			maxTombs = s.Serialize<uint>(maxTombs, name: "maxTombs");
			forcedChallengeParamID = s.Serialize<uint>(forcedChallengeParamID, name: "forcedChallengeParamID");
			adventureSequenceMin = s.Serialize<uint>(adventureSequenceMin, name: "adventureSequenceMin");
			leaderboardPlayerScenePath = s.SerializeObject<Path>(leaderboardPlayerScenePath, name: "leaderboardPlayerScenePath");
			leaderboardRewardScenePath = s.SerializeObject<Path>(leaderboardRewardScenePath, name: "leaderboardRewardScenePath");
		}
		public override uint? ClassCRC => 0xD0405FD6;
	}
}

