using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIBubblePrizeFixedBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("bubblePrize"                    )] public Placeholder bubblePrize;
		[Serialize("playerDetectorMultiplierInWater")] public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubblePrize));
			SerializeField(s, nameof(playerDetectorMultiplierInWater));
		}
		public override uint? ClassCRC => 0xF3C06F37;
	}
}

