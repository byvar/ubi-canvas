using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TouchEyeAIComponent : ActorComponent {
		[Serialize("touchedMinDuration")] public float touchedMinDuration;
		[Serialize("triggered"         )] public bool triggered;
		[Serialize("eventSender"       )] public EventSender eventSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(touchedMinDuration));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(triggered));
			}
			SerializeField(s, nameof(eventSender));
		}
		public override uint? ClassCRC => 0x6DB6CEA1;
	}
}

