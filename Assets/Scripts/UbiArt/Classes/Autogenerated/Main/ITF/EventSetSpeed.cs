using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSetSpeed : Event {
		[Serialize("speed" )] public Vector2 speed;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(speed));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(speed));
			} else {
				SerializeField(s, nameof(speed));
			}
		}
		public override uint? ClassCRC => 0xAE569AD3;
	}
}

