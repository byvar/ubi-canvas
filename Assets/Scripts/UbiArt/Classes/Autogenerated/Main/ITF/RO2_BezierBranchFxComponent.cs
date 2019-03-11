using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierBranchFxComponent : RO2_BezierBranchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x12A94E0A;
	}
}

