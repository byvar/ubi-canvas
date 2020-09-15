using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class NormalLightingParam : CSerializable {
		public float LightBrightness;
		public float LightContrast;
		public Vec3d Rotation;
		public bool UseNormalMapLighting;
		public Color RimLightColor;
		public float RimLightPower;
		public float SpecIntensity;
		public float SpecSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LightBrightness = s.Serialize<float>(LightBrightness, name: "LightBrightness");
			LightContrast = s.Serialize<float>(LightContrast, name: "LightContrast");
			Rotation = s.SerializeObject<Vec3d>(Rotation, name: "Rotation");
			UseNormalMapLighting = s.Serialize<bool>(UseNormalMapLighting, name: "UseNormalMapLighting");
			RimLightColor = s.SerializeObject<Color>(RimLightColor, name: "RimLightColor");
			RimLightPower = s.Serialize<float>(RimLightPower, name: "RimLightPower");
			SpecIntensity = s.Serialize<float>(SpecIntensity, name: "SpecIntensity");
			SpecSize = s.Serialize<float>(SpecSize, name: "SpecSize");
		}
	}
}

