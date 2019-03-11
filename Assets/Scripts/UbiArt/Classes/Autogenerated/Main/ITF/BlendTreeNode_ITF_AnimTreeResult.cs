using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNode<AnimTreeResult> : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF7DC9A49;
	}
}

