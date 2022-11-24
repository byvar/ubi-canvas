namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class RO2_BezierBranch : CSerializable {
		public CListO<RO2_BezierNode> nodes;
		public CListO<RO2_BezierSubBranch> subBranches;
		public CArrayO<Generic<RO2_BezierBranchComponent>> components;
		public bool autoStartTweening = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<RO2_BezierNode>>(nodes, name: "nodes");
			subBranches = s.SerializeObject<CListO<RO2_BezierSubBranch>>(subBranches, name: "subBranches");
			components = s.SerializeObject<CArrayO<Generic<RO2_BezierBranchComponent>>>(components, name: "components");
			autoStartTweening = s.Serialize<bool>(autoStartTweening, name: "autoStartTweening");
		}
	}
}

