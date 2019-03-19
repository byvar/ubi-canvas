using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SkullCoinBTAIComponent_Template : BTAIComponent_Template {
		[Serialize("rewardAmount")] public uint rewardAmount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rewardAmount));
		}
		public override uint? ClassCRC => 0xDB7D11DD;
	}
}

