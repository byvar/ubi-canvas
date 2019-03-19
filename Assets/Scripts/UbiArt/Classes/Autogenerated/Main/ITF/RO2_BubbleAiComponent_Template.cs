using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BubbleAiComponent_Template : RO2_AIComponent_Template {
		[Serialize("scaleSpeed"     )] public float scaleSpeed;
		[Serialize("fastScaleSpeed" )] public float fastScaleSpeed;
		[Serialize("minScale"       )] public float minScale;
		[Serialize("maxScale"       )] public float maxScale;
		[Serialize("snapBone"       )] public StringID snapBone;
		[Serialize("ownerSnapBone"  )] public StringID ownerSnapBone;
		[Serialize("DRC_catchRadius")] public float DRC_catchRadius;
		[Serialize("DRC_forceCoeff" )] public float DRC_forceCoeff;
		[Serialize("faction"        )] public uint faction;
		[Serialize("bubbleBehavior" )] public Generic<RO2_AIBubbleDeathBehavior_Template> bubbleBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scaleSpeed));
			SerializeField(s, nameof(fastScaleSpeed));
			SerializeField(s, nameof(minScale));
			SerializeField(s, nameof(maxScale));
			SerializeField(s, nameof(snapBone));
			SerializeField(s, nameof(ownerSnapBone));
			SerializeField(s, nameof(DRC_catchRadius));
			SerializeField(s, nameof(DRC_forceCoeff));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(bubbleBehavior));
		}
		public override uint? ClassCRC => 0x0F730A08;
	}
}

