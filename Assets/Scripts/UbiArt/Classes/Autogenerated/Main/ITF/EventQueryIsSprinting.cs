using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryIsSprinting : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8AA9E5CF;
	}
}

