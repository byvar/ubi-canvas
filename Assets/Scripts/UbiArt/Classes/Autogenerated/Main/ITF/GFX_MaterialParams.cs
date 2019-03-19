using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
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
		[Serialize("float__0"         )] public float float__0;
		[Serialize("float__1"         )] public float float__1;
		[Serialize("float__2"         )] public float float__2;
		[Serialize("float__3"         )] public float float__3;
		[Serialize("int__4"           )] public int int__4;
		[Serialize("float__5"         )] public float float__5;
		[Serialize("float__6"         )] public float float__6;
		[Serialize("float__7"         )] public float float__7;
		[Serialize("float__8"         )] public float float__8;
		[Serialize("float__9"         )] public float float__9;
		[Serialize("float__10"        )] public float float__10;
		[Serialize("float__11"        )] public float float__11;
		[Serialize("float__12"        )] public float float__12;
		[Serialize("int__13"          )] public int int__13;
		[Serialize("float__14"        )] public float float__14;
		[Serialize("float__15"        )] public float float__15;
		[Serialize("float__16"        )] public float float__16;
		[Serialize("float__17"        )] public float float__17;
		[Serialize("int__18"          )] public int int__18;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(float__9));
					SerializeField(s, nameof(float__10));
					SerializeField(s, nameof(float__11));
					SerializeField(s, nameof(float__12));
					SerializeField(s, nameof(int__13));
					SerializeField(s, nameof(float__14));
					SerializeField(s, nameof(float__15));
					SerializeField(s, nameof(float__16));
					SerializeField(s, nameof(float__17));
					SerializeField(s, nameof(int__18));
				}
			} else {
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
}

