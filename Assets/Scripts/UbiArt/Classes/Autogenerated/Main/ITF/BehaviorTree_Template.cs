using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BehaviorTree_Template : CSerializable {
		public BTNodeTemplate_Ref root;
		public CArrayO<Generic<BTNode_Template>> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			root = s.SerializeObject<BTNodeTemplate_Ref>(root, name: "root");
			nodes = s.SerializeObject<CArrayO<Generic<BTNode_Template>>>(nodes, name: "nodes");
		}
	}
}

