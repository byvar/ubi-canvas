using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventGhostOnNewPlayerRecorded : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA4EE7174;
	}
}

