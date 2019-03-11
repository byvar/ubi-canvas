using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventEnableShadow : Event {
		[Serialize("Enable")] public bool Enable;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
			} else {
				SerializeField(s, nameof(Enable));
			}
		}
		public override uint? ClassCRC => 0xF1CB5691;
	}
}

