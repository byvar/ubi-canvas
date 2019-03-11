using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventGhostTrigger : Event {
		[Serialize("recordType")] public uint recordType;
		[Serialize("sender"    )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(recordType));
			} else {
				SerializeField(s, nameof(recordType));
			}
		}
		public override uint? ClassCRC => 0x7130EB99;
	}
}

