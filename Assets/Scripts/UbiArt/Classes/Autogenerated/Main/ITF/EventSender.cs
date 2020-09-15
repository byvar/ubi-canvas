using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventSender : CSerializable {
		public Generic<Event> _event;
		public bool triggerOnce;
		public bool triggerSelf;
		public bool triggerChildren;
		public bool discardChildrenWithTag;
		public bool triggerActivator;
		public bool triggerBroadcast;

		public bool discardChildrenWithTags;
		public StringID sendOnlyToChildrenWithThisTag;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					_event = s.SerializeObject<Generic<Event>>(_event, name: "_event");
					triggerOnce = s.Serialize<bool>(triggerOnce, name: "triggerOnce", options: CSerializerObject.Options.BoolAsByte);
					triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf", options: CSerializerObject.Options.BoolAsByte);
					triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren", options: CSerializerObject.Options.BoolAsByte);
					triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator", options: CSerializerObject.Options.BoolAsByte);
					triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast", options: CSerializerObject.Options.BoolAsByte);
					discardChildrenWithTags = s.Serialize<bool>(discardChildrenWithTags, name: "discardChildrenWithTags", options: CSerializerObject.Options.BoolAsByte);
					sendOnlyToChildrenWithThisTag = s.SerializeObject<StringID>(sendOnlyToChildrenWithThisTag, name: "sendOnlyToChildrenWithThisTag");
				}
			} else if(Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					_event = s.SerializeObject<Generic<Event>>(_event, name: "_event");
					triggerOnce = s.Serialize<bool>(triggerOnce, name: "triggerOnce", options: CSerializerObject.Options.BoolAsByte);
					triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf", options: CSerializerObject.Options.BoolAsByte);
					triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren", options: CSerializerObject.Options.BoolAsByte);
					triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator", options: CSerializerObject.Options.BoolAsByte);
					triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					_event = s.SerializeObject<Generic<Event>>(_event, name: "_event");
					triggerOnce = s.Serialize<bool>(triggerOnce, name: "triggerOnce");
					triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
					triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
					discardChildrenWithTag = s.Serialize<bool>(discardChildrenWithTag, name: "discardChildrenWithTag");
					triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator");
					triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
				}
			}
		}
	}
}

