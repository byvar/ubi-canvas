using UnityEngine;

namespace UbiArt.ITF {
	[Games(~GameFlags.ROVersion)]
	public partial class AdditiveLayer_Template<T> : CSerializable {
		public CList<Generic<BlendTreeNodeTemplate<T>>> nodes;
		public CList<BlendTreeTransition_Template<T>> nodeTransitions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CList<Generic<BlendTreeNodeTemplate<T>>>>(nodes, name: "nodes");
			nodeTransitions = s.SerializeObject<CList<BlendTreeTransition_Template<T>>>(nodeTransitions, name: "nodeTransitions");
		}
	}
}

