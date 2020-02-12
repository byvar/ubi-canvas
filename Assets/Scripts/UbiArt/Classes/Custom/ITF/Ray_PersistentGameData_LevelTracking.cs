using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_LevelTracking : CSerializable {
		[Serialize("runCount"                )] public uint runCount;
		[Serialize("challengeTimeAttackCount")] public uint challengeTimeAttackCount;
		[Serialize("challengeHidden1"        )] public uint challengeHidden1;
		[Serialize("challengeHidden2"        )] public uint challengeHidden2;
		[Serialize("challengeCage"           )] public uint challengeCage;
		[Serialize("firstTimeLevelCompleted" )] public float firstTimeLevelCompleted;
		[Serialize("challengeLumsStage1"     )] public uint challengeLumsStage1;
		[Serialize("challengeLumsStage2"     )] public uint challengeLumsStage2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(runCount));
			SerializeField(s, nameof(challengeTimeAttackCount));
			SerializeField(s, nameof(challengeHidden1));
			SerializeField(s, nameof(challengeHidden2));
			SerializeField(s, nameof(challengeCage));
			SerializeField(s, nameof(firstTimeLevelCompleted));
			SerializeField(s, nameof(challengeLumsStage1));
			SerializeField(s, nameof(challengeLumsStage2));
		}
	}
}