using UnityEngine;

namespace UbiArt.ITF {
	public partial class NormalLightingParam : CSerializable {
		[Serialize("LightBrightness"     )] public float LightBrightness;
		[Serialize("LightContrast"       )] public float LightContrast;
		[Serialize("Rotation"            )] public Vector3 Rotation;
		[Serialize("UseNormalMapLighting")] public bool UseNormalMapLighting;
		[Serialize("RimLightColor"       )] public Color RimLightColor;
		[Serialize("RimLightPower"       )] public float RimLightPower;
		[Serialize("SpecIntensity"       )] public float SpecIntensity;
		[Serialize("SpecSize"            )] public float SpecSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LightBrightness));
			SerializeField(s, nameof(LightContrast));
			SerializeField(s, nameof(Rotation));
			SerializeField(s, nameof(UseNormalMapLighting));
			SerializeField(s, nameof(RimLightColor));
			SerializeField(s, nameof(RimLightPower));
			SerializeField(s, nameof(SpecIntensity));
			SerializeField(s, nameof(SpecSize));
		}
	}
}

