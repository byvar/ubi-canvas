namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RetractOnTapEyeBranchComponent_Template : BezierBranchComponent_Template {
		public float tapRetractDistance = 1f;
		public float tapRetractSpeedSmoothA = 0.1f;
		public float tapRetractSpeedSmoothB = 0.1f;
		public float growBackCooldown = 1f;
		public float growBackSpeedSmoothA = 0.1f;
		public float growBackSpeedSmoothB = 0.1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tapRetractDistance = s.Serialize<float>(tapRetractDistance, name: "tapRetractDistance");
			tapRetractSpeedSmoothA = s.Serialize<float>(tapRetractSpeedSmoothA, name: "tapRetractSpeedSmoothA");
			tapRetractSpeedSmoothB = s.Serialize<float>(tapRetractSpeedSmoothB, name: "tapRetractSpeedSmoothB");
			growBackCooldown = s.Serialize<float>(growBackCooldown, name: "growBackCooldown");
			growBackSpeedSmoothA = s.Serialize<float>(growBackSpeedSmoothA, name: "growBackSpeedSmoothA");
			growBackSpeedSmoothB = s.Serialize<float>(growBackSpeedSmoothB, name: "growBackSpeedSmoothB");
		}
		public override uint? ClassCRC => 0x32976BAD;
	}
}

