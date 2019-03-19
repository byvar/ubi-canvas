using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GroundAIControllerComponent : GroundAIControllerComponent {
		[Serialize("canDrown")] public bool canDrown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(canDrown));
				}
			}
		}
		public override uint? ClassCRC => 0x83646F14;
	}
}

