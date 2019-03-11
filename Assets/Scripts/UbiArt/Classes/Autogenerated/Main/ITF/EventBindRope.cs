using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventBindRope : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1E1783B1;
	}
}

