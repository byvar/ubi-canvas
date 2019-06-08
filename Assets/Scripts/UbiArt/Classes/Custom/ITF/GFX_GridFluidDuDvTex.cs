using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidDuDvTex : CSerializable {
		[Serialize("Texture"        )] public Path Texture;
		[Serialize("Intensity"      )] public float Intensity;
		[Serialize("SpeedX1"        )] public float SpeedX1;
		[Serialize("SpeedY1"        )] public float SpeedY1;
		[Serialize("ScaleX1"        )] public float ScaleX1;
		[Serialize("ScaleY1"        )] public float ScaleY1;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Texture));
				SerializeField(s, nameof(Intensity));
				SerializeField(s, nameof(SpeedX1));
				SerializeField(s, nameof(SpeedY1));
				SerializeField(s, nameof(ScaleX1));
				SerializeField(s, nameof(ScaleY1));
			}
		}
	}
}

