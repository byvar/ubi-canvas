using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class AFXPostProcessComponent : ActorComponent {
		[Serialize(0, "blur")] public AFX_BlurParam blur;
		[Serialize(1, "glow")] public AFX_GlowParam glow;
		[Serialize(2, "colorSetting")] public AFX_ColorSettingParam colorSetting;
		[Serialize(3, "refraction", game = Settings.Game.RL)] public AFX_RefractionParam refraction;
		[Serialize(4, "tile")] public AFX_TileParam tile;
		[Serialize(5, "mosaic")] public AFX_MosaicParam mosaic;
		[Serialize(6, "tile")] public AFX_NegatifParam negatif;
		[Serialize(7, "kaleidoscope")] public AFX_KaleiParam kaleidoscope;
		[Serialize(8, "eyeFish")] public AFX_EyeFishParam eyeFish;
		[Serialize(9, "mirror")] public AFX_MirrorParam mirror;
		[Serialize(10, "oldTV")] public AFX_OldTVParam oldTV;
		[Serialize(11, "noise")] public AFX_NoiseParam noise;
		[Serialize(12, "radial")] public AFX_RadialParam radial;

		public AFXPostProcessComponent(Reader reader) : base(reader) {
		}
	}
}
