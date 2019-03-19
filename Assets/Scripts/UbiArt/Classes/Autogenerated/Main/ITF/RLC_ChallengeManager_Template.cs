using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ChallengeManager_Template : TemplateObj {
		[Serialize("lumScoreMult"              )] public float lumScoreMult;
		[Serialize("distScoreMult"             )] public float distScoreMult;
		[Serialize("challengeMainPath"         )] public Path challengeMainPath;
		[Serialize("tombActorPath"             )] public Path tombActorPath;
		[Serialize("challengeTokenIconSmall"   )] public Path challengeTokenIconSmall;
		[Serialize("maxTombs"                  )] public uint maxTombs;
		[Serialize("forcedChallengeParamID"    )] public uint forcedChallengeParamID;
		[Serialize("adventureSequenceMin"      )] public uint adventureSequenceMin;
		[Serialize("leaderboardPlayerScenePath")] public Path leaderboardPlayerScenePath;
		[Serialize("leaderboardRewardScenePath")] public Path leaderboardRewardScenePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lumScoreMult));
			SerializeField(s, nameof(distScoreMult));
			SerializeField(s, nameof(challengeMainPath));
			SerializeField(s, nameof(tombActorPath));
			SerializeField(s, nameof(challengeTokenIconSmall));
			SerializeField(s, nameof(maxTombs));
			SerializeField(s, nameof(forcedChallengeParamID));
			SerializeField(s, nameof(adventureSequenceMin));
			SerializeField(s, nameof(leaderboardPlayerScenePath));
			SerializeField(s, nameof(leaderboardRewardScenePath));
		}
		public override uint? ClassCRC => 0xD0405FD6;
	}
}

