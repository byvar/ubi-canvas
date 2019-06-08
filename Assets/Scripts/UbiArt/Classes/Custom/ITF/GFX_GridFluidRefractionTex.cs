using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidRefractionTex : CSerializable {
		[Serialize("Texture"       )] public Path Texture;
		[Serialize("NoiseIntensity")] public float NoiseIntensity;
		[Serialize("SpeedX1"       )] public float SpeedX1;
		[Serialize("SpeedY1"       )] public float SpeedY1;
		[Serialize("ScaleX1"       )] public float ScaleX1;
		[Serialize("ScaleY1"       )] public float ScaleY1;
		[Serialize("SpeedTexFactor")] public float SpeedTexFactor;
		[Serialize("FlatenDensity" )] public float FlatenDensity;
		[Serialize("FlatenSpeed"   )] public float FlatenSpeed;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Texture));
				SerializeField(s, nameof(NoiseIntensity));
				SerializeField(s, nameof(SpeedX1));
				SerializeField(s, nameof(SpeedY1));
				SerializeField(s, nameof(ScaleX1));
				SerializeField(s, nameof(ScaleY1));
				SerializeField(s, nameof(SpeedTexFactor));
				SerializeField(s, nameof(FlatenDensity));
				SerializeField(s, nameof(FlatenSpeed));
			}
		}
	}
}

