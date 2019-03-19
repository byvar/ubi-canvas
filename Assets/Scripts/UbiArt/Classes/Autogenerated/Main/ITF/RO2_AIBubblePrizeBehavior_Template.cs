using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIBubblePrizeBehavior_Template : TemplateAIBehavior {
		[Serialize("isCustomCurve"                  )] public bool isCustomCurve;
		[Serialize("bubblePrize"                    )] public RO2_BubblePrize_Template bubblePrize;
		[Serialize("bezierStretchStart"             )] public float bezierStretchStart;
		[Serialize("bezierStretchEnd"               )] public float bezierStretchEnd;
		[Serialize("bezierAction"                   )] public Generic<AIBezierAction_Template> bezierAction;
		[Serialize("blowOffAction"                  )] public Generic<RO2_AIBlowOffAction_Template> blowOffAction;
		[Serialize("followCurveAction"              )] public Generic<RO2_AIFollowBezierCurveAction_Template> followCurveAction;
		[Serialize("flyIdleAction"                  )] public Generic<RO2_AIFlyIdleAction_Template> flyIdleAction;
		[Serialize("playerDetectorMultiplierInWater")] public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isCustomCurve));
			SerializeField(s, nameof(bubblePrize));
			SerializeField(s, nameof(bezierStretchStart));
			SerializeField(s, nameof(bezierStretchEnd));
			SerializeField(s, nameof(bezierAction));
			SerializeField(s, nameof(blowOffAction));
			SerializeField(s, nameof(followCurveAction));
			SerializeField(s, nameof(flyIdleAction));
			SerializeField(s, nameof(playerDetectorMultiplierInWater));
		}
		public override uint? ClassCRC => 0x2F982DFE;
	}
}

