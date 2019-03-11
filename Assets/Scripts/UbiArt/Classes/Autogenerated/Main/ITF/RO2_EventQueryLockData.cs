using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventQueryLockData : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x35BA1701;
	}
}

