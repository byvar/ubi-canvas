namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimTreeNodeRandomBranch_Template<T> : BlendTreeNodeChooseBranch_Template<T> where T : AnimTreeResult {
		public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			loop = s.Serialize<bool>(loop, name: "loop");
		}
		public override uint? ClassCRC => 0x1C5654FE;
	}
}

