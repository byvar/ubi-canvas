using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchBoneComponent_Template : BezierBranchComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8FA695CF;
	}
}

