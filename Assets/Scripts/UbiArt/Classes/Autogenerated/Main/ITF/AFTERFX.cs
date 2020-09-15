using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class AFTERFX : CSerializable {
		public AFX Type;
		public CArray<float> paramF;
		public CArray<int> paramI;
		public CArray<Color> paramC;
		public float lifeTime;
		public Color colorTarget;
		public Enum_RFR_0 Enum_RFR_0__0;
		public CArray<float> CArray_float__1;
		public CArray<int> CArray_int__2;
		public CArray<Vec3d> CArray_Vector3__3;
		public CArray<Color> CArray_Color__4;
		public float float__5;
		public Color Color__6;
		public Enum_VH_0 Enum_VH_0__7;
		public CArray<float> CArray_float__8;
		public CArray<int> CArray_int__9;
		public CArray<Vec3d> CArray_Vector3__10;
		public CArray<Color> CArray_Color__11;
		public float float__12;
		public Color Color__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				Enum_RFR_0__0 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__0, name: "Enum_RFR_0__0");
				CArray_float__1 = s.SerializeObject<CArray<float>>(CArray_float__1, name: "CArray_float__1");
				CArray_int__2 = s.SerializeObject<CArray<int>>(CArray_int__2, name: "CArray_int__2");
				CArray_Vector3__3 = s.SerializeObject<CArray<Vec3d>>(CArray_Vector3__3, name: "CArray_Vector3__3");
				CArray_Color__4 = s.SerializeObject<CArray<Color>>(CArray_Color__4, name: "CArray_Color__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				Color__6 = s.SerializeObject<Color>(Color__6, name: "Color__6");
			} else if (Settings.s.game == Settings.Game.VH) {
				Enum_VH_0__7 = s.Serialize<Enum_VH_0>(Enum_VH_0__7, name: "Enum_VH_0__7");
				CArray_float__8 = s.SerializeObject<CArray<float>>(CArray_float__8, name: "CArray_float__8");
				CArray_int__9 = s.SerializeObject<CArray<int>>(CArray_int__9, name: "CArray_int__9");
				CArray_Vector3__10 = s.SerializeObject<CArray<Vec3d>>(CArray_Vector3__10, name: "CArray_Vector3__10");
				CArray_Color__11 = s.SerializeObject<CArray<Color>>(CArray_Color__11, name: "CArray_Color__11");
				float__12 = s.Serialize<float>(float__12, name: "float__12");
				Color__13 = s.SerializeObject<Color>(Color__13, name: "Color__13");
			} else {
				Type = s.Serialize<AFX>(Type, name: "Type");
				paramF = s.SerializeObject<CArray<float>>(paramF, name: "paramF");
				paramF = s.SerializeObject<CArray<float>>(paramF, name: "paramF");
				paramI = s.SerializeObject<CArray<int>>(paramI, name: "paramI");
				paramI = s.SerializeObject<CArray<int>>(paramI, name: "paramI");
				paramC = s.SerializeObject<CArray<Color>>(paramC, name: "paramC");
				paramC = s.SerializeObject<CArray<Color>>(paramC, name: "paramC");
				lifeTime = s.Serialize<float>(lifeTime, name: "lifeTime");
				colorTarget = s.SerializeObject<Color>(colorTarget, name: "colorTarget");
			}
		}
		public enum AFX {
			[Serialize("AFX_None"          )] None = 0,
			[Serialize("AFX_Blur"          )] Blur = 1,
			[Serialize("AFX_Glow"          )] Glow = 2,
			[Serialize("AFX_Remanence"     )] Remanence = 3,
			[Serialize("AFX_DOF"           )] DOF = 4,
			[Serialize("AFX_RayCenter"     )] RayCenter = 5,
			[Serialize("AFX_ColorSetting"  )] ColorSetting = 6,
			[Serialize("AFX_ColorRemap"    )] ColorRemap = 7,
			[Serialize("AFX_ColorLevels"   )] ColorLevels = 8,
			[Serialize("AFX_Fade"          )] Fade = 9,
			[Serialize("AFX_Bright"        )] Bright = 10,
			[Serialize("AFX_AddSceneAndMul")] AddSceneAndMul = 11,
			[Serialize("AFX_objectsGlow"   )] objectsGlow = 12,
			[Serialize("AFX_simpleBlend"   )] simpleBlend = 13,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
		}
	}
}

