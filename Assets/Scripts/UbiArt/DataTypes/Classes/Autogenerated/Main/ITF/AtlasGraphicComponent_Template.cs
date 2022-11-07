namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class AtlasGraphicComponent_Template : GraphicComponent_Template {
		public Path texture;
		public GFXMaterialSerializable material;
		public TEXSET_ID textureLayer;
		public Vec2d texelRatio;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
			}
			material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
			textureLayer = s.Serialize<TEXSET_ID>(textureLayer, name: "textureLayer");
			texelRatio = s.SerializeObject<Vec2d>(texelRatio, name: "texelRatio");
		}
		public enum TEXSET_ID {
			[Serialize("TEXSET_ID_DIFFUSE"       )] DIFFUSE = 0,
			[Serialize("TEXSET_ID_BACK_LIGHT"    )] BACK_LIGHT = 1,
			[Serialize("TEXSET_ID_NORMAL"        )] NORMAL = 2,
			[Serialize("TEXSET_ID_SEPARATE_ALPHA")] SEPARATE_ALPHA = 3,
			[Serialize("TEXSET_ID_DIFFUSE_2"     )] DIFFUSE_2 = 4,
			[Serialize("TEXSET_ID_BACK_LIGHT_2"  )] BACK_LIGHT_2 = 5,
			[Serialize("TEXSET_ID_SPECULAR"      )] SPECULAR = 6,
			[Serialize("TEXSET_ID_COLORMASK"     )] COLORMASK = 7,
		}
		public override uint? ClassCRC => 0xAC74F1F6;
	}
}

