using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchRendererComponent : BezierBranchBaseRendererComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x49220662;
	}
}

