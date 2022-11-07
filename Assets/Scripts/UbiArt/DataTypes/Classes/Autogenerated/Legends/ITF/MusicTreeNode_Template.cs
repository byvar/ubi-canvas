namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion)]
	public partial class MusicTreeNode_Template : BlendTreeNodeBlend_Template<MusicTreeResult> {
		public uint pauseInsensitiveFlags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pauseInsensitiveFlags = s.Serialize<uint>(pauseInsensitiveFlags, name: "pauseInsensitiveFlags");
		}
		public override uint? ClassCRC => 0xFE2667F1;
	}
}

