using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BubbleAiComponent_Template : Ray_AIComponent_Template {
		public float scaleSpeed;
		public float fastScaleSpeed;
		public float minScale;
		public float maxScale;
		public StringID snapBone;
		public StringID ownerSnapBone;
		public Generic<Ray_AIBubbleDeathBehavior_Template> bubbleBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scaleSpeed = s.Serialize<float>(scaleSpeed, name: "scaleSpeed");
			fastScaleSpeed = s.Serialize<float>(fastScaleSpeed, name: "fastScaleSpeed");
			minScale = s.Serialize<float>(minScale, name: "minScale");
			maxScale = s.Serialize<float>(maxScale, name: "maxScale");
			snapBone = s.SerializeObject<StringID>(snapBone, name: "snapBone");
			ownerSnapBone = s.SerializeObject<StringID>(ownerSnapBone, name: "ownerSnapBone");
			bubbleBehavior = s.SerializeObject<Generic<Ray_AIBubbleDeathBehavior_Template>>(bubbleBehavior, name: "bubbleBehavior");
		}
		public override uint? ClassCRC => 0xC20F7E62;
	}
}

