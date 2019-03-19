using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionBubbleGranny_Template : RO2_BTActionBubble_Template {
		[Serialize("bubblizedFaction"        )] public uint bubblizedFaction;
		[Serialize("maxHeightFromGround"     )] public float maxHeightFromGround;
		[Serialize("explosionFeedBackFreqMax")] public float explosionFeedBackFreqMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubblizedFaction));
			SerializeField(s, nameof(maxHeightFromGround));
			SerializeField(s, nameof(explosionFeedBackFreqMax));
		}
		public override uint? ClassCRC => 0xBCED2B25;
	}
}

