using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AnimCurveComponent : CSerializable {
		public float animDuration;
		public Placeholder posXCurve;
		public float posXMaxValue;
		public Placeholder posYCurve;
		public float posYMaxValue;
		public Placeholder posZCurve;
		public float posZMaxValue;
		public Placeholder rotCurve;
		[Description("Max rotation value in degrees")]
		public float rotMaxValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animDuration = s.Serialize<float>(animDuration, name: "animDuration");
			posXCurve = s.SerializeObject<Placeholder>(posXCurve, name: "posXCurve");
			posXMaxValue = s.Serialize<float>(posXMaxValue, name: "posXMaxValue");
			posYCurve = s.SerializeObject<Placeholder>(posYCurve, name: "posYCurve");
			posYMaxValue = s.Serialize<float>(posYMaxValue, name: "posYMaxValue");
			posZCurve = s.SerializeObject<Placeholder>(posZCurve, name: "posZCurve");
			posZMaxValue = s.Serialize<float>(posZMaxValue, name: "posZMaxValue");
			rotCurve = s.SerializeObject<Placeholder>(rotCurve, name: "rotCurve");
			rotMaxValue = s.Serialize<float>(rotMaxValue, name: "rotMaxValue");
		}
		public override uint? ClassCRC => 0x797485E6;
	}
}

