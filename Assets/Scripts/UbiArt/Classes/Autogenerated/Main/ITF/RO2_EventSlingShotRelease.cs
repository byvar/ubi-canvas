using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventSlingShotRelease : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x31B3591C;
	}
}

