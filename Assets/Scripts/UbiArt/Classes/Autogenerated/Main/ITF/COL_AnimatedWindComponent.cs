using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AnimatedWindComponent : CSerializable {
		[Serialize("curveForceMultiplier")] public Placeholder curveForceMultiplier;
		[Serialize("curveMaxValue"       )] public float curveMaxValue;
		[Serialize("curveDuration"       )] public float curveDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(curveForceMultiplier));
			SerializeField(s, nameof(curveMaxValue));
			SerializeField(s, nameof(curveDuration));
		}
		public override uint? ClassCRC => 0x230B936F;
	}
}

