using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_RewardUnlockedTag : RewardTrigger_Base {
		[Serialize("tags")] public Placeholder tags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(tags));
			} else {
			}
		}
		public override uint? ClassCRC => 0x8469F9C6;
	}
}

