using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PlayBTNode_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("BTNodeName")] public string BTNodeName;
		[Serialize("BTNode"    )] public Generic<BTNode_Template> BTNode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(BTNodeName));
			SerializeField(s, nameof(BTNode));
		}
		public override uint? ClassCRC => 0x91923660;
	}
}

