using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBlend<T> : BlendTreeNode<T> {
		public CList<Generic<BlendTreeNode<T>>> leafs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			leafs = s.SerializeObject<CList<Generic<BlendTreeNode<T>>>>(leafs, name: "leafs");
		}
		public override uint? ClassCRC => 0x257D918B;
	}
}

