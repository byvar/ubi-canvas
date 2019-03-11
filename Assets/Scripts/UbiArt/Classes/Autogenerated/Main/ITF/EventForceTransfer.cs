using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventForceTransfer : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3E3741B3;
	}
}

