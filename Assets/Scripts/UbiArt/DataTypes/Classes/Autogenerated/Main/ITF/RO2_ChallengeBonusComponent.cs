namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ChallengeBonusComponent : ActorComponent {
		public float challengeDuration = 30f;
		public uint maxNumberToTake = 100;
		public float RecapScoreDisplayDuration = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			challengeDuration = s.Serialize<float>(challengeDuration, name: "challengeDuration");
			maxNumberToTake = s.Serialize<uint>(maxNumberToTake, name: "maxNumberToTake");
			RecapScoreDisplayDuration = s.Serialize<float>(RecapScoreDisplayDuration, name: "RecapScoreDisplayDuration");
		}
		public override uint? ClassCRC => 0xCD329E92;
	}
}

