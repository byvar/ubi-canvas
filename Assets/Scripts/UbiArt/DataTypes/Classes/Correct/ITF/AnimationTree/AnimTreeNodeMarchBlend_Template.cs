namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimTreeNodeMarchBlend_Template : BlendTreeNodeChooseBranch_Template<AnimTreeResult> {
		public float animPosToBlend = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPosToBlend = s.Serialize<float>(animPosToBlend, name: "animPosToBlend");
		}
		public override uint? ClassCRC => 0x5160E0D8;
	}
}

