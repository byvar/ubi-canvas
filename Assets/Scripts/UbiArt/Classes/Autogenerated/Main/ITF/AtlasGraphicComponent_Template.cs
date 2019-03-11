using UnityEngine;

namespace UbiArt.ITF {
	public partial class AtlasGraphicComponent_Template : GraphicComponent_Template {
		[Serialize("texture"     )] public Path texture;
		[Serialize("material"    )] public GFXMaterialSerializable material;
		[Serialize("textureLayer")] public TEXSET_ID textureLayer;
		[Serialize("texelRatio"  )] public Vector2 texelRatio;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texture));
			}
			SerializeField(s, nameof(material));
			SerializeField(s, nameof(textureLayer));
			SerializeField(s, nameof(texelRatio));
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

