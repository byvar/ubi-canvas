namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_TextureImageComponent : TextureGraphicComponent {
		public Vec2d offsetAfterLoading;
		public bool AllowDeloadTextureOnInactive;
		public bool AllowAutomaticShow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			offsetAfterLoading = s.SerializeObject<Vec2d>(offsetAfterLoading, name: "offsetAfterLoading");
			AllowDeloadTextureOnInactive = s.Serialize<bool>(AllowDeloadTextureOnInactive, name: "AllowDeloadTextureOnInactive");
			AllowAutomaticShow = s.Serialize<bool>(AllowAutomaticShow, name: "AllowAutomaticShow");
		}
		public override uint? ClassCRC => 0x2B83E1A7;
	}
}

