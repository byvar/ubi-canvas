using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodeBranchTransition : BlendTreeNodeChooseBranch<AnimTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x52E3FC24;
	}
}

