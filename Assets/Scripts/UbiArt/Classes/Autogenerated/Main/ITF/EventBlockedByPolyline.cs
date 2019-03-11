using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventBlockedByPolyline : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAFD90A60;
	}
}

