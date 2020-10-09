using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class MultiTargetEvent : CSerializable {
		public bool triggerOnce;
		public bool triggerSelf;
		public bool triggerActivator;
		public bool triggerBroadcast;
		public bool triggerParent;
		public bool triggerChildren;
		public CListO<ChildrenTagParam> childrenTagList;
		public bool triggerBoundParent;
		public bool triggerBoundChildren;
		public Mode modeAfterCP;
		public bool triggerOnceDone;
		public CListO<Event> Events;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			triggerOnce = s.Serialize<bool>(triggerOnce, name: "triggerOnce");
			triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
			triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator");
			triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
			triggerParent = s.Serialize<bool>(triggerParent, name: "triggerParent");
			triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
			childrenTagList = s.SerializeObject<CListO<ChildrenTagParam>>(childrenTagList, name: "childrenTagList");
			triggerBoundParent = s.Serialize<bool>(triggerBoundParent, name: "triggerBoundParent");
			triggerBoundChildren = s.Serialize<bool>(triggerBoundChildren, name: "triggerBoundChildren");
			modeAfterCP = s.Serialize<Mode>(modeAfterCP, name: "modeAfterCP");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				triggerOnceDone = s.Serialize<bool>(triggerOnceDone, name: "triggerOnceDone");
			}
			Events = s.SerializeObject<CListO<Event>>(Events, name: "Events");
		}
		public enum Mode {
			[Serialize("Mode_None"            )] None = 0,
			[Serialize("Mode_RetriggerAfterCP")] RetriggerAfterCP = 1,
			[Serialize("Mode_ResetAfterCP"    )] ResetAfterCP = 2,
		}
		public override uint? ClassCRC => 0x0F7E24E6;
	}
}

