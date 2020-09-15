using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTree<T> : CSerializable {
		public CList<Generic<BlendTreeNode<T>>> nodes;
		public CList<BlendTreeTransition<T>> transitions;
		public CList<AdditiveLayer<T>> additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CList<Generic<BlendTreeNode<T>>>>(nodes, name: "nodes");
			transitions = s.SerializeObject<CList<BlendTreeTransition<T>>>(transitions, name: "transitions");
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				additiveLayers = s.SerializeObject<CList<AdditiveLayer<T>>>(additiveLayers, name: "additiveLayers");
			}
		}
		public override uint? ClassCRC => 0x3B47A4C6;
	}
}

