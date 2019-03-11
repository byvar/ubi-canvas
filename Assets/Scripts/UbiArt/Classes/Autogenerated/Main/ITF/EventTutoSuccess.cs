using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTutoSuccess : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2713FD2E;
	}
}

