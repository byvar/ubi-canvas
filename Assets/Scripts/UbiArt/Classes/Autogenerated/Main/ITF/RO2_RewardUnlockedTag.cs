using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardUnlockedTag : RewardTrigger_Base {
		[Serialize("tags")] public CList<StringID> tags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tags));
		}
		public override uint? ClassCRC => 0x8469F9C6;
	}
}

