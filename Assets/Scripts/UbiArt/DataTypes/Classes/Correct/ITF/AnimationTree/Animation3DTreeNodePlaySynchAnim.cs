namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Animation3DTreeNodePlaySynchAnim : BlendTreeNode<Animation3DTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x050AC163;
	}
}

