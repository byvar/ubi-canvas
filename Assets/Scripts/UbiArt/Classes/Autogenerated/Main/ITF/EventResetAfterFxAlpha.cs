using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventResetAfterFxAlpha : Event {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
			} else {
			}
		}
		public override uint? ClassCRC => 0x72A2AA9D;
	}
}

