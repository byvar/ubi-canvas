namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BezierBranchLumsChainLinkRendererComponent_Template : RO2_BezierBranchBaseRendererComponent_Template {
		public float branchSpeed = 2f;
		public float boundsOffset = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			branchSpeed = s.Serialize<float>(branchSpeed, name: "branchSpeed");
			boundsOffset = s.Serialize<float>(boundsOffset, name: "boundsOffset");
		}
		public override uint? ClassCRC => 0xE63425E4;
	}
}

