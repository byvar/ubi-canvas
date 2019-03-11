using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDRCInteract : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x78767F4E;
	}
}

