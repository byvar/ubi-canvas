using UnityEngine;

namespace UbiArt.ITF {
	public partial class HeadBranchComponent : BezierBranchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x121856A0;
	}
}

