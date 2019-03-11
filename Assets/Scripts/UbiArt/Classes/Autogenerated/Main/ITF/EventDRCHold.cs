using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDRCHold : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x09C7E801;
	}
}

