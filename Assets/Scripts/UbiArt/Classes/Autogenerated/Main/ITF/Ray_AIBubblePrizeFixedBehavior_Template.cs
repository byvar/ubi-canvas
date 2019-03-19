using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIBubblePrizeFixedBehavior_Template : TemplateAIBehavior {
		[Serialize("bubblePrize"                    )] public Ray_BubblePrize_Template bubblePrize;
		[Serialize("playerDetectorMultiplierInWater")] public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubblePrize));
			SerializeField(s, nameof(playerDetectorMultiplierInWater));
		}
		public override uint? ClassCRC => 0xF3C06F37;
	}
}

