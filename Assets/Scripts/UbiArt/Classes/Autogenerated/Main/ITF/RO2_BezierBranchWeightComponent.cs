using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierBranchWeightComponent : RO2_BezierBranchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9D3B8632;
	}
}

