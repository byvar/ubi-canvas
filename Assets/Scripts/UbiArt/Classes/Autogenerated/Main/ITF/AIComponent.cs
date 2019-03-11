using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIComponent : ActorComponent {
		[Serialize("health")] public int health;
		[Serialize("health")] public bool health;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(health));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(health));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(health));
				}
			}
		}
		public override uint? ClassCRC => 0xB83B5C61;
	}
}

