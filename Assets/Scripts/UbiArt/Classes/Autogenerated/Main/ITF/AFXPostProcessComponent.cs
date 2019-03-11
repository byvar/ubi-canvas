using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFXPostProcessComponent : ActorComponent {
		[Serialize("blur"        )] public AFX_BlurParam blur;
		[Serialize("glow"        )] public AFX_GlowParam glow;
		[Serialize("colorSetting")] public AFX_ColorSettingParam colorSetting;
		[Serialize("tile"        )] public AFX_TileParam tile;
		[Serialize("mosaic"      )] public AFX_MosaicParam mosaic;
		[Serialize("negatif"     )] public AFX_NegatifParam negatif;
		[Serialize("kaleidoscope")] public AFX_KaleiParam kaleidoscope;
		[Serialize("eyeFish"     )] public AFX_EyeFishParam eyeFish;
		[Serialize("mirror"      )] public AFX_MirrorParam mirror;
		[Serialize("oldTV"       )] public AFX_OldTVParam oldTV;
		[Serialize("noise"       )] public AFX_NoiseParam noise;
		[Serialize("radial"      )] public AFX_RadialParam radial;
		[Serialize("refraction"  )] public Placeholder refraction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(blur));
				SerializeField(s, nameof(glow));
				SerializeField(s, nameof(colorSetting));
				SerializeField(s, nameof(refraction));
				SerializeField(s, nameof(tile));
				SerializeField(s, nameof(mosaic));
				SerializeField(s, nameof(negatif));
				SerializeField(s, nameof(kaleidoscope));
				SerializeField(s, nameof(eyeFish));
				SerializeField(s, nameof(mirror));
				SerializeField(s, nameof(oldTV));
				SerializeField(s, nameof(noise));
				SerializeField(s, nameof(radial));
			} else {
				SerializeField(s, nameof(blur));
				SerializeField(s, nameof(glow));
				SerializeField(s, nameof(colorSetting));
				SerializeField(s, nameof(tile));
				SerializeField(s, nameof(mosaic));
				SerializeField(s, nameof(negatif));
				SerializeField(s, nameof(kaleidoscope));
				SerializeField(s, nameof(eyeFish));
				SerializeField(s, nameof(mirror));
				SerializeField(s, nameof(oldTV));
				SerializeField(s, nameof(noise));
				SerializeField(s, nameof(radial));
			}
		}
		public override uint? ClassCRC => 0x2B349E69;
	}
}

