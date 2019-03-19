using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TextureBankPath : CSerializable {
		[Serialize("id"            )] public StringID id;
		[Serialize("patchBank"     )] public Path patchBank;
		[Serialize("texture"       )] public Path texture;
		[Serialize("textureSet"    )] public GFXMaterialTexturePathSet textureSet;
		[Serialize("materialShader")] public Path materialShader;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(patchBank));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texture));
			}
			SerializeField(s, nameof(textureSet));
			SerializeField(s, nameof(materialShader));
		}
	}
}

