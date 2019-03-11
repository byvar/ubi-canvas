using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchFxComponent : BezierBranchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x00251BAC;
	}
}

