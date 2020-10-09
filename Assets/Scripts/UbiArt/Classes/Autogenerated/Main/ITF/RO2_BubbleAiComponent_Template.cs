using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BubbleAiComponent_Template : RO2_AIComponent_Template {
		public float scaleSpeed;
		public float fastScaleSpeed;
		public float minScale;
		public float maxScale;
		public StringID snapBone;
		public StringID ownerSnapBone;
		public float DRC_catchRadius;
		public float DRC_forceCoeff;
		public uint faction2;
		public Generic<RO2_AIBubbleDeathBehavior_Template> bubbleBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scaleSpeed = s.Serialize<float>(scaleSpeed, name: "scaleSpeed");
			fastScaleSpeed = s.Serialize<float>(fastScaleSpeed, name: "fastScaleSpeed");
			minScale = s.Serialize<float>(minScale, name: "minScale");
			maxScale = s.Serialize<float>(maxScale, name: "maxScale");
			snapBone = s.SerializeObject<StringID>(snapBone, name: "snapBone");
			ownerSnapBone = s.SerializeObject<StringID>(ownerSnapBone, name: "ownerSnapBone");
			DRC_catchRadius = s.Serialize<float>(DRC_catchRadius, name: "DRC_catchRadius");
			DRC_forceCoeff = s.Serialize<float>(DRC_forceCoeff, name: "DRC_forceCoeff");
			faction2 = s.Serialize<uint>(faction2, name: "faction");
			bubbleBehavior = s.SerializeObject<Generic<RO2_AIBubbleDeathBehavior_Template>>(bubbleBehavior, name: "bubbleBehavior");
		}
		public override uint? ClassCRC => 0x0F730A08;
	}
}

