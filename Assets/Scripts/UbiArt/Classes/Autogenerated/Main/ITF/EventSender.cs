using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventSender : CSerializable {
		[Serialize("event"                 )] public Generic<Event> _event;
		[Serialize("triggerOnce"           )] public bool triggerOnce;
		[Serialize("triggerSelf"           )] public bool triggerSelf;
		[Serialize("triggerChildren"       )] public bool triggerChildren;
		[Serialize("discardChildrenWithTag")] public bool discardChildrenWithTag;
		[Serialize("triggerActivator"      )] public bool triggerActivator;
		[Serialize("triggerBroadcast"      )] public bool triggerBroadcast;

		[Serialize("discardChildrenWithTags"      )] public bool discardChildrenWithTags;
		[Serialize("sendOnlyToChildrenWithThisTag")] public StringID sendOnlyToChildrenWithThisTag;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(_event));
					SerializeField(s, nameof(triggerOnce), boolAsByte: true);
					SerializeField(s, nameof(triggerSelf), boolAsByte: true);
					SerializeField(s, nameof(triggerChildren), boolAsByte: true);
					SerializeField(s, nameof(triggerActivator), boolAsByte: true);
					SerializeField(s, nameof(triggerBroadcast), boolAsByte: true);
					SerializeField(s, nameof(discardChildrenWithTags), boolAsByte: true);
					SerializeField(s, nameof(sendOnlyToChildrenWithThisTag));
				}
			} else if(Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(_event));
					SerializeField(s, nameof(triggerOnce), boolAsByte: true);
					SerializeField(s, nameof(triggerSelf), boolAsByte: true);
					SerializeField(s, nameof(triggerChildren), boolAsByte: true);
					SerializeField(s, nameof(triggerActivator), boolAsByte: true);
					SerializeField(s, nameof(triggerBroadcast), boolAsByte: true);
				}
			} else {
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
}

