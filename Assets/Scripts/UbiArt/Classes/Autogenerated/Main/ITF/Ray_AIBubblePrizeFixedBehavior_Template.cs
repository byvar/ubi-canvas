using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIBubblePrizeFixedBehavior_Template : TemplateAIBehavior {
		public Ray_BubblePrize_Template bubblePrize;
		public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubblePrize = s.SerializeObject<Ray_BubblePrize_Template>(bubblePrize, name: "bubblePrize");
			playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
		}
		public override uint? ClassCRC => 0xF3C06F37;
	}
}

