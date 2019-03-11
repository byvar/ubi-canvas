using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventFlip : Event {
		[Serialize("ForceDirection")] public EventFlip__eFlip ForceDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ForceDirection));
		}
		public enum EventFlip__eFlip {
			[Serialize("EventFlip::eFlip_Right"  )] Right = 0,
			[Serialize("EventFlip::eFlip_Left"   )] Left = 1,
			[Serialize("EventFlip::eFlip_Inverse")] Inverse = 2,
		}
		public override uint? ClassCRC => 0x602512A3;
	}
}

