using UnityEngine;

namespace UbiArt.ITF {
	[Games(~GameFlags.ROVersion)]
	public partial class AdditiveLayer<T> : CSerializable {
		[Serialize("nodes"          )] public CList<Generic<BlendTreeNode<T>>> nodes;
		[Serialize("nodeTransitions")] public CList<BlendTreeTransition<T>> nodeTransitions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
			SerializeField(s, nameof(nodeTransitions));
		}
	}
}

