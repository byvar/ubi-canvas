using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventSetInitialNode : Event {
		[Serialize("getNodeFromSender"   )] public int getNodeFromSender;
		[Serialize("interruptCurrentNode")] public int interruptCurrentNode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(getNodeFromSender));
			SerializeField(s, nameof(interruptCurrentNode));
		}
		public override uint? ClassCRC => 0xCEA19929;
	}
}

