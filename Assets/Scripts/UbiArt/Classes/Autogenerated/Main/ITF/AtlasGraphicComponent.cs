using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AtlasGraphicComponent : GraphicComponent {
		public Path texture;
		public GFXMaterialSerializable material;
		public TEXSET_ID textureLayer;
		public uint atlasIndex;
		public float extrudeFactor;
		public Vec3d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
			}
			material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
			textureLayer = s.Serialize<TEXSET_ID>(textureLayer, name: "textureLayer");
			atlasIndex = s.Serialize<uint>(atlasIndex, name: "atlasIndex");
			extrudeFactor = s.Serialize<float>(extrudeFactor, name: "extrudeFactor");
			offset = s.SerializeObject<Vec3d>(offset, name: "offset");
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
		public override uint? ClassCRC => 0xBB163FF8;
	}
}

