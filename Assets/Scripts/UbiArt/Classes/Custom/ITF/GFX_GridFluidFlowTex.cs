using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidFlowTex : CSerializable {
		[Serialize("Texture"        )] public Path Texture;
		[Serialize("Deformation"    )] public float Deformation;
		[Serialize("Intensity"      )] public float Intensity;
		[Serialize("SpeedX1"        )] public float SpeedX1;
		[Serialize("SpeedY1"        )] public float SpeedY1;
		[Serialize("SpeedX2"        )] public float SpeedX2;
		[Serialize("SpeedY2"        )] public float SpeedY2;
		[Serialize("SpeedX3"        )] public float SpeedX3;
		[Serialize("SpeedY3"        )] public float SpeedY3;
		[Serialize("ScaleX1"        )] public float ScaleX1;
		[Serialize("ScaleY1"        )] public float ScaleY1;
		[Serialize("ScaleX2"        )] public float ScaleX2;
		[Serialize("ScaleY2"        )] public float ScaleY2;
		[Serialize("ScaleX3"        )] public float ScaleX3;
		[Serialize("ScaleY3"        )] public float ScaleY3;
		[Serialize("RGBMultiplier"  )] public float RGBMultiplier;
		[Serialize("AlphaMultiplier")] public float AlphaMultiplier;
		[Serialize("DensityFactor"  )] public float DensityFactor;
		[Serialize("VelocityPower"  )] public float VelocityPower;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Texture));
				SerializeField(s, nameof(Deformation));
				SerializeField(s, nameof(Intensity));
				SerializeField(s, nameof(SpeedX1));
				SerializeField(s, nameof(SpeedY1));
				SerializeField(s, nameof(SpeedX2));
				SerializeField(s, nameof(SpeedY2));
				SerializeField(s, nameof(SpeedX3));
				SerializeField(s, nameof(SpeedY3));
				SerializeField(s, nameof(ScaleX1));
				SerializeField(s, nameof(ScaleY1));
				SerializeField(s, nameof(ScaleX2));
				SerializeField(s, nameof(ScaleY2));
				SerializeField(s, nameof(ScaleX3));
				SerializeField(s, nameof(ScaleY3));
				SerializeField(s, nameof(RGBMultiplier));
				SerializeField(s, nameof(AlphaMultiplier));
				SerializeField(s, nameof(DensityFactor));
				SerializeField(s, nameof(VelocityPower));
			}
		}
	}
}

