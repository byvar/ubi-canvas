using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeBlend<AnimTreeResult> : BlendTreeNode<AnimTreeResult> {
		[Serialize("leafs")] public CList<BlendTreeNode<AnimTreeResult>> leafs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(leafs));
		}
		public override uint? ClassCRC => 0x257D918B;
	}
}

