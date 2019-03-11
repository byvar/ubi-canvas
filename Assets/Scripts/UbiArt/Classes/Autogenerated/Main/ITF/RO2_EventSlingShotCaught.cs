using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventSlingShotCaught : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB1D11F17;
	}
}

