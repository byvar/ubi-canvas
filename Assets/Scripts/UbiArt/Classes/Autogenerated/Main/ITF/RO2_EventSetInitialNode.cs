using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventSetInitialNode : Event {
		[Serialize("getNodeFromSender"   )] public bool getNodeFromSender;
		[Serialize("interruptCurrentNode")] public bool interruptCurrentNode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(getNodeFromSender));
			SerializeField(s, nameof(interruptCurrentNode));
		}
		public override uint? ClassCRC => 0xCF4913AC;
	}
}

