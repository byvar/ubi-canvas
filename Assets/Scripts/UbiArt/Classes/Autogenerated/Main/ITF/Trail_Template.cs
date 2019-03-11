using UnityEngine;

namespace UbiArt.ITF {
	public partial class Trail_Template : CSerializable {
		[Serialize("texture"           )] public Path texture;
		[Serialize("material"          )] public GFXMaterialSerializable material;
		[Serialize("nbFrames"          )] public uint nbFrames;
		[Serialize("fixTrailLenght"    )] public uint fixTrailLenght;
		[Serialize("trailFaidingTime"  )] public float trailFaidingTime;
		[Serialize("thicknessBegin"    )] public float thicknessBegin;
		[Serialize("thicknessEnd"      )] public float thicknessEnd;
		[Serialize("alphaBegin"        )] public float alphaBegin;
		[Serialize("alphaEnd"          )] public float alphaEnd;
		[Serialize("trailBlending"     )] public float trailBlending;
		[Serialize("fadeLength"        )] public float fadeLength;
		[Serialize("tesselateMaxLength")] public float tesselateMaxLength;
		[Serialize("tesselateMinLength")] public float tesselateMinLength;
		[Serialize("color"             )] public Color color;
		[Serialize("attachBone"        )] public StringID attachBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texture));
			}
			SerializeField(s, nameof(material));
			SerializeField(s, nameof(nbFrames));
			SerializeField(s, nameof(fixTrailLenght));
			SerializeField(s, nameof(trailFaidingTime));
			SerializeField(s, nameof(thicknessBegin));
			SerializeField(s, nameof(thicknessEnd));
			SerializeField(s, nameof(alphaBegin));
			SerializeField(s, nameof(alphaEnd));
			SerializeField(s, nameof(trailBlending));
			SerializeField(s, nameof(fadeLength));
			SerializeField(s, nameof(tesselateMaxLength));
			SerializeField(s, nameof(tesselateMinLength));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(attachBone));
		}
	}
}

