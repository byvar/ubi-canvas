using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractComponent_Template : CSerializable {
		public Placeholder onInteractEvent;
		public Placeholder onEndInteractEvent;
		public int triggerSelf;
		public int triggerChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onInteractEvent = s.SerializeObject<Placeholder>(onInteractEvent, name: "onInteractEvent");
			onEndInteractEvent = s.SerializeObject<Placeholder>(onEndInteractEvent, name: "onEndInteractEvent");
			triggerSelf = s.Serialize<int>(triggerSelf, name: "triggerSelf");
			triggerChildren = s.Serialize<int>(triggerChildren, name: "triggerChildren");
		}
		public override uint? ClassCRC => 0x9A0DE502;
	}
}

