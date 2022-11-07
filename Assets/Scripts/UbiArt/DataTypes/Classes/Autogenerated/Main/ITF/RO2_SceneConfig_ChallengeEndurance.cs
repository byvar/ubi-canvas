namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SceneConfig_ChallengeEndurance : RO2_SceneConfig_Base {
		public Path modePath;
		public uint debugForcedSeed;
		public uint debugCurrentSeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				modePath = s.SerializeObject<Path>(modePath, name: "modePath");
				debugForcedSeed = s.Serialize<uint>(debugForcedSeed, name: "debugForcedSeed");
			}
			if (s.HasFlags(SerializeFlags.Editor)) {
				debugCurrentSeed = s.Serialize<uint>(debugCurrentSeed, name: "debugCurrentSeed");
			}
		}
		public override uint? ClassCRC => 0x2C366F1D;
	}
}

