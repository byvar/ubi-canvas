namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class CreditsComponent : ActorComponent {
		public float width;
		public float height;
		public float scrollSpeed;
		public float globalFontScale;
		public float interline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			width = s.Serialize<float>(width, name: "width");
			height = s.Serialize<float>(height, name: "height");
			scrollSpeed = s.Serialize<float>(scrollSpeed, name: "scrollSpeed");
			globalFontScale = s.Serialize<float>(globalFontScale, name: "globalFontScale");
			interline = s.Serialize<float>(interline, name: "interline");
		}
		public override uint? ClassCRC => 0xA9BC1BE5;
	}
}

