using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierBranchGrowComponent_Template : RO2_BezierBranchComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x41E366A6;
	}
}

