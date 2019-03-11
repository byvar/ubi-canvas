using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFX_MaterialParams : CSerializable {
		[Serialize("matParams0F"      )] public float matParams0F;
		[Serialize("matParams1F"      )] public float matParams1F;
		[Serialize("matParams2F"      )] public float matParams2F;
		[Serialize("matParams3F"      )] public float matParams3F;
		[Serialize("matParams0I"      )] public int matParams0I;
		[Serialize("matParams0VX"     )] public float matParams0VX;
		[Serialize("matParams0VY"     )] public float matParams0VY;
		[Serialize("matParams0VZ"     )] public float matParams0VZ;
		[Serialize("matParams0VW"     )] public float matParams0VW;
		[Serialize("Refract_alphaMul" )] public float Refract_alphaMul;
		[Serialize("Refract_normalmul")] public float Refract_normalmul;
		[Serialize("Reflection_factor")] public float Reflection_factor;
		[Serialize("alphafadeDistMin" )] public float alphafadeDistMin;
		[Serialize("alphafadeDistMax" )] public float alphafadeDistMax;
		[Serialize("alphafadeDensity" )] public float alphafadeDensity;
		[Serialize("alphafadetype"    )] public int alphafadetype;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(matParams0F));
			SerializeField(s, nameof(matParams1F));
			SerializeField(s, nameof(matParams2F));
			SerializeField(s, nameof(matParams3F));
			SerializeField(s, nameof(matParams0I));
			SerializeField(s, nameof(matParams0VX));
			SerializeField(s, nameof(matParams0VY));
			SerializeField(s, nameof(matParams0VZ));
			SerializeField(s, nameof(matParams0VW));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(Refract_alphaMul));
				SerializeField(s, nameof(Refract_normalmul));
				SerializeField(s, nameof(Reflection_factor));
				SerializeField(s, nameof(alphafadeDistMin));
				SerializeField(s, nameof(alphafadeDistMax));
				SerializeField(s, nameof(alphafadeDensity));
				SerializeField(s, nameof(alphafadetype));
			}
		}
	}
}

