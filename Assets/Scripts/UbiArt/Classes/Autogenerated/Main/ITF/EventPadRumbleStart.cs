using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventPadRumbleStart : Event {
		[Serialize("name"  )] public StringID name;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(name));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(name));
			} else {
				SerializeField(s, nameof(name));
			}
		}
		public override uint? ClassCRC => 0xAB107D88;
	}
}

