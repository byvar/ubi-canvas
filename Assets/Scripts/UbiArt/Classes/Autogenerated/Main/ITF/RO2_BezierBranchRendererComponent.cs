using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierBranchRendererComponent : RO2_BezierBranchBaseRendererComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCF0F3EF7;
	}
}

