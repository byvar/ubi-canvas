using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventRegisterInCameraID : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x975AA596;
	}
}

