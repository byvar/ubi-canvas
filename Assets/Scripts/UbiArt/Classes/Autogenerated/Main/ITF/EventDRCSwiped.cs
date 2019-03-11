using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDRCSwiped : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7D11F7AB;
	}
}

