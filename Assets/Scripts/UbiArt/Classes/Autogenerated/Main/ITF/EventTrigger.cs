using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class EventTrigger : Event {
		public bool activated;
		public ObjectRef activator;
		public bool toggle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game != Settings.Game.RA && Settings.s.game != Settings.Game.RM) {
				activated = s.Serialize<bool>(activated, name: "activated");
				activator = (ObjectRef)s.Serialize<uint>(activator, name: "activator");
			} else {
				activated = s.Serialize<bool>(activated, name: "activated");
				activator = s.SerializeObject<ObjectRef>(activator, name: "activator");
				toggle = s.Serialize<bool>(toggle, name: "toggle");
			}
		}
		public override uint? ClassCRC => 0x500D33CE;
	}
}

