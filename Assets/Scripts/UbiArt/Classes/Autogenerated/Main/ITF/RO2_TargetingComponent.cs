using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TargetingComponent : ActorComponent {
		public float targetOffset;
		public EventSender eventSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			targetOffset = s.Serialize<float>(targetOffset, name: "targetOffset");
			eventSender = s.SerializeObject<EventSender>(eventSender, name: "eventSender");
		}
		public override uint? ClassCRC => 0xC376AAB9;
	}
}

