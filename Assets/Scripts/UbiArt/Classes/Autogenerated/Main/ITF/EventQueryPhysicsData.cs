using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryPhysicsData : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x96BB69AA;
	}
}

