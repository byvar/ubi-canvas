namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeTemplate<T> : CSerializable {
		public CListO<Generic<BlendTreeNodeTemplate<T>>> nodes;
		public CListO<BlendTreeTransition_Template<T>> nodeTransitions;
		public CListO<AdditiveLayer_Template<T>> additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<Generic<BlendTreeNodeTemplate<T>>>>(nodes, name: "nodes");
			nodeTransitions = s.SerializeObject<CListO<BlendTreeTransition_Template<T>>>(nodeTransitions, name: "nodeTransitions");
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				additiveLayers = s.SerializeObject<CListO<AdditiveLayer_Template<T>>>(additiveLayers, name: "additiveLayers");
			}
		}
		public override uint? ClassCRC => 0x91616057;
	}
}

