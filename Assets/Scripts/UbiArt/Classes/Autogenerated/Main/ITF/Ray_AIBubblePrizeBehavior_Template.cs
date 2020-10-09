using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIBubblePrizeBehavior_Template : TemplateAIBehavior {
		public int isCustomCurve;
		public Ray_BubblePrize_Template bubblePrize;
		public float bezierStretchStart;
		public float bezierStretchEnd;
		public Generic<AIBezierAction_Template> bezierAction;
		public Generic<Ray_AIBlowOffAction_Template> blowOffAction;
		public Generic<Ray_AIFollowBezierCurveAction_Template> followCurveAction;
		public Generic<Ray_AIFlyIdleAction_Template> flyIdleAction;
		public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isCustomCurve = s.Serialize<int>(isCustomCurve, name: "isCustomCurve");
			bubblePrize = s.SerializeObject<Ray_BubblePrize_Template>(bubblePrize, name: "bubblePrize");
			bezierStretchStart = s.Serialize<float>(bezierStretchStart, name: "bezierStretchStart");
			bezierStretchEnd = s.Serialize<float>(bezierStretchEnd, name: "bezierStretchEnd");
			bezierAction = s.SerializeObject<Generic<AIBezierAction_Template>>(bezierAction, name: "bezierAction");
			blowOffAction = s.SerializeObject<Generic<Ray_AIBlowOffAction_Template>>(blowOffAction, name: "blowOffAction");
			followCurveAction = s.SerializeObject<Generic<Ray_AIFollowBezierCurveAction_Template>>(followCurveAction, name: "followCurveAction");
			flyIdleAction = s.SerializeObject<Generic<Ray_AIFlyIdleAction_Template>>(flyIdleAction, name: "flyIdleAction");
			playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
		}
		public override uint? ClassCRC => 0x1DD53715;
	}
}

