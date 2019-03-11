using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysForceModifierCircle_Template : PhysForceModifier_Template {
		[Serialize("radius"    )] public float radius;
		[Serialize("angleStart")] public Angle angleStart;
		[Serialize("angleEnd"  )] public Angle angleEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(angleStart));
			SerializeField(s, nameof(angleEnd));
		}
		public override uint? ClassCRC => 0xD8719B69;
	}
}

