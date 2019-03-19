using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AutoFlyingPlatformComponent_Template : ActorComponent_Template {
		[Serialize("prevNodeCount"             )] public uint prevNodeCount;
		[Serialize("speedMultiplierMinValue"   )] public float speedMultiplierMinValue;
		[Serialize("speedMultiplierMaxValue"   )] public float speedMultiplierMaxValue;
		[Serialize("speedMultiplierMinDistance")] public float speedMultiplierMinDistance;
		[Serialize("speedMultiplierMaxDistance")] public float speedMultiplierMaxDistance;
		[Serialize("targetEvaluationOffset"    )] public Vector2 targetEvaluationOffset;
		[Serialize("bezierRenderEnabled"       )] public bool bezierRenderEnabled;
		[Serialize("bezierRenderer"            )] public BezierCurveRenderer_Template bezierRenderer;
		[Serialize("uvScrollSpeed"             )] public float uvScrollSpeed;
		[Serialize("useInputs"                 )] public bool useInputs;
		[Serialize("stopOnEnd"                 )] public bool stopOnEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(prevNodeCount));
			SerializeField(s, nameof(speedMultiplierMinValue));
			SerializeField(s, nameof(speedMultiplierMaxValue));
			SerializeField(s, nameof(speedMultiplierMinDistance));
			SerializeField(s, nameof(speedMultiplierMaxDistance));
			SerializeField(s, nameof(targetEvaluationOffset));
			SerializeField(s, nameof(bezierRenderEnabled));
			SerializeField(s, nameof(bezierRenderer));
			SerializeField(s, nameof(uvScrollSpeed));
			SerializeField(s, nameof(useInputs));
			SerializeField(s, nameof(stopOnEnd));
		}
		public override uint? ClassCRC => 0xBB414DE3;
	}
}

