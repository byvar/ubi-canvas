using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSequenceEnableTrack : Event {
		[Serialize("trackName")] public string trackName;
		[Serialize("enable"   )] public bool enable;
		[Serialize("sender"   )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(trackName));
				SerializeField(s, nameof(enable));
			} else {
				SerializeField(s, nameof(trackName));
				SerializeField(s, nameof(enable));
			}
		}
		public override uint? ClassCRC => 0x2B3A08F9;
	}
}

