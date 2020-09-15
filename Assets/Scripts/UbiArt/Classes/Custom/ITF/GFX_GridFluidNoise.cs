using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidNoise : CSerializable {
		public Path Texture;
		public float ScaleX;
		public float ScaleY;
		public float Intensity;
		public float Modulation;
		public float Freq;
		public float SpeedX;
		public float SpeedY;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Texture = s.SerializeObject<Path>(Texture, name: "Texture");
				ScaleX = s.Serialize<float>(ScaleX, name: "ScaleX");
				ScaleY = s.Serialize<float>(ScaleY, name: "ScaleY");
				Intensity = s.Serialize<float>(Intensity, name: "Intensity");
				Modulation = s.Serialize<float>(Modulation, name: "Modulation");
				Freq = s.Serialize<float>(Freq, name: "Freq");
				SpeedX = s.Serialize<float>(SpeedX, name: "SpeedX");
				SpeedY = s.Serialize<float>(SpeedY, name: "SpeedY");
			}
		}
	}
}

