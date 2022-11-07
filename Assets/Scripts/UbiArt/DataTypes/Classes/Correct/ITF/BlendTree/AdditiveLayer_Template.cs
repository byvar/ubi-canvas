namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class AdditiveLayer_Template<T> : CSerializable {
		public CListO<Generic<BlendTreeNodeTemplate<T>>> nodes;
		public CListO<BlendTreeTransition_Template<T>> nodeTransitions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<Generic<BlendTreeNodeTemplate<T>>>>(nodes, name: "nodes");
			nodeTransitions = s.SerializeObject<CListO<BlendTreeTransition_Template<T>>>(nodeTransitions, name: "nodeTransitions");
		}
	}
}

