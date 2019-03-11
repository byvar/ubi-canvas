using UnityEngine;

namespace UbiArt.online {
	public partial class HttpHeadersUpdatedEvent : ITF.Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x93936BAB;
	}
}

