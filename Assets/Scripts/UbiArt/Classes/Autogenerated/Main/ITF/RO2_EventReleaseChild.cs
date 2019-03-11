using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventReleaseChild : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCBEF8B19;
	}
}

