using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AnimCurveComponent : CSerializable {
		[Serialize("animDuration")] public float animDuration;
		[Serialize("posXCurve"   )] public Placeholder posXCurve;
		[Serialize("posXMaxValue")] public float posXMaxValue;
		[Serialize("posYCurve"   )] public Placeholder posYCurve;
		[Serialize("posYMaxValue")] public float posYMaxValue;
		[Serialize("posZCurve"   )] public Placeholder posZCurve;
		[Serialize("posZMaxValue")] public float posZMaxValue;
		[Serialize("rotCurve"    )] public Placeholder rotCurve;
		[Description("Max rotation value in degrees")]
		[Serialize("rotMaxValue" )] public float rotMaxValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animDuration));
			SerializeField(s, nameof(posXCurve));
			SerializeField(s, nameof(posXMaxValue));
			SerializeField(s, nameof(posYCurve));
			SerializeField(s, nameof(posYMaxValue));
			SerializeField(s, nameof(posZCurve));
			SerializeField(s, nameof(posZMaxValue));
			SerializeField(s, nameof(rotCurve));
			SerializeField(s, nameof(rotMaxValue));
		}
		public override uint? ClassCRC => 0x797485E6;
	}
}

