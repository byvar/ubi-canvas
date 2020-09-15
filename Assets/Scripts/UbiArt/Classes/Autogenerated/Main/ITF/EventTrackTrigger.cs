using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class EventTrackTrigger : Event {
		public int activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activated = s.Serialize<int>(activated, name: "activated");
		}
		public override uint? ClassCRC => 0x1396B411;
	}
}

