using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryAnchorTransform : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDC37F253;
	}
}

