using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeTransition<T> : CSerializable {
		[Serialize("node"         )] public Generic<BlendTreeNode<T>> node;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(node));
		}
	}
}

