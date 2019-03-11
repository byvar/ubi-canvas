using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventPause : Event {
		[Serialize("pause" )] public bool pause;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(pause));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(pause));
			} else {
				SerializeField(s, nameof(pause));
			}
		}
		public override uint? ClassCRC => 0x31779023;
	}
}

