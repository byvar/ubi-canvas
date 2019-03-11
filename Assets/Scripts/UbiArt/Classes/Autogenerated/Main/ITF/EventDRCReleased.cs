using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDRCReleased : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x768DA48A;
	}
}

