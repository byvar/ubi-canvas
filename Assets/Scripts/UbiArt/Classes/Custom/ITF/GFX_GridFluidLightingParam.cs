using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidLightingParam : CSerializable {
		[Serialize("UseLighting"        )] public bool UseLighting;
		[Serialize("FrontLightIntensity")] public float FrontLightIntensity;
		[Serialize("BackLightIntensity" )] public float BackLightIntensity;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(UseLighting));
				SerializeField(s, nameof(FrontLightIntensity));
				SerializeField(s, nameof(BackLightIntensity));
			}
		}
	}
}

