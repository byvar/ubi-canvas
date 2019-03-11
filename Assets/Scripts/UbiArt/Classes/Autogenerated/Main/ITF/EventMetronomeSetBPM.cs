using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventMetronomeSetBPM : Event {
		[Serialize("sender")] public uint sender;
		[Serialize("bpm"   )] public uint bpm;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(bpm));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(bpm));
			} else {
			}
		}
		public override uint? ClassCRC => 0x444B5170;
	}
}

