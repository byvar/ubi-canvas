using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTSequence_Template : BTNode_Template {
		public CList<BTNodeTemplate_Ref> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CList<BTNodeTemplate_Ref>>(nodes, name: "nodes");
		}
		public override uint? ClassCRC => 0xAACC4387;
	}
}

