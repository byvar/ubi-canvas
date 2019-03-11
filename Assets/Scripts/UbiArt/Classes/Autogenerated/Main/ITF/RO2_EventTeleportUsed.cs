using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventTeleportUsed : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x61037D47;
	}
}

