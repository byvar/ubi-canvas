using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSetBusVolume : Event {
		[Serialize("sender")] public uint sender;
		[Serialize("volume")] public Volume volume;
		[Serialize("time"  )] public float time;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(time));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(time));
			} else {
			}
		}
		public override uint? ClassCRC => 0x6241355A;
	}
}

