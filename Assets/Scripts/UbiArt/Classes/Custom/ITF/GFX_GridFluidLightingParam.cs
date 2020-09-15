using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidLightingParam : CSerializable {
		public bool UseLighting;
		public float FrontLightIntensity;
		public float BackLightIntensity;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				UseLighting = s.Serialize<bool>(UseLighting, name: "UseLighting");
				FrontLightIntensity = s.Serialize<float>(FrontLightIntensity, name: "FrontLightIntensity");
				BackLightIntensity = s.Serialize<float>(BackLightIntensity, name: "BackLightIntensity");
			}
		}
	}
}

