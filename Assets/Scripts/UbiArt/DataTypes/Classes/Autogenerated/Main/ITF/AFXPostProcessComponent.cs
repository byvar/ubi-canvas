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

		public AFX_SinusWaveParam sinusWave;
		public float transitionTime;
		public bool initActivatedForTrigger;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.VH || s.Settings.Game == Game.COL) {
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
			} else if(s.Settings.Game == Game.RM) {
				blur = s.SerializeObject<AFX_BlurParam>(blur, name: "blur");
				glow = s.SerializeObject<AFX_GlowParam>(glow, name: "glow");
				colorSetting = s.SerializeObject<AFX_ColorSettingParam>(colorSetting, name: "colorSetting");
				tile = s.SerializeObject<AFX_TileParam>(tile, name: "tile");
				mosaic = s.SerializeObject<AFX_MosaicParam>(mosaic, name: "mosaic");
				negatif = s.SerializeObject<AFX_NegatifParam>(negatif, name: "negatif");
				kaleidoscope = s.SerializeObject<AFX_KaleiParam>(kaleidoscope, name: "kaleidoscope");
				eyeFish = s.SerializeObject<AFX_EyeFishParam>(eyeFish, name: "eyeFish");
				sinusWave = s.SerializeObject<AFX_SinusWaveParam>(sinusWave, name: "sinusWave");
				mirror = s.SerializeObject<AFX_MirrorParam>(mirror, name: "mirror");
				oldTV = s.SerializeObject<AFX_OldTVParam>(oldTV, name: "oldTV");
				noise = s.SerializeObject<AFX_NoiseParam>(noise, name: "noise");
				radial = s.SerializeObject<AFX_RadialParam>(radial, name: "radial");
				transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
				initActivatedForTrigger = s.Serialize<bool>(initActivatedForTrigger, name: "initActivatedForTrigger");
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

