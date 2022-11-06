using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTree<T> : CSerializable {
		public CListO<Generic<BlendTreeNode<T>>> nodes;
		public CListO<BlendTreeTransition<T>> transitions;
		public CListO<AdditiveLayer<T>> additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<Generic<BlendTreeNode<T>>>>(nodes, name: "nodes");
			transitions = s.SerializeObject<CListO<BlendTreeTransition<T>>>(transitions, name: "transitions");
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				additiveLayers = s.SerializeObject<CListO<AdditiveLayer<T>>>(additiveLayers, name: "additiveLayers");
			}
		}
		public override uint? ClassCRC => 0x3B47A4C6;
	}
}

