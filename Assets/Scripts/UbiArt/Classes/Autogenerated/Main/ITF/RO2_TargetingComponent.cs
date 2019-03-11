using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TargetingComponent : ActorComponent {
		[Serialize("targetOffset")] public float targetOffset;
		[Serialize("eventSender" )] public EventSender eventSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(targetOffset));
			SerializeField(s, nameof(eventSender));
		}
		public override uint? ClassCRC => 0xC376AAB9;
	}
}

