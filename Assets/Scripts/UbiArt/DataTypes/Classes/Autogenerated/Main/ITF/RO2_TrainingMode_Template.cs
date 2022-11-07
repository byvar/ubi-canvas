namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_TrainingMode_Template : RO2_ChallengeCommon_Template {
		public bool useListOrder;
		public Path timerPath;
		public float challengeDuration;
		public float endBrickSuccessDelay;
		public float endBrickFailureDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useListOrder = s.Serialize<bool>(useListOrder, name: "useListOrder");
			timerPath = s.SerializeObject<Path>(timerPath, name: "timerPath");
			challengeDuration = s.Serialize<float>(challengeDuration, name: "challengeDuration");
			endBrickSuccessDelay = s.Serialize<float>(endBrickSuccessDelay, name: "endBrickSuccessDelay");
			endBrickFailureDelay = s.Serialize<float>(endBrickFailureDelay, name: "endBrickFailureDelay");
		}
		public override uint? ClassCRC => 0x92699D61;
	}
}

