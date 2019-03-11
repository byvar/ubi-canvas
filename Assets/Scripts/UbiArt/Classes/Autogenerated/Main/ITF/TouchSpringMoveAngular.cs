using UnityEngine;

namespace UbiArt.ITF {
	public partial class TouchSpringMoveAngular : TouchSpringMoveBase {
		[Serialize("totalAngle"     )] public Angle totalAngle;
		[Serialize("minAngleLimit"  )] public Angle minAngleLimit;
		[Serialize("maxAngleLimit"  )] public Angle maxAngleLimit;
		[Serialize("initAngle"      )] public Angle initAngle;
		[Serialize("axisOffsetAngle")] public Angle axisOffsetAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(totalAngle));
			SerializeField(s, nameof(minAngleLimit));
			SerializeField(s, nameof(maxAngleLimit));
			SerializeField(s, nameof(initAngle));
			SerializeField(s, nameof(axisOffsetAngle));
		}
		public override uint? ClassCRC => 0x81E5A7CA;
	}
}

