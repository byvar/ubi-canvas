using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventSnap : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC64238C4;
	}
}

