using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeTemplate<T> : CSerializable {
		public CList<Generic<BlendTreeNodeTemplate<T>>> nodes;
		public CList<BlendTreeTransition_Template<T>> nodeTransitions;
		public CList<AdditiveLayer_Template<T>> additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CList<Generic<BlendTreeNodeTemplate<T>>>>(nodes, name: "nodes");
			nodeTransitions = s.SerializeObject<CList<BlendTreeTransition_Template<T>>>(nodeTransitions, name: "nodeTransitions");
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				additiveLayers = s.SerializeObject<CList<AdditiveLayer_Template<T>>>(additiveLayers, name: "additiveLayers");
			}
		}
		public override uint? ClassCRC => 0x91616057;
	}
}

