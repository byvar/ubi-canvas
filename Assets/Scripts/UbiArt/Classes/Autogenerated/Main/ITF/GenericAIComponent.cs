using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class GenericAIComponent : AIComponent {
		[Serialize("health")] public int health;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(health));
				}
			} else {
			}
		}
		public override uint? ClassCRC => 0xC3AE459E;
	}
}

