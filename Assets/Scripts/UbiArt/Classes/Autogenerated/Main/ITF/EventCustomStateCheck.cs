using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventCustomStateCheck : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDEAA60F6;
	}
}

