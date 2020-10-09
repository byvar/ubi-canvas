using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RewardUnlockedTag : RewardTrigger_Base {
		public CListO<StringID> tags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tags = s.SerializeObject<CListO<StringID>>(tags, name: "tags");
		}
		public override uint? ClassCRC => 0x8469F9C6;
	}
}

