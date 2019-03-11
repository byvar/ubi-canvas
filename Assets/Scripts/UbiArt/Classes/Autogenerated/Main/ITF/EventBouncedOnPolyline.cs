using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventBouncedOnPolyline : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x54BB48C6;
	}
}

