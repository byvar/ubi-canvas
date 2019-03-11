using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_RewardHasCostume : RewardTrigger_Base {
		[Serialize("costumeTags")] public Placeholder costumeTags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(costumeTags));
			} else {
			}
		}
		public override uint? ClassCRC => 0xCF38A4B2;
	}
}

