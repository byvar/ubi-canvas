using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDRCSwipeEnd : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8D706337;
	}
}

