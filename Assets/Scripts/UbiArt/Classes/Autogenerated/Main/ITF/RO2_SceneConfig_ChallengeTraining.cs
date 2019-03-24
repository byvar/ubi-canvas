using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SceneConfig_ChallengeTraining : RO2_SceneConfig_Base {
		[Serialize("modePath"        )] public Path modePath;
		[Serialize("debugForcedSeed" )] public uint debugForcedSeed;
		[Serialize("debugCurrentSeed")] public uint debugCurrentSeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(modePath));
				SerializeField(s, nameof(debugForcedSeed));
			}
			if (s.HasFlags(SerializeFlags.Editor)) {
				SerializeField(s, nameof(debugCurrentSeed));
			}
		}
		public override uint? ClassCRC => 0xCF227910;
	}
}

