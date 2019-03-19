using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTConcurrent_Template : BTNode_Template {
		[Serialize("failWithFirstNode")] public bool failWithFirstNode;
		[Serialize("nodes"            )] public CList<BTNodeTemplate_Ref> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(failWithFirstNode));
			SerializeField(s, nameof(nodes));
		}
		public override uint? ClassCRC => 0x9BBA7E9A;
	}
}

