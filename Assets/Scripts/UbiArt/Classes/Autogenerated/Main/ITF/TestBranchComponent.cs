using UnityEngine;

namespace UbiArt.ITF {
	public partial class TestBranchComponent : BezierBranchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCE5914E3;
	}
}

