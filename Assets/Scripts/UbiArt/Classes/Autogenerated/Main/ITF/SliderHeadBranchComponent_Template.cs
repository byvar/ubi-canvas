using UnityEngine;

namespace UbiArt.ITF {
	public partial class SliderHeadBranchComponent_Template : BezierBranchComponent_Template {
		[Serialize("slideForceFactor" )] public float slideForceFactor;
		[Serialize("slideSpeedSmoothA")] public float slideSpeedSmoothA;
		[Serialize("slideSpeedSmoothB")] public float slideSpeedSmoothB;
		[Serialize("growSpeedSmoothA" )] public float growSpeedSmoothA;
		[Serialize("growSpeedSmoothB" )] public float growSpeedSmoothB;
		[Serialize("waitDuration"     )] public float waitDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(slideForceFactor));
			SerializeField(s, nameof(slideSpeedSmoothA));
			SerializeField(s, nameof(slideSpeedSmoothB));
			SerializeField(s, nameof(growSpeedSmoothA));
			SerializeField(s, nameof(growSpeedSmoothB));
			SerializeField(s, nameof(waitDuration));
		}
		public override uint? ClassCRC => 0x3D41C39C;
	}
}

