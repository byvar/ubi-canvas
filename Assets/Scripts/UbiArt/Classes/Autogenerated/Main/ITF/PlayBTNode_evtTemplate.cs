using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PlayBTNode_evtTemplate : SequenceEventWithActor_Template {
		public string BTNodeName;
		public Generic<BTNode_Template> BTNode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			BTNodeName = s.Serialize<string>(BTNodeName, name: "BTNodeName");
			BTNode = s.SerializeObject<Generic<BTNode_Template>>(BTNode, name: "BTNode");
		}
		public override uint? ClassCRC => 0x91923660;
	}
}

