namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BezierBranchLightOrbChainLinkRendererComponent_Template : BezierBranchBaseRendererComponent_Template {
		public float branchSpeed;
		public float boundsOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			branchSpeed = s.Serialize<float>(branchSpeed, name: "branchSpeed");
			boundsOffset = s.Serialize<float>(boundsOffset, name: "boundsOffset");
		}
		public override uint? ClassCRC => 0x44596E84;
	}
}

