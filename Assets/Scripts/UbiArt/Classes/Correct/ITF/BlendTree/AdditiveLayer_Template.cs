using UnityEngine;

namespace UbiArt.ITF {
	[Games(~GameFlags.ROVersion)]
	public partial class AdditiveLayer_Template<T> : CSerializable {
		[Serialize("nodes"          )] public CList<Generic<BlendTreeNodeTemplate<T>>> nodes;
		[Serialize("nodeTransitions")] public CList<BlendTreeTransition_Template<T>> nodeTransitions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
			SerializeField(s, nameof(nodeTransitions));
		}
	}
}

