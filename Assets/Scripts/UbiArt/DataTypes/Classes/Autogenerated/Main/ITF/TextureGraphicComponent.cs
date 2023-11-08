namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class TextureGraphicComponent : GraphicComponent {
		public Path texture;
		public TEXTURE_ANCHOR anchor = TEXTURE_ANCHOR.MIDDLE_CENTER;
		public GFXMaterialSerializable material;
		public Vec2d Scale = Vec2d.One;
		public float Width;
		public Angle Angle;
		public Vec3d Offset;
		public Vec2d UVScale = Vec2d.One;
		public Vec2d UVOffset;
		public uint spriteIndex = 0xFFFFFFFF;
		public Vec2d uvRatio = Vec2d.One;
		public Vec2d uvTranslationSpeed;
		public Vec2d size;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
			} else if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						texture = s.SerializeObject<Path>(texture, name: "texture");
					}
					anchor = s.Serialize<TEXTURE_ANCHOR>(anchor, name: "anchor");
					material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
					spriteIndex = s.Serialize<uint>(spriteIndex, name: "spriteIndex");
					if (s.Settings.Platform != GamePlatform.Vita) {
						uvRatio = s.SerializeObject<Vec2d>(uvRatio, name: "uvRatio");
						uvTranslationSpeed = s.SerializeObject<Vec2d>(uvTranslationSpeed, name: "uvTranslationSpeed");
					}
				}
			} else if (s.Settings.Game == Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						texture = s.SerializeObject<Path>(texture, name: "texture");
					}
					anchor = s.Serialize<TEXTURE_ANCHOR>(anchor, name: "anchor");
					material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
					spriteIndex = s.Serialize<uint>(spriteIndex, name: "spriteIndex");
					size = s.SerializeObject<Vec2d>(size, name: "size");
					uvRatio = s.SerializeObject<Vec2d>(uvRatio, name: "uvRatio");
					uvTranslationSpeed = s.SerializeObject<Vec2d>(uvTranslationSpeed, name: "uvTranslationSpeed");
				}
			} else if (s.Settings.Game == Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						texture = s.SerializeObject<Path>(texture, name: "texture");
					}
					anchor = s.Serialize<TEXTURE_ANCHOR>(anchor, name: "anchor");
					material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
					spriteIndex = s.Serialize<uint>(spriteIndex, name: "spriteIndex");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default | SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					anchor = s.Serialize<TEXTURE_ANCHOR>(anchor, name: "anchor");
					material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
					Scale = s.SerializeObject<Vec2d>(Scale, name: "Scale");
					Width = s.Serialize<float>(Width, name: "Width");
					Angle = s.SerializeObject<Angle>(Angle, name: "Angle");
					Offset = s.SerializeObject<Vec3d>(Offset, name: "Offset");
					UVScale = s.SerializeObject<Vec2d>(UVScale, name: "UVScale");
					UVOffset = s.SerializeObject<Vec2d>(UVOffset, name: "UVOffset");
				}
			}
		}
		public enum TEXTURE_ANCHOR {
			[Serialize("TEXTURE_ANCHOR_TOP_LEFT"     )] TOP_LEFT = 0,
			[Serialize("TEXTURE_ANCHOR_MIDDLE_CENTER")] MIDDLE_CENTER = 1,
			[Serialize("TEXTURE_ANCHOR_MIDDLE_LEFT"  )] MIDDLE_LEFT = 2,
			[Serialize("TEXTURE_ANCHOR_MIDDLE_RIGHT" )] MIDDLE_RIGHT = 3,
			[Serialize("TEXTURE_ANCHOR_TOP_CENTER"   )] TOP_CENTER = 4,
			[Serialize("TEXTURE_ANCHOR_TOP_RIGHT"    )] TOP_RIGHT = 5,
			[Serialize("TEXTURE_ANCHOR_BOTTOM_CENTER")] BOTTOM_CENTER = 6,
			[Serialize("TEXTURE_ANCHOR_BOTTOM_LEFT"  )] BOTTOM_LEFT = 7,
			[Serialize("TEXTURE_ANCHOR_BOTTOM_RIGHT" )] BOTTOM_RIGHT = 8,
		}
		public override uint? ClassCRC => 0x7B48A9AE;
	}
}

