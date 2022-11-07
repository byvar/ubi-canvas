namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBranchTransition<T> : BlendTreeNodeBlend<T> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9E5802A1;
	}
}

