using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class AngleRangeTriggerComponent : ActorComponent {
		[Serialize("minAngle"      )] public Angle minAngle;
		[Serialize("maxAngle"      )] public Angle maxAngle;
		[Serialize("hysteresis"    )] public Angle hysteresis;
		[Serialize("sendFirstEvent")] public SendFirstEvent sendFirstEvent;
		[Serialize("inEventSender" )] public EventSender inEventSender;
		[Serialize("outEventSender")] public EventSender outEventSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(minAngle));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(hysteresis));
				SerializeField(s, nameof(sendFirstEvent));
			}
			SerializeField(s, nameof(inEventSender));
			SerializeField(s, nameof(outEventSender));
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

