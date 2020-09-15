using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidFlowTex : CSerializable {
		public Path Texture;
		public float Deformation;
		public float Intensity;
		public float SpeedX1;
		public float SpeedY1;
		public float SpeedX2;
		public float SpeedY2;
		public float SpeedX3;
		public float SpeedY3;
		public float ScaleX1;
		public float ScaleY1;
		public float ScaleX2;
		public float ScaleY2;
		public float ScaleX3;
		public float ScaleY3;
		public float RGBMultiplier;
		public float AlphaMultiplier;
		public float DensityFactor;
		public float VelocityPower;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Texture = s.SerializeObject<Path>(Texture, name: "Texture");
				Deformation = s.Serialize<float>(Deformation, name: "Deformation");
				Intensity = s.Serialize<float>(Intensity, name: "Intensity");
				SpeedX1 = s.Serialize<float>(SpeedX1, name: "SpeedX1");
				SpeedY1 = s.Serialize<float>(SpeedY1, name: "SpeedY1");
				SpeedX2 = s.Serialize<float>(SpeedX2, name: "SpeedX2");
				SpeedY2 = s.Serialize<float>(SpeedY2, name: "SpeedY2");
				SpeedX3 = s.Serialize<float>(SpeedX3, name: "SpeedX3");
				SpeedY3 = s.Serialize<float>(SpeedY3, name: "SpeedY3");
				ScaleX1 = s.Serialize<float>(ScaleX1, name: "ScaleX1");
				ScaleY1 = s.Serialize<float>(ScaleY1, name: "ScaleY1");
				ScaleX2 = s.Serialize<float>(ScaleX2, name: "ScaleX2");
				ScaleY2 = s.Serialize<float>(ScaleY2, name: "ScaleY2");
				ScaleX3 = s.Serialize<float>(ScaleX3, name: "ScaleX3");
				ScaleY3 = s.Serialize<float>(ScaleY3, name: "ScaleY3");
				RGBMultiplier = s.Serialize<float>(RGBMultiplier, name: "RGBMultiplier");
				AlphaMultiplier = s.Serialize<float>(AlphaMultiplier, name: "AlphaMultiplier");
				DensityFactor = s.Serialize<float>(DensityFactor, name: "DensityFactor");
				VelocityPower = s.Serialize<float>(VelocityPower, name: "VelocityPower");
			}
		}
	}
}

