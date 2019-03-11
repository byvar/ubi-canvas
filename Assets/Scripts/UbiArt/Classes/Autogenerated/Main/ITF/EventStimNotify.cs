using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventStimNotify : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4FBFDBF5;
	}
}

