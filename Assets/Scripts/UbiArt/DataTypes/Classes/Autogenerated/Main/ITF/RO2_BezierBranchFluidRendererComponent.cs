namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierBranchFluidRendererComponent : RO2_BezierBranchBaseRendererComponent {
		public bool startActivated = true;
		public float branchSpeed = 10f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startActivated = s.Serialize<bool>(startActivated, name: "startActivated");
			branchSpeed = s.Serialize<float>(branchSpeed, name: "branchSpeed");
		}
		public override uint? ClassCRC => 0x6F414625;
	}
}

