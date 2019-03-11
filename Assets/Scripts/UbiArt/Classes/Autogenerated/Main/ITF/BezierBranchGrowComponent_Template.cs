using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchGrowComponent_Template : BezierBranchComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7DD71A96;
	}
}

