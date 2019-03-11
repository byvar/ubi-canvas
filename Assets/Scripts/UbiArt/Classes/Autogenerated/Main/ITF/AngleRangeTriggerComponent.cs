using UnityEngine;

namespace UbiArt.ITF {
	public partial class AngleRangeTriggerComponent : ActorComponent {
		[Serialize("minAngle"      )] public Angle minAngle;
		[Serialize("maxAngle"      )] public Angle maxAngle;
		[Serialize("hysteresis"    )] public Angle hysteresis;
		[Serialize("sendFirstEvent")] public SendFirstEvent sendFirstEvent;
		[Serialize("inEventSender" )] public EventSender inEventSender;
		[Serialize("outEventSender")] public EventSender outEventSender;
		[Serialize("sendFirstEvent")] public Enum_sendFirstEvent sendFirstEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(minAngle));
					SerializeField(s, nameof(maxAngle));
					SerializeField(s, nameof(hysteresis));
					SerializeField(s, nameof(sendFirstEvent));
				}
				SerializeField(s, nameof(inEventSender));
				SerializeField(s, nameof(outEventSender));
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(minAngle));
					SerializeField(s, nameof(maxAngle));
					SerializeField(s, nameof(hysteresis));
					SerializeField(s, nameof(sendFirstEvent));
				}
				SerializeField(s, nameof(inEventSender));
				SerializeField(s, nameof(outEventSender));
			}
		}
		public enum SendFirstEvent {
			[Serialize("SendFirstEvent_IfInRange"   )] IfInRange = 0,
			[Serialize("SendFirstEvent_IfOutOfRange")] IfOutOfRange = 1,
			[Serialize("SendFirstEvent_Always"      )] Always = 2,
			[Serialize("SendFirstEvent_Never"       )] Never = 3,
		}
		public enum Enum_sendFirstEvent {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xF40F8690;
	}
}

