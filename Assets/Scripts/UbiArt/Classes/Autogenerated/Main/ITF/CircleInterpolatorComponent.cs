using UnityEngine;

namespace UbiArt.ITF {
	public partial class CircleInterpolatorComponent : InterpolatorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBA81CB26;
	}
}

