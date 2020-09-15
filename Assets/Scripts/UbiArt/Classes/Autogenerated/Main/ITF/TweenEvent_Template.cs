using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenEvent_Template : TweenInstruction_Template {
		public Generic<Event> _event;
		public bool triggerSelf;
		public bool triggerChildren;
		public bool triggerBoundChildren;
		public bool triggerGameManager;
		public bool triggerBroadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			_event = s.SerializeObject<Generic<Event>>(_event, name: "_event");
			triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
			triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
			triggerBoundChildren = s.Serialize<bool>(triggerBoundChildren, name: "triggerBoundChildren");
			triggerGameManager = s.Serialize<bool>(triggerGameManager, name: "triggerGameManager");
			triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
		}
		public override uint? ClassCRC => 0xA6179C86;
	}
}

