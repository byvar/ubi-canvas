using UnityEngine;

namespace UbiArt.ITF {
	public partial class SliderHeadBranchComponent : BezierBranchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x35017396;
	}
}

