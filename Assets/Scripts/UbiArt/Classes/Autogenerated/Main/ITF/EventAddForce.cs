using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventAddForce : Event {
		[Serialize("force" )] public Vector2 force;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(force));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(force));
			} else {
				SerializeField(s, nameof(force));
			}
		}
		public override uint? ClassCRC => 0x67329674;
	}
}

