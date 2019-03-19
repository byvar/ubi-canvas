using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class EventTrackTrigger : Event {
		[Serialize("activated")] public int activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activated));
		}
		public override uint? ClassCRC => 0x1396B411;
	}
}

