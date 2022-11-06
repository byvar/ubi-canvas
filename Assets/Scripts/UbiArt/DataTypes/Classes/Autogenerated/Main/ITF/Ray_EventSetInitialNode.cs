using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventSetInitialNode : Event {
		public int getNodeFromSender;
		public int interruptCurrentNode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			getNodeFromSender = s.Serialize<int>(getNodeFromSender, name: "getNodeFromSender");
			interruptCurrentNode = s.Serialize<int>(interruptCurrentNode, name: "interruptCurrentNode");
		}
		public override uint? ClassCRC => 0xCEA19929;
	}
}

