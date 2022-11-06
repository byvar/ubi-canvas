using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_GroundAIControllerComponent : GroundAIControllerComponent {
		public bool canDrown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					canDrown = s.Serialize<bool>(canDrown, name: "canDrown");
				}
			}
		}
		public override uint? ClassCRC => 0x83646F14;
	}
}

