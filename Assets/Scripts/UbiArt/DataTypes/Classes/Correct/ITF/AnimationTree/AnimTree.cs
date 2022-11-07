namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimTree : BlendTree<AnimTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
	}
}

