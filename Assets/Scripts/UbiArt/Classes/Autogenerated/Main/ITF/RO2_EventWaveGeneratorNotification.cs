using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventWaveGeneratorNotification : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF0129946;
	}
}

