using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardUnlockedTag : RewardTrigger_Base {
		public CList<StringID> tags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tags = s.SerializeObject<CList<StringID>>(tags, name: "tags");
		}
		public override uint? ClassCRC => 0x8469F9C6;
	}
}

