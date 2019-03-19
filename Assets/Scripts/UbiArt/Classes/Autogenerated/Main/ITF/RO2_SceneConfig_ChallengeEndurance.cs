using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SceneConfig_ChallengeEndurance : RO2_SceneConfig_Base {
		[Serialize("modePath"        )] public Path modePath;
		[Serialize("debugForcedSeed" )] public uint debugForcedSeed;
		[Serialize("debugCurrentSeed")] public uint debugCurrentSeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(modePath));
				SerializeField(s, nameof(debugForcedSeed));
			}
			if (s.HasFlags(SerializeFlags.Flags_x03)) {
				SerializeField(s, nameof(debugCurrentSeed));
			}
		}
		public override uint? ClassCRC => 0x2C366F1D;
	}
}

