using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidNoise : CSerializable {
		[Serialize("Texture"   )] public Path Texture;
		[Serialize("ScaleX"    )] public float ScaleX;
		[Serialize("ScaleY"    )] public float ScaleY;
		[Serialize("Intensity" )] public float Intensity;
		[Serialize("Modulation")] public float Modulation;
		[Serialize("Freq"      )] public float Freq;
		[Serialize("SpeedX"    )] public float SpeedX;
		[Serialize("SpeedY"    )] public float SpeedY;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Texture));
				SerializeField(s, nameof(ScaleX));
				SerializeField(s, nameof(ScaleY));
				SerializeField(s, nameof(Intensity));
				SerializeField(s, nameof(Modulation));
				SerializeField(s, nameof(Freq));
				SerializeField(s, nameof(SpeedX));
				SerializeField(s, nameof(SpeedY));
			}
		}
	}
}

