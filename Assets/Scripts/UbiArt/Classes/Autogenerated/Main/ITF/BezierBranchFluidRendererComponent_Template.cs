using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class BezierBranchFluidRendererComponent_Template : BezierBranchBaseRendererComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE4692941;
	}
}

