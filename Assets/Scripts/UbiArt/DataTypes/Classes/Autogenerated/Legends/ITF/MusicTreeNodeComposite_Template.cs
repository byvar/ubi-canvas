namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class MusicTreeNodeComposite_Template : MusicTreeNode_Template {
		public int looping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			looping = s.Serialize<int>(looping, name: "looping");
		}
		public override uint? ClassCRC => 0x0D375BB7;
	}
}

