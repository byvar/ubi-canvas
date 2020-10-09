using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TouchHoldTriggerComponent : ActorComponent {
		public EventSender onHoldEvent;
		public EventSender onReleaseEvent;
		public float minTimeBeforeHoldEventSend;
		public bool useTapGauge;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					onHoldEvent = s.SerializeObject<EventSender>(onHoldEvent, name: "onHoldEvent");
					onReleaseEvent = s.SerializeObject<EventSender>(onReleaseEvent, name: "onReleaseEvent");
					useTapGauge = s.Serialize<bool>(useTapGauge, name: "useTapGauge", options: CSerializerObject.Options.ForceAsByte);
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					onHoldEvent = s.SerializeObject<EventSender>(onHoldEvent, name: "onHoldEvent");
					onReleaseEvent = s.SerializeObject<EventSender>(onReleaseEvent, name: "onReleaseEvent");
					useTapGauge = s.Serialize<bool>(useTapGauge, name: "useTapGauge", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					onHoldEvent = s.SerializeObject<EventSender>(onHoldEvent, name: "onHoldEvent");
					onReleaseEvent = s.SerializeObject<EventSender>(onReleaseEvent, name: "onReleaseEvent");
					minTimeBeforeHoldEventSend = s.Serialize<float>(minTimeBeforeHoldEventSend, name: "minTimeBeforeHoldEventSend");
				}
			}
		}
		public override uint? ClassCRC => 0xD18D6A31;
	}
}

