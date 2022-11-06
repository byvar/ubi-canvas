using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RewardLevelCompleted : RewardTrigger_Base {
		public CListO<StringID> levelIds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			levelIds = s.SerializeObject<CListO<StringID>>(levelIds, name: "levelIds");
		}
		public override uint? ClassCRC => 0x3A3A42AD;
	}
}

