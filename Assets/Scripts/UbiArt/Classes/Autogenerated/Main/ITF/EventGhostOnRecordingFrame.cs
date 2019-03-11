using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventGhostOnRecordingFrame : Event {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
			} else {
			}
		}
		public override uint? ClassCRC => 0x43F34BD9;
	}
}

