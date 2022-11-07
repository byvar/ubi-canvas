namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class TextureGraphicComponent2D : GraphicComponent {
		public align ALIGN;
		public float SCREEN_POURCENT_X;
		public float SCREEN_POURCENT_Y;
		public Path texture;
		public Vec2d quadSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				ALIGN = s.Serialize<align>(ALIGN, name: "ALIGN");
				SCREEN_POURCENT_X = s.Serialize<float>(SCREEN_POURCENT_X, name: "SCREEN_POURCENT_X");
				SCREEN_POURCENT_Y = s.Serialize<float>(SCREEN_POURCENT_Y, name: "SCREEN_POURCENT_Y");
				texture = s.SerializeObject<Path>(texture, name: "texture");
				quadSize = s.SerializeObject<Vec2d>(quadSize, name: "quadSize");
			}
		}
		public enum align {
			[Serialize("align_free"    )] free = 0,
			[Serialize("align_centerX" )] centerX = 1,
			[Serialize("align_centerY" )] centerY = 2,
			[Serialize("align_centerXY")] centerXY = 3,
		}
		public override uint? ClassCRC => 0x661432DC;
	}
}

