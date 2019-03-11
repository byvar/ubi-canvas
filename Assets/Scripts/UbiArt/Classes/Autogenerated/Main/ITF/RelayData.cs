using UnityEngine;

namespace UbiArt.ITF {
	public partial class RelayData : CSerializable {
		[Serialize("eventToListen"           )] public Generic<Event> eventToListen;
		[Serialize("eventToRelay"            )] public Generic<Event> eventToRelay;
		[Serialize("delay"                   )] public float delay;
		[Serialize("triggerSelf"             )] public bool triggerSelf;
		[Serialize("triggerChildren"         )] public bool triggerChildren;
		[Serialize("triggerBroadcast"        )] public bool triggerBroadcast;
		[Serialize("replaceSender"           )] public bool replaceSender;
		[Serialize("replaceSenderByActivator")] public bool replaceSenderByActivator;
		[Serialize("resetTimerOnRetrigger"   )] public bool resetTimerOnRetrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eventToListen));
			SerializeField(s, nameof(eventToRelay));
			SerializeField(s, nameof(delay));
			SerializeField(s, nameof(triggerSelf));
			SerializeField(s, nameof(triggerChildren));
			SerializeField(s, nameof(triggerBroadcast));
			SerializeField(s, nameof(replaceSender));
			SerializeField(s, nameof(replaceSenderByActivator));
			SerializeField(s, nameof(resetTimerOnRetrigger));
		}
		public override uint? ClassCRC => 0xE5F9BFFB;
	}
}

