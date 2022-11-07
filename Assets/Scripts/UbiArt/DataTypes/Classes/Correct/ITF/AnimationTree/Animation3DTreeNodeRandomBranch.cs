namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class Animation3DTreeNodeRandomBranch : BlendTreeNodeChooseBranch<Animation3DTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x26911842;
	}
}

