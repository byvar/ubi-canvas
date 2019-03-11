using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ChallengeEnduranceDebuggerComponent : ActorComponent {
		[Serialize("modePath"                     )] public Path modePath;
		[Serialize("startDifficulty"              )] public uint startDifficulty;
		[Serialize("stressTestMinSeed"            )] public uint stressTestMinSeed;
		[Serialize("stressTestMaxSeed"            )] public uint stressTestMaxSeed;
		[Serialize("stressTestSpawnCount"         )] public uint stressTestSpawnCount;
		[Serialize("stressTestCompetitionDistance")] public float stressTestCompetitionDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(modePath));
				SerializeField(s, nameof(startDifficulty));
				SerializeField(s, nameof(stressTestMinSeed));
				SerializeField(s, nameof(stressTestMaxSeed));
				SerializeField(s, nameof(stressTestSpawnCount));
				SerializeField(s, nameof(stressTestCompetitionDistance));
			}
		}
		public override uint? ClassCRC => 0x69C804F3;
	}
}

