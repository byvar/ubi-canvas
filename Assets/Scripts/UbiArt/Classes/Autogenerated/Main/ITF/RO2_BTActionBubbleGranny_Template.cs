using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionBubbleGranny_Template : RO2_BTActionBubble_Template {
		public uint bubblizedFaction;
		public float maxHeightFromGround;
		public float explosionFeedBackFreqMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubblizedFaction = s.Serialize<uint>(bubblizedFaction, name: "bubblizedFaction");
			maxHeightFromGround = s.Serialize<float>(maxHeightFromGround, name: "maxHeightFromGround");
			explosionFeedBackFreqMax = s.Serialize<float>(explosionFeedBackFreqMax, name: "explosionFeedBackFreqMax");
		}
		public override uint? ClassCRC => 0xBCED2B25;
	}
}

