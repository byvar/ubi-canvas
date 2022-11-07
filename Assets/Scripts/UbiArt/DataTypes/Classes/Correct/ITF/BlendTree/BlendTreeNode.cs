namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNode<T> : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF7DC9A49;
	}
}

