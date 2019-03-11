using UnityEngine;

namespace UbiArt.ITF {
	public partial class Animation3DTreeNodePlayAnim : BlendTreeNode<Animation3DTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8DFE26A9;
	}
}

