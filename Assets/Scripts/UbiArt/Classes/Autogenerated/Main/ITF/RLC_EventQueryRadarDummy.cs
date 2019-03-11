using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_EventQueryRadarDummy : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x481EC87E;
	}
}

