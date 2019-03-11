using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventCameraIgnoreShake : Event {
		[Serialize("ignoreShake")] public bool ignoreShake;
		[Serialize("sender"     )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(ignoreShake));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(ignoreShake));
			} else {
				SerializeField(s, nameof(ignoreShake));
			}
		}
		public override uint? ClassCRC => 0x6D2CA7CB;
	}
}

