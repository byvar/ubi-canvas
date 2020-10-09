using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AISendEventAction_Template : AIAction_Template {
		public Generic<Event> eventToSend;
		public bool triggerSelf;
		public bool triggerChildren;
		public bool triggerBinded;
		public bool broadcast;
		public StringID virtualChild;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eventToSend = s.SerializeObject<Generic<Event>>(eventToSend, name: "eventToSend");
			triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
			triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
			triggerBinded = s.Serialize<bool>(triggerBinded, name: "triggerBinded");
			broadcast = s.Serialize<bool>(broadcast, name: "broadcast");
			virtualChild = s.SerializeObject<StringID>(virtualChild, name: "virtualChild");
		}
		public override uint? ClassCRC => 0xF053FC8A;
	}
}

