using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTrigger : Event {
		[Serialize("activated")] public bool activated;
		[Serialize("activator")] public ObjectRef activator;
		[Serialize("toggle"   )] public bool toggle;
		[Serialize("sender"   )] public uint sender;
		[Serialize("activator")] public uint activator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator));
			} else {
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator));
				SerializeField(s, nameof(toggle));
			}
		}
		public override uint? ClassCRC => 0x500D33CE;
	}
}

