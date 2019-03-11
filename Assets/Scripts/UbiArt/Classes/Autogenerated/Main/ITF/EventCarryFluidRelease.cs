using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventCarryFluidRelease : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD254D004;
	}
}

