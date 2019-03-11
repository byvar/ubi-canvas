using UnityEngine;

namespace UbiArt.ITF {
	public partial class MultipassBranchRendererComponent_Template : BezierBranchComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFF4B6582;
	}
}

