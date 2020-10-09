using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTSequence_Template : BTNode_Template {
		public CListO<BTNodeTemplate_Ref> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<BTNodeTemplate_Ref>>(nodes, name: "nodes");
		}
		public override uint? ClassCRC => 0xAACC4387;
	}
}

