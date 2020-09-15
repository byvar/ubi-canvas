using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AutoFlyingPlatformComponent_Template : ActorComponent_Template {
		public uint prevNodeCount;
		public float speedMultiplierMinValue;
		public float speedMultiplierMaxValue;
		public float speedMultiplierMinDistance;
		public float speedMultiplierMaxDistance;
		public Vec2d targetEvaluationOffset;
		public bool bezierRenderEnabled;
		public BezierCurveRenderer_Template bezierRenderer;
		public float uvScrollSpeed;
		public bool useInputs;
		public bool stopOnEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			prevNodeCount = s.Serialize<uint>(prevNodeCount, name: "prevNodeCount");
			speedMultiplierMinValue = s.Serialize<float>(speedMultiplierMinValue, name: "speedMultiplierMinValue");
			speedMultiplierMaxValue = s.Serialize<float>(speedMultiplierMaxValue, name: "speedMultiplierMaxValue");
			speedMultiplierMinDistance = s.Serialize<float>(speedMultiplierMinDistance, name: "speedMultiplierMinDistance");
			speedMultiplierMaxDistance = s.Serialize<float>(speedMultiplierMaxDistance, name: "speedMultiplierMaxDistance");
			targetEvaluationOffset = s.SerializeObject<Vec2d>(targetEvaluationOffset, name: "targetEvaluationOffset");
			bezierRenderEnabled = s.Serialize<bool>(bezierRenderEnabled, name: "bezierRenderEnabled");
			bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
			uvScrollSpeed = s.Serialize<float>(uvScrollSpeed, name: "uvScrollSpeed");
			useInputs = s.Serialize<bool>(useInputs, name: "useInputs");
			stopOnEnd = s.Serialize<bool>(stopOnEnd, name: "stopOnEnd");
		}
		public override uint? ClassCRC => 0xBB414DE3;
	}
}

