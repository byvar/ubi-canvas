namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SliderHeadBranchComponent_Template : BezierBranchComponent_Template {
		public float slideForceFactor = 0.1f;
		public float slideSpeedSmoothA = 0.1f;
		public float slideSpeedSmoothB = 0.1f;
		public float growSpeedSmoothA = 0.01f;
		public float growSpeedSmoothB = 0.01f;
		public float waitDuration = 2f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			slideForceFactor = s.Serialize<float>(slideForceFactor, name: "slideForceFactor");
			slideSpeedSmoothA = s.Serialize<float>(slideSpeedSmoothA, name: "slideSpeedSmoothA");
			slideSpeedSmoothB = s.Serialize<float>(slideSpeedSmoothB, name: "slideSpeedSmoothB");
			growSpeedSmoothA = s.Serialize<float>(growSpeedSmoothA, name: "growSpeedSmoothA");
			growSpeedSmoothB = s.Serialize<float>(growSpeedSmoothB, name: "growSpeedSmoothB");
			waitDuration = s.Serialize<float>(waitDuration, name: "waitDuration");
		}
		public override uint? ClassCRC => 0x3D41C39C;
	}
}

