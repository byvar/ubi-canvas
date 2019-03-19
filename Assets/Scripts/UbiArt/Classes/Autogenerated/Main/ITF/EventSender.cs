using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventSender : CSerializable {
		[Serialize("event"                 )] public Generic<Event> _event;
		[Serialize("triggerOnce"           )] public bool triggerOnce;
		[Serialize("triggerSelf"           )] public bool triggerSelf;
		[Serialize("triggerChildren"       )] public bool triggerChildren;
		[Serialize("discardChildrenWithTag")] public bool discardChildrenWithTag;
		[Serialize("triggerActivator"      )] public bool triggerActivator;
		[Serialize("triggerBroadcast"      )] public bool triggerBroadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(_event));
				SerializeField(s, nameof(triggerOnce));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(discardChildrenWithTag));
				SerializeField(s, nameof(triggerActivator));
				SerializeField(s, nameof(triggerBroadcast));
			}
		}
	}
}

