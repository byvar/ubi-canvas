using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIProgressBar_Template : CSerializable {
		public float currentValueUpdateRate;
		public float maxValueUpdateRate;
		public StringID fullBarFX;
		public Vec2d fxOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			currentValueUpdateRate = s.Serialize<float>(currentValueUpdateRate, name: "currentValueUpdateRate");
			maxValueUpdateRate = s.Serialize<float>(maxValueUpdateRate, name: "maxValueUpdateRate");
			fullBarFX = s.SerializeObject<StringID>(fullBarFX, name: "fullBarFX");
			fxOffset = s.SerializeObject<Vec2d>(fxOffset, name: "fxOffset");
		}
		public override uint? ClassCRC => 0x946886AB;
	}
}

