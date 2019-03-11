using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventStickOnPolylineUpdate : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA10F7D85;
	}
}

