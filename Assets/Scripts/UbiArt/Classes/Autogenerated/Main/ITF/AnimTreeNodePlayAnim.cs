using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodePlayAnim : BlendTreeNode<AnimTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x596FBA3C;
	}
}

