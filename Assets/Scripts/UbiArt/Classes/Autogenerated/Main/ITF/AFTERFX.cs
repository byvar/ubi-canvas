using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class AFTERFX : CSerializable {
		public AFX Type;
		public CArrayP<float> paramF;
		public CArrayP<int> paramI;
		public CArrayO<Vec3d> paramV;
		public CArrayO<Color> paramC;
		public float lifeTime;
		public Color colorTarget;

		public AFX_2 Type_2;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.VH) {
				Type_2 = s.Serialize<AFX_2>(Type_2, name: "Type");
			} else {
				Type = s.Serialize<AFX>(Type, name: "Type");
			}
			paramF = s.SerializeObject<CArrayP<float>>(paramF, name: "paramF");
			paramI = s.SerializeObject<CArrayP<int>>(paramI, name: "paramI");
			paramV = s.SerializeObject<CArrayO<Vec3d>>(paramV, name: "paramV");
			paramC = s.SerializeObject<CArrayO<Color>>(paramC, name: "paramC");
			lifeTime = s.Serialize<float>(lifeTime, name: "lifeTime");
			colorTarget = s.SerializeObject<Color>(colorTarget, name: "colorTarget");
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
		public enum AFX_2 {
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
			[Serialize("Value_14")] Value_14 = 14,
		}
	}
}

