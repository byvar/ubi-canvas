using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTTimer_Template : BTNode_Template {
		public BTNodeTemplate_Ref node;
		public float minTime;
		public float maxTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			node = s.SerializeObject<BTNodeTemplate_Ref>(node, name: "node");
			minTime = s.Serialize<float>(minTime, name: "minTime");
			maxTime = s.Serialize<float>(maxTime, name: "maxTime");
		}
		public override uint? ClassCRC => 0xE180188C;
	}
}

