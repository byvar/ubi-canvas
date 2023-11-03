namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIBubblePrizeBehavior_Template : TemplateAIBehavior {
		public bool isCustomCurve;
		public RO2_BubblePrize_Template bubblePrize;
		public float bezierStretchStart = 1f;
		public float bezierStretchEnd = 1f;
		public Generic<AIBezierAction_Template> bezierAction;
		public Generic<RO2_AIBlowOffAction_Template> blowOffAction;
		public Generic<RO2_AIFollowBezierCurveAction_Template> followCurveAction;
		public Generic<RO2_AIFlyIdleAction_Template> flyIdleAction;
		public float playerDetectorMultiplierInWater = 1.5f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isCustomCurve = s.Serialize<bool>(isCustomCurve, name: "isCustomCurve");
			bubblePrize = s.SerializeObject<RO2_BubblePrize_Template>(bubblePrize, name: "bubblePrize");
			bezierStretchStart = s.Serialize<float>(bezierStretchStart, name: "bezierStretchStart");
			bezierStretchEnd = s.Serialize<float>(bezierStretchEnd, name: "bezierStretchEnd");
			bezierAction = s.SerializeObject<Generic<AIBezierAction_Template>>(bezierAction, name: "bezierAction");
			blowOffAction = s.SerializeObject<Generic<RO2_AIBlowOffAction_Template>>(blowOffAction, name: "blowOffAction");
			followCurveAction = s.SerializeObject<Generic<RO2_AIFollowBezierCurveAction_Template>>(followCurveAction, name: "followCurveAction");
			flyIdleAction = s.SerializeObject<Generic<RO2_AIFlyIdleAction_Template>>(flyIdleAction, name: "flyIdleAction");
			playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
		}
		public override uint? ClassCRC => 0x2F982DFE;
	}
}

