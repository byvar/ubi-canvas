using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class AFTERFX : CSerializable {
		[Serialize("Type"               )] public AFX Type;
		[Serialize("paramF"             )] public CArray<float> paramF;
		[Serialize("paramI"             )] public CArray<int> paramI;
		[Serialize("paramC"             )] public CArray<Color> paramC;
		[Serialize("lifeTime"           )] public float lifeTime;
		[Serialize("colorTarget"        )] public Color colorTarget;
		[Serialize("Enum_RFR_0__0"      )] public Enum_RFR_0 Enum_RFR_0__0;
		[Serialize("CArray<float>__1"   )] public CArray<float> CArray_float__1;
		[Serialize("CArray<int>__2"     )] public CArray<int> CArray_int__2;
		[Serialize("CArray<Vector3>__3" )] public CArray<Vec3d> CArray_Vector3__3;
		[Serialize("CArray<Color>__4"   )] public CArray<Color> CArray_Color__4;
		[Serialize("float__5"           )] public float float__5;
		[Serialize("Color__6"           )] public Color Color__6;
		[Serialize("Enum_VH_0__7"       )] public Enum_VH_0 Enum_VH_0__7;
		[Serialize("CArray<float>__8"   )] public CArray<float> CArray_float__8;
		[Serialize("CArray<int>__9"     )] public CArray<int> CArray_int__9;
		[Serialize("CArray<Vector3>__10")] public CArray<Vec3d> CArray_Vector3__10;
		[Serialize("CArray<Color>__11"  )] public CArray<Color> CArray_Color__11;
		[Serialize("float__12"          )] public float float__12;
		[Serialize("Color__13"          )] public Color Color__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Enum_RFR_0__0));
				SerializeField(s, nameof(CArray_float__1));
				SerializeField(s, nameof(CArray_int__2));
				SerializeField(s, nameof(CArray_Vector3__3));
				SerializeField(s, nameof(CArray_Color__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(Color__6));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Enum_VH_0__7));
				SerializeField(s, nameof(CArray_float__8));
				SerializeField(s, nameof(CArray_int__9));
				SerializeField(s, nameof(CArray_Vector3__10));
				SerializeField(s, nameof(CArray_Color__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(Color__13));
			} else {
				SerializeField(s, nameof(Type));
				SerializeField(s, nameof(paramF));
				SerializeField(s, nameof(paramF));
				SerializeField(s, nameof(paramI));
				SerializeField(s, nameof(paramI));
				SerializeField(s, nameof(paramC));
				SerializeField(s, nameof(paramC));
				SerializeField(s, nameof(lifeTime));
				SerializeField(s, nameof(colorTarget));
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

