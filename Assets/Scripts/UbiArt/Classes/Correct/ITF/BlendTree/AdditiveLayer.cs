using UnityEngine;

namespace UbiArt.ITF {
	[Games(~GameFlags.ROVersion)]
	public partial class AdditiveLayer<T> : CSerializable {
		public CList<Generic<BlendTreeNode<T>>> nodes;
		public CList<BlendTreeTransition<T>> nodeTransitions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CList<Generic<BlendTreeNode<T>>>>(nodes, name: "nodes");
			nodeTransitions = s.SerializeObject<CList<BlendTreeTransition<T>>>(nodeTransitions, name: "nodeTransitions");
		}
	}
}

