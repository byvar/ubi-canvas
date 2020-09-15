using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AtlasGraphicComponent : GraphicComponent {
		[Serialize("texture"      )] public Path texture;
		[Serialize("material"     )] public GFXMaterialSerializable material;
		[Serialize("textureLayer" )] public TEXSET_ID textureLayer;
		[Serialize("atlasIndex"   )] public uint atlasIndex;
		[Serialize("extrudeFactor")] public float extrudeFactor;
		[Serialize("offset"       )] public Vec3d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texture));
			}
			SerializeField(s, nameof(material));
			SerializeField(s, nameof(textureLayer));
			SerializeField(s, nameof(atlasIndex));
			SerializeField(s, nameof(extrudeFactor));
			SerializeField(s, nameof(offset));
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

