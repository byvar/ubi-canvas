namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_RetractOnTapEyeBranchComponent_Template : RO2_BezierBranchComponent_Template {
		public float tapRetractDistance;
		public float tapRetractSpeedSmoothA;
		public float tapRetractSpeedSmoothB;
		public float growBackCooldown;
		public float growBackSpeedSmoothA;
		public float growBackSpeedSmoothB;
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

