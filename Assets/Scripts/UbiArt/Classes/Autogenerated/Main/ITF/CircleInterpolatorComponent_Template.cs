using UnityEngine;

namespace UbiArt.ITF {
	public partial class CircleInterpolatorComponent_Template : InterpolatorComponent_Template {
		[Serialize("innerRadius")] public float innerRadius;
		[Serialize("outerRadius")] public float outerRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(innerRadius));
			SerializeField(s, nameof(outerRadius));
		}
		public override uint? ClassCRC => 0x6A69DF6E;
	}
}

