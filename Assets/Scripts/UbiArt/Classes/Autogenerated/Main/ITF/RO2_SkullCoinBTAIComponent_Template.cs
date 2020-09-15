using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SkullCoinBTAIComponent_Template : BTAIComponent_Template {
		public uint rewardAmount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rewardAmount = s.Serialize<uint>(rewardAmount, name: "rewardAmount");
		}
		public override uint? ClassCRC => 0xDB7D11DD;
	}
}

