using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIBubblePrizeBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("isCustomCurve"                  )] public bool isCustomCurve;
		[Serialize("bubblePrize"                    )] public Placeholder bubblePrize;
		[Serialize("bezierStretchStart"             )] public float bezierStretchStart;
		[Serialize("bezierStretchEnd"               )] public float bezierStretchEnd;
		[Serialize("bezierAction"                   )] public Placeholder bezierAction;
		[Serialize("blowOffAction"                  )] public Placeholder blowOffAction;
		[Serialize("followCurveAction"              )] public Placeholder followCurveAction;
		[Serialize("flyIdleAction"                  )] public Placeholder flyIdleAction;
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
		public override uint? ClassCRC => 0x1DD53715;
	}
}

