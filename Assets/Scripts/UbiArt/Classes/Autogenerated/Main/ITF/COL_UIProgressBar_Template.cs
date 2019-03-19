using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIProgressBar_Template : CSerializable {
		[Serialize("currentValueUpdateRate")] public float currentValueUpdateRate;
		[Serialize("maxValueUpdateRate"    )] public float maxValueUpdateRate;
		[Serialize("fullBarFX"             )] public StringID fullBarFX;
		[Serialize("fxOffset"              )] public Vector2 fxOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(currentValueUpdateRate));
			SerializeField(s, nameof(maxValueUpdateRate));
			SerializeField(s, nameof(fullBarFX));
			SerializeField(s, nameof(fxOffset));
		}
		public override uint? ClassCRC => 0x5354E297;
	}
}

