using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimNodeSwing_Template : BlendTreeNodeChooseBranch_Template<AnimTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFF71E7EE;
	}
}

