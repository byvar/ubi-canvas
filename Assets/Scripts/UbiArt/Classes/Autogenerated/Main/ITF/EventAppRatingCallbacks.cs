using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventAppRatingCallbacks : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDE06493D;
	}
}

