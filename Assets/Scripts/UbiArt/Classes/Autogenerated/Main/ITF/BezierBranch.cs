using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierBranch : CSerializable {
		public CList<BezierNode> nodes;
		public CList<BezierSubBranch> subBranches;
		public CArray<Generic<BezierBranchComponent>> components;
		public bool autoStartTweening;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CList<BezierNode>>(nodes, name: "nodes");
			subBranches = s.SerializeObject<CList<BezierSubBranch>>(subBranches, name: "subBranches");
			components = s.SerializeObject<CArray<Generic<BezierBranchComponent>>>(components, name: "components");
			autoStartTweening = s.Serialize<bool>(autoStartTweening, name: "autoStartTweening");
		}
	}
}

