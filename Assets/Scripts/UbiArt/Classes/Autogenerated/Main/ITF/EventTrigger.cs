using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventTrigger : Event {
		public bool activated;
		public ObjectRef activator;
		public bool toggle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game != Settings.Game.RA) {
				activated = s.Serialize<bool>(activated, name: "activated");
				activator = (ObjectRef)s.Serialize<uint>((uint)activator, name: "activator");
			} else {
				activated = s.Serialize<bool>(activated, name: "activated");
				activator = s.SerializeObject<ObjectRef>(activator, name: "activator");
				toggle = s.Serialize<bool>(toggle, name: "toggle");
			}
		}
		public override uint? ClassCRC => 0x500D33CE;
	}
}

