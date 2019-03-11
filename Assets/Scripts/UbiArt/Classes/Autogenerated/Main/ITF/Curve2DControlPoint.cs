using UnityEngine;

namespace UbiArt.ITF {
	public partial class Curve2DControlPoint : CSerializable {
		[Serialize("x"       )] public float x;
		[Serialize("y"       )] public float y;
		[Serialize("leftTan" )] public float leftTan;
		[Serialize("rightTan")] public float rightTan;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(x));
			SerializeField(s, nameof(y));
			SerializeField(s, nameof(leftTan));
			SerializeField(s, nameof(rightTan));
		}
	}
}

