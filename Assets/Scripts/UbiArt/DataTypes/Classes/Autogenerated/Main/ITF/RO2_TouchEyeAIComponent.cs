using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchEyeAIComponent : ActorComponent {
		public float touchedMinDuration;
		public bool triggered;
		public EventSender eventSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				touchedMinDuration = s.Serialize<float>(touchedMinDuration, name: "touchedMinDuration");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				triggered = s.Serialize<bool>(triggered, name: "triggered");
			}
			eventSender = s.SerializeObject<EventSender>(eventSender, name: "eventSender");
		}
		public override uint? ClassCRC => 0x6DB6CEA1;
	}
}

