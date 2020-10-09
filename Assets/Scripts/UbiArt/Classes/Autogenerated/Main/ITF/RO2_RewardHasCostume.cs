using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RewardHasCostume : RewardTrigger_Base {
		public Placeholder costumeTags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				costumeTags = s.SerializeObject<Placeholder>(costumeTags, name: "costumeTags");
			} else {
			}
		}
		public override uint? ClassCRC => 0xCF38A4B2;
	}
}

