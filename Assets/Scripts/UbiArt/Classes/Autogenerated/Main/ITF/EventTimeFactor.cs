using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventTimeFactor : Event {
		[Serialize("ActorFactorValue")] public EventFlip__eFlip ActorFactorValue;
		[Serialize("WorldFactorValue")] public EventFlip__eFlip WorldFactorValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ActorFactorValue));
			SerializeField(s, nameof(WorldFactorValue));
		}
		public enum EventFlip__eFlip {
			[Serialize("EventFlip::eFlip_Right"  )] Right = 0,
			[Serialize("EventFlip::eFlip_Left"   )] Left = 1,
			[Serialize("EventFlip::eFlip_Inverse")] Inverse = 2,
		}
		public override uint? ClassCRC => 0xD876F486;
	}
}

