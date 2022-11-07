namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierBranch : CSerializable {
		public CListO<BezierNode> nodes;
		public CListO<BezierSubBranch> subBranches;
		public CArrayO<Generic<BezierBranchComponent>> components;
		public bool autoStartTweening;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<BezierNode>>(nodes, name: "nodes");
			subBranches = s.SerializeObject<CListO<BezierSubBranch>>(subBranches, name: "subBranches");
			components = s.SerializeObject<CArrayO<Generic<BezierBranchComponent>>>(components, name: "components");
			autoStartTweening = s.Serialize<bool>(autoStartTweening, name: "autoStartTweening");
		}
	}
}

