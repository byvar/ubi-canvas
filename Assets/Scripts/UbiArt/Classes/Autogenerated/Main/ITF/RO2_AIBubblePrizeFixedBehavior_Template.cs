using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIBubblePrizeFixedBehavior_Template : TemplateAIBehavior {
		public RO2_BubblePrize_Template bubblePrize;
		public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubblePrize = s.SerializeObject<RO2_BubblePrize_Template>(bubblePrize, name: "bubblePrize");
			playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
		}
		public override uint? ClassCRC => 0x2F159996;
	}
}

