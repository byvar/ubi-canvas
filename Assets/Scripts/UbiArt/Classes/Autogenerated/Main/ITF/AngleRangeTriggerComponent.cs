using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class AngleRangeTriggerComponent : ActorComponent {
		public Angle minAngle;
		public Angle maxAngle;
		public Angle hysteresis;
		public SendFirstEvent sendFirstEvent;
		public EventSender inEventSender;
		public EventSender outEventSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
				maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
				hysteresis = s.SerializeObject<Angle>(hysteresis, name: "hysteresis");
				sendFirstEvent = s.Serialize<SendFirstEvent>(sendFirstEvent, name: "sendFirstEvent");
			}
			inEventSender = s.SerializeObject<EventSender>(inEventSender, name: "inEventSender");
			outEventSender = s.SerializeObject<EventSender>(outEventSender, name: "outEventSender");
		}
		public enum SendFirstEvent {
			[Serialize("SendFirstEvent_IfInRange"   )] IfInRange = 0,
			[Serialize("SendFirstEvent_IfOutOfRange")] IfOutOfRange = 1,
			[Serialize("SendFirstEvent_Always"      )] Always = 2,
			[Serialize("SendFirstEvent_Never"       )] Never = 3,
		}
		public override uint? ClassCRC => 0xF40F8690;
	}
}

