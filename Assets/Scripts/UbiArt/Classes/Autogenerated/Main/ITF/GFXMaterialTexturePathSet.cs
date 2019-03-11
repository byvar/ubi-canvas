using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMaterialTexturePathSet : CSerializable {
		[Serialize("diffuse"      )] public Path diffuse;
		[Serialize("normal"       )] public Path normal;
		[Serialize("separateAlpha")] public Path separateAlpha;
		[Serialize("diffuse_2"    )] public Path diffuse_2;
		[Serialize("back_light_2" )] public Path back_light_2;
		[Serialize("specular"     )] public Path specular;
		[Serialize("colorMask"    )] public Path colorMask;
		[Serialize("anim_impostor")] public Path anim_impostor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(diffuse));
			SerializeField(s, nameof(normal));
			SerializeField(s, nameof(separateAlpha));
			SerializeField(s, nameof(diffuse_2));
			SerializeField(s, nameof(back_light_2));
			SerializeField(s, nameof(specular));
			SerializeField(s, nameof(colorMask));
			SerializeField(s, nameof(anim_impostor));
		}
	}
}

