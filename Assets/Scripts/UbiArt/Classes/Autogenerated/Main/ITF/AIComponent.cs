using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class AIComponent : ActorComponent {
		[Serialize("health")] public int health;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
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

