using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardLevelCompleted : RewardTrigger_Base {
		public CList<StringID> levelIds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			levelIds = s.SerializeObject<CList<StringID>>(levelIds, name: "levelIds");
		}
		public override uint? ClassCRC => 0x3A3A42AD;
	}
}

