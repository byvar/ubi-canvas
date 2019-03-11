using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSequenceActorActivate : Event {
		[Serialize("activate")] public bool activate;
		[Serialize("sender"  )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activate));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activate));
			} else {
				SerializeField(s, nameof(activate));
			}
		}
		public override uint? ClassCRC => 0x42BB4EF3;
	}
}

