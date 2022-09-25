using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFXPostProcessComponent : ActorComponent {
		public AFX_BlurParam blur;
		public AFX_GlowParam glow;
		public AFX_ColorSettingParam colorSetting;
		public AFX_TileParam tile;
		public AFX_MosaicParam mosaic;
		public AFX_NegatifParam negatif;
		public AFX_KaleiParam kaleidoscope;
		public AFX_EyeFishParam eyeFish;
		public AFX_MirrorParam mirror;
		public AFX_OldTVParam oldTV;
		public AFX_NoiseParam noise;
		public AFX_RadialParam radial;
		public AFX_RefractionParam refraction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH || s.Settings.game == Settings.Game.COL) {
				blur = s.SerializeObject<AFX_BlurParam>(blur, name: "blur");
				glow = s.SerializeObject<AFX_GlowParam>(glow, name: "glow");
				colorSetting = s.SerializeObject<AFX_ColorSettingParam>(colorSetting, name: "colorSetting");
				refraction = s.SerializeObject<AFX_RefractionParam>(refraction, name: "refraction");
				tile = s.SerializeObject<AFX_TileParam>(tile, name: "tile");
				mosaic = s.SerializeObject<AFX_MosaicParam>(mosaic, name: "mosaic");
				negatif = s.SerializeObject<AFX_NegatifParam>(negatif, name: "negatif");
				kaleidoscope = s.SerializeObject<AFX_KaleiParam>(kaleidoscope, name: "kaleidoscope");
				eyeFish = s.SerializeObject<AFX_EyeFishParam>(eyeFish, name: "eyeFish");
				mirror = s.SerializeObject<AFX_MirrorParam>(mirror, name: "mirror");
				oldTV = s.SerializeObject<AFX_OldTVParam>(oldTV, name: "oldTV");
				noise = s.SerializeObject<AFX_NoiseParam>(noise, name: "noise");
				radial = s.SerializeObject<AFX_RadialParam>(radial, name: "radial");
			} else {
				blur = s.SerializeObject<AFX_BlurParam>(blur, name: "blur");
				glow = s.SerializeObject<AFX_GlowParam>(glow, name: "glow");
				colorSetting = s.SerializeObject<AFX_ColorSettingParam>(colorSetting, name: "colorSetting");
				tile = s.SerializeObject<AFX_TileParam>(tile, name: "tile");
				mosaic = s.SerializeObject<AFX_MosaicParam>(mosaic, name: "mosaic");
				negatif = s.SerializeObject<AFX_NegatifParam>(negatif, name: "negatif");
				kaleidoscope = s.SerializeObject<AFX_KaleiParam>(kaleidoscope, name: "kaleidoscope");
				eyeFish = s.SerializeObject<AFX_EyeFishParam>(eyeFish, name: "eyeFish");
				mirror = s.SerializeObject<AFX_MirrorParam>(mirror, name: "mirror");
				oldTV = s.SerializeObject<AFX_OldTVParam>(oldTV, name: "oldTV");
				noise = s.SerializeObject<AFX_NoiseParam>(noise, name: "noise");
				radial = s.SerializeObject<AFX_RadialParam>(radial, name: "radial");
			}
		}
		public override uint? ClassCRC => 0x2B349E69;
	}
}

