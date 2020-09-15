using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class GFX_MaterialParams : CSerializable {
		public float matParams0F;
		public float matParams1F;
		public float matParams2F;
		public float matParams3F;
		public int matParams0I;
		public float matParams0VX;
		public float matParams0VY;
		public float matParams0VZ;
		public float matParams0VW;
		public float Refract_alphaMul;
		public float Refract_normalmul;
		public float Reflection_factor;
		public float alphafadeDistMin;
		public float alphafadeDistMax;
		public float alphafadeDensity;
		public int alphafadetype;
		public float float__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public int int__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public float float__10;
		public float float__11;
		public float float__12;
		public int int__13;
		public float float__14;
		public float float__15;
		public float float__16;
		public float float__17;
		public int int__18;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				int__4 = s.Serialize<int>(int__4, name: "int__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					float__9 = s.Serialize<float>(float__9, name: "float__9");
					float__10 = s.Serialize<float>(float__10, name: "float__10");
					float__11 = s.Serialize<float>(float__11, name: "float__11");
					float__12 = s.Serialize<float>(float__12, name: "float__12");
					int__13 = s.Serialize<int>(int__13, name: "int__13");
					float__14 = s.Serialize<float>(float__14, name: "float__14");
					float__15 = s.Serialize<float>(float__15, name: "float__15");
					float__16 = s.Serialize<float>(float__16, name: "float__16");
					float__17 = s.Serialize<float>(float__17, name: "float__17");
					int__18 = s.Serialize<int>(int__18, name: "int__18");
				}
			} else {
				matParams0F = s.Serialize<float>(matParams0F, name: "matParams0F");
				matParams1F = s.Serialize<float>(matParams1F, name: "matParams1F");
				matParams2F = s.Serialize<float>(matParams2F, name: "matParams2F");
				matParams3F = s.Serialize<float>(matParams3F, name: "matParams3F");
				matParams0I = s.Serialize<int>(matParams0I, name: "matParams0I");
				matParams0VX = s.Serialize<float>(matParams0VX, name: "matParams0VX");
				matParams0VY = s.Serialize<float>(matParams0VY, name: "matParams0VY");
				matParams0VZ = s.Serialize<float>(matParams0VZ, name: "matParams0VZ");
				matParams0VW = s.Serialize<float>(matParams0VW, name: "matParams0VW");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					Refract_alphaMul = s.Serialize<float>(Refract_alphaMul, name: "Refract_alphaMul");
					Refract_normalmul = s.Serialize<float>(Refract_normalmul, name: "Refract_normalmul");
					Reflection_factor = s.Serialize<float>(Reflection_factor, name: "Reflection_factor");
					alphafadeDistMin = s.Serialize<float>(alphafadeDistMin, name: "alphafadeDistMin");
					alphafadeDistMax = s.Serialize<float>(alphafadeDistMax, name: "alphafadeDistMax");
					alphafadeDensity = s.Serialize<float>(alphafadeDensity, name: "alphafadeDensity");
					alphafadetype = s.Serialize<int>(alphafadetype, name: "alphafadetype");
				}
			}
		}
	}
}

