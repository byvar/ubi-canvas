using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIBubblePrizeFixedBehavior_Template : TemplateAIBehavior {
		[Serialize("bubblePrize"                    )] public RO2_BubblePrize_Template bubblePrize;
		[Serialize("playerDetectorMultiplierInWater")] public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubblePrize));
			SerializeField(s, nameof(playerDetectorMultiplierInWater));
		}
		public override uint? ClassCRC => 0x2F159996;
	}
}

