using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventRegisterCameraSubject : Event {
		public ACTION actionActivator;
		public ACTION actionChildren;
		public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actionActivator = s.Serialize<ACTION>(actionActivator, name: "actionActivator");
			actionChildren = s.Serialize<ACTION>(actionChildren, name: "actionChildren");
			delay = s.Serialize<float>(delay, name: "delay");
		}
		public enum ACTION {
			[Serialize("ACTION_NONE"      )] NONE = 0,
			[Serialize("ACTION_REGISTER"  )] REGISTER = 1,
			[Serialize("ACTION_UNREGISTER")] UNREGISTER = 2,
		}
		public override uint? ClassCRC => 0x645157D0;
	}
}

