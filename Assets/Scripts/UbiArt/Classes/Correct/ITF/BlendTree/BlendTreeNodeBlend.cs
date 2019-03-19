using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBlend<T> : BlendTreeNode<T> {
		[Serialize("leafs")] public CList<Generic<BlendTreeNode<T>>> leafs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(leafs));
		}
		public override uint? ClassCRC => 0x257D918B;
	}
}

