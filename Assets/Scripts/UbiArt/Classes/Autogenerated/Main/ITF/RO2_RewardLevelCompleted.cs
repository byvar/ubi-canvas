using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardLevelCompleted : RewardTrigger_Base {
		[Serialize("levelIds")] public Placeholder levelIds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(levelIds));
			} else {
			}
		}
		public override uint? ClassCRC => 0x3A3A42AD;
	}
}

