using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventSetInitialNode : Event {
		public bool getNodeFromSender;
		public bool interruptCurrentNode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			getNodeFromSender = s.Serialize<bool>(getNodeFromSender, name: "getNodeFromSender");
			interruptCurrentNode = s.Serialize<bool>(interruptCurrentNode, name: "interruptCurrentNode");
		}
		public override uint? ClassCRC => 0xCF4913AC;
	}
}

