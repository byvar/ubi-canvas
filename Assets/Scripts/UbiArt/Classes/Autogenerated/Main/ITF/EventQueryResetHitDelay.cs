using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryResetHitDelay : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1B617670;
	}
}

