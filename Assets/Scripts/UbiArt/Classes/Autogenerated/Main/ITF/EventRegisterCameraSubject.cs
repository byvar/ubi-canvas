using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventRegisterCameraSubject : Event {
		[Serialize("actionActivator")] public ACTION actionActivator;
		[Serialize("actionChildren" )] public ACTION actionChildren;
		[Serialize("delay"          )] public float delay;
		[Serialize("sender"         )] public uint sender;
		[Serialize("actionActivator")] public Enum_actionActivator actionActivator;
		[Serialize("actionChildren" )] public Enum_actionChildren actionChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(actionActivator));
				SerializeField(s, nameof(actionChildren));
				SerializeField(s, nameof(delay));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(actionActivator));
				SerializeField(s, nameof(actionChildren));
				SerializeField(s, nameof(delay));
			} else {
				SerializeField(s, nameof(actionActivator));
				SerializeField(s, nameof(actionChildren));
				SerializeField(s, nameof(delay));
			}
		}
		public enum ACTION {
			[Serialize("ACTION_NONE"      )] NONE = 0,
			[Serialize("ACTION_REGISTER"  )] REGISTER = 1,
			[Serialize("ACTION_UNREGISTER")] UNREGISTER = 2,
		}
		public enum ACTION {
			[Serialize("ACTION_NONE"      )] NONE = 0,
			[Serialize("ACTION_REGISTER"  )] REGISTER = 1,
			[Serialize("ACTION_UNREGISTER")] UNREGISTER = 2,
		}
		public enum Enum_actionActivator {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x645157D0;
	}
}

