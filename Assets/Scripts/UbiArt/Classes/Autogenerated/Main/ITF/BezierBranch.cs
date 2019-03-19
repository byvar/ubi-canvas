using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierBranch : CSerializable {
		[Serialize("nodes"            )] public CList<BezierNode> nodes;
		[Serialize("subBranches"      )] public CList<BezierSubBranch> subBranches;
		[Serialize("components"       )] public CArray<Generic<BezierBranchComponent>> components;
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

