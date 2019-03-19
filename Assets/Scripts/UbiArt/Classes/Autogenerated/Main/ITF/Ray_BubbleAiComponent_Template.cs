using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BubbleAiComponent_Template : Ray_AIComponent_Template {
		[Serialize("scaleSpeed"    )] public float scaleSpeed;
		[Serialize("fastScaleSpeed")] public float fastScaleSpeed;
		[Serialize("minScale"      )] public float minScale;
		[Serialize("maxScale"      )] public float maxScale;
		[Serialize("snapBone"      )] public StringID snapBone;
		[Serialize("ownerSnapBone" )] public StringID ownerSnapBone;
		[Serialize("bubbleBehavior")] public Generic<Ray_AIBubbleDeathBehavior_Template> bubbleBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scaleSpeed));
			SerializeField(s, nameof(fastScaleSpeed));
			SerializeField(s, nameof(minScale));
			SerializeField(s, nameof(maxScale));
			SerializeField(s, nameof(snapBone));
			SerializeField(s, nameof(ownerSnapBone));
			SerializeField(s, nameof(bubbleBehavior));
		}
		public override uint? ClassCRC => 0xC20F7E62;
	}
}

