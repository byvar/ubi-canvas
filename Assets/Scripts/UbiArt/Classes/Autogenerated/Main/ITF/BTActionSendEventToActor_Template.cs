using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTActionSendEventToActor_Template : BTAction_Template {
		public StringID target;
		public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			target = s.SerializeObject<StringID>(target, name: "target");
			_event = s.SerializeObject<Generic<Event>>(_event, name: "event");
		}
		public override uint? ClassCRC => 0xF5050E97;
	}
}

