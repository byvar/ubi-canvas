using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTConcurrent_Template : BTNode_Template {
		public bool failWithFirstNode;
		public CListO<BTNodeTemplate_Ref> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			failWithFirstNode = s.Serialize<bool>(failWithFirstNode, name: "failWithFirstNode");
			nodes = s.SerializeObject<CListO<BTNodeTemplate_Ref>>(nodes, name: "nodes");
		}
		public override uint? ClassCRC => 0x9BBA7E9A;
	}
}

