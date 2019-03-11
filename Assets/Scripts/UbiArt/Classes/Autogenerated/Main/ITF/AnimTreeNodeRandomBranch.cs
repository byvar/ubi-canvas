using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodeRandomBranch : BlendTreeNodeChooseBranch<AnimTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x965C746E;
	}
}

