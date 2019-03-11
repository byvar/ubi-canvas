using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventInstantKill : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x51230E82;
	}
}

