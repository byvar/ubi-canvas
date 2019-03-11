using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDRCTapped : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBB136E71;
	}
}

