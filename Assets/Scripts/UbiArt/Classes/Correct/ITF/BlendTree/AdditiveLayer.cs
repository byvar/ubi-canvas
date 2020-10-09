using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class AdditiveLayer<T> : CSerializable {
		public CListO<Generic<BlendTreeNode<T>>> nodes;
		public CListO<BlendTreeTransition<T>> nodeTransitions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<Generic<BlendTreeNode<T>>>>(nodes, name: "nodes");
			nodeTransitions = s.SerializeObject<CListO<BlendTreeTransition<T>>>(nodeTransitions, name: "nodeTransitions");
		}
	}
}

