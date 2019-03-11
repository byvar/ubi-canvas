using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodeMarchBlend : BlendTreeNodeChooseBranch<AnimTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x70658F43;
	}
}

