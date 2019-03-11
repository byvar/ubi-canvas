using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventPlayMovie : Event {
		[Serialize("play"  )] public bool play;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(play));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(play));
			} else {
				SerializeField(s, nameof(play));
			}
		}
		public override uint? ClassCRC => 0x2F8DA1FF;
	}
}

