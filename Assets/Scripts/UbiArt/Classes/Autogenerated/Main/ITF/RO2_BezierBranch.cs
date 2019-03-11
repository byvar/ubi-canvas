using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierBranch : CSerializable {
		[Serialize("nodes"            )] public CList<RO2_BezierNode> nodes;
		[Serialize("subBranches"      )] public CList<RO2_BezierSubBranch> subBranches;
		[Serialize("components"       )] public CArray<Generic<RO2_BezierBranchComponent>> components;
		[Serialize("autoStartTweening")] public bool autoStartTweening;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
			SerializeField(s, nameof(subBranches));
			SerializeField(s, nameof(components));
			SerializeField(s, nameof(autoStartTweening));
		}
	}
}

