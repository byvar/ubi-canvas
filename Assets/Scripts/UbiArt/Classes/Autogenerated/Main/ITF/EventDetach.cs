using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDetach : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x35024520;
	}
}

