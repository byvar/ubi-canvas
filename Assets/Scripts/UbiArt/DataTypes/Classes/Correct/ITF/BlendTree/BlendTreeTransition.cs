namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeTransition<T> : CSerializable {
		public Generic<BlendTreeNode<T>> node;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			node = s.SerializeObject<Generic<BlendTreeNode<T>>>(node, name: "node");
		}
	}
}

