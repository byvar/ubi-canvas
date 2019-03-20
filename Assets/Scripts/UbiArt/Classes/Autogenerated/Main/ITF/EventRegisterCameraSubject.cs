using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventRegisterCameraSubject : Event {
		[Serialize("actionActivator")] public ACTION actionActivator;
		[Serialize("actionChildren" )] public ACTION actionChildren;
		[Serialize("delay"          )] public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actionActivator));
			SerializeField(s, nameof(actionChildren));
			SerializeField(s, nameof(delay));
		}
		public enum ACTION {
			[Serialize("ACTION_NONE"      )] NONE = 0,
			[Serialize("ACTION_REGISTER"  )] REGISTER = 1,
			[Serialize("ACTION_UNREGISTER")] UNREGISTER = 2,
		}
		public override uint? ClassCRC => 0x645157D0;
	}
}

