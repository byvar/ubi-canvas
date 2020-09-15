using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_BezierBranch : CSerializable {
		public CList<RO2_BezierNode> nodes;
		public CList<RO2_BezierSubBranch> subBranches;
		public CArray<Generic<RO2_BezierBranchComponent>> components;
		public bool autoStartTweening;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CList<RO2_BezierNode>>(nodes, name: "nodes");
			subBranches = s.SerializeObject<CList<RO2_BezierSubBranch>>(subBranches, name: "subBranches");
			components = s.SerializeObject<CArray<Generic<RO2_BezierBranchComponent>>>(components, name: "components");
			autoStartTweening = s.Serialize<bool>(autoStartTweening, name: "autoStartTweening");
		}
	}
}

